using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker_library
{
    public enum ExerciseType
    {
        Moc,
        Kardio,
        Regeneracija
    }
    public struct TrainingVolume
    {
        public double Value { get; private set; }

        public TrainingVolume(double value)
        {
            if (value < 0) value = 0;
            Value = value;
        }

        public static TrainingVolume operator +(TrainingVolume a, TrainingVolume b)
        {
            return new TrainingVolume(a.Value + b.Value);
        }

        public static bool operator >(TrainingVolume a, TrainingVolume b) { return a.Value > b.Value; }
        public static bool operator <(TrainingVolume a, TrainingVolume b) { return a.Value < b.Value; }

        public override string ToString()
        {
            return Value.ToString("0");
        }
    }
    public class Exercise
    {
        public const int MinNameLength = 2;                // const ✅
        private static int _nextId = 1;                    // static ✅

        public int Id { get; private set; }
        public string Name { get; private set; }
        public ExerciseType Type { get; private set; }
        public string Device { get; private set; }

        private readonly List<string> _primaryMuscles;     // kapsulacija ✅
        public IReadOnlyList<string> PrimaryMuscles { get { return _primaryMuscles.AsReadOnly(); } }

        public readonly DateTime CreatedAt;                // readonly ✅

        public Exercise(string name, ExerciseType type, string device, IEnumerable<string> primaryMuscles)
        {
            Id = _nextId++;
            CreatedAt = DateTime.Now;
            _primaryMuscles = new List<string>();

            Update(name, type, device, primaryMuscles);
        }

        public virtual void Update(string name, ExerciseType type, string device, IEnumerable<string> primaryMuscles)
        {
            name = (name ?? "").Trim();
            device = (device ?? "").Trim();

            if (name.Length < MinNameLength) throw new ArgumentException("Ime vaje mora imeti vsaj 2 znaka.");
            if (device.Length == 0) throw new ArgumentException("Izberi napravo.");

            List<string> muscles = (primaryMuscles ?? new string[0])
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x => x.Trim())
                .Distinct()
                .ToList();

            if (muscles.Count == 0) throw new ArgumentException("Izberi vsaj eno mišično skupino.");

            Name = name;
            Type = type;
            Device = device;

            _primaryMuscles.Clear();
            _primaryMuscles.AddRange(muscles);
        }

        public override string ToString()
        {
            return Name + " (" + Type + ", " + Device + ")";
        }
    }
    public class StrengthExercise : Exercise
    {
        public const int DefaultRest = 120;      // const ✅
        public int DefaultRestSeconds { get; private set; }

        public StrengthExercise(string name, string device, IEnumerable<string> primaryMuscles)
            : base(name, ExerciseType.Moc, device, primaryMuscles)
        {
            DefaultRestSeconds = DefaultRest;
        }
        public StrengthExercise(string name, string device, IEnumerable<string> primaryMuscles, int defaultRestSeconds)
            : base(name, ExerciseType.Moc, device, primaryMuscles)
        {
            DefaultRestSeconds = defaultRestSeconds;
        }
    }
    public class SetEntry
    {
        public const int MinRpe = 1;
        public const int MaxRpe = 10;

        public Exercise Exercise { get; private set; }
        public double WeightKg { get; private set; }
        public int Reps { get; private set; }
        public int Rpe { get; private set; }

        public readonly DateTime CreatedAt;

        public SetEntry(Exercise exercise, double weightKg, int reps, int rpe)
        {
            if (exercise == null) throw new ArgumentNullException("exercise");
            if (weightKg < 0) throw new ArgumentException("Teža ne sme biti negativna.");
            if (reps <= 0) throw new ArgumentException("Ponovitve morajo biti > 0.");
            if (rpe < MinRpe || rpe > MaxRpe) throw new ArgumentException("RPE mora biti 1–10.");

            Exercise = exercise;
            WeightKg = weightKg;
            Reps = reps;
            Rpe = rpe;
            CreatedAt = DateTime.Now;
        }

        // objektna metoda ✅
        public TrainingVolume Volume()
        {
            return new TrainingVolume(WeightKg * Reps);
        }

        // za prikaz v DataGridView:
        public string ExerciseName { get { return Exercise.Name; } }
        public double VolumeValue { get { return Volume().Value; } }
    }
    public class WorkoutSession
    {
        private readonly BindingList<SetEntry> _sets;

        private DateTime _start;
        private DateTime _end;
        private TimeSpan _pausedTotal;
        private DateTime? _pauseStarted;

        public DateTime StartTime { get { return _start; } }
        public DateTime EndTime { get { return _end; } }
        public bool IsActive { get; private set; }
        public bool IsPaused { get { return _pauseStarted.HasValue; } }

        public BindingList<SetEntry> Sets { get { return _sets; } }

        public WorkoutSession()
        {
            _sets = new BindingList<SetEntry>();
            _pausedTotal = TimeSpan.Zero;
            IsActive = false;
        }

        public void Start()
        {
            _sets.Clear();
            _pausedTotal = TimeSpan.Zero;
            _pauseStarted = null;

            _start = DateTime.Now;
            _end = DateTime.MinValue;
            IsActive = true;
        }

        public void Pause()
        {
            if (!IsActive) return;
            if (_pauseStarted.HasValue) return;
            _pauseStarted = DateTime.Now;
        }

        public void Resume()
        {
            if (!IsActive) return;
            if (!_pauseStarted.HasValue) return;

            _pausedTotal += (DateTime.Now - _pauseStarted.Value);
            _pauseStarted = null;
        }

        public void End()
        {
            if (!IsActive) return;

            if (_pauseStarted.HasValue)
                Resume();

            _end = DateTime.Now;
            IsActive = false;
        }

        public TimeSpan Duration
        {
            get
            {
                if (!IsActive && _end == DateTime.MinValue) return TimeSpan.Zero;

                DateTime now = IsActive ? DateTime.Now : _end;
                TimeSpan raw = now - _start - _pausedTotal;

                if (_pauseStarted.HasValue)
                    raw -= (DateTime.Now - _pauseStarted.Value);

                if (raw < TimeSpan.Zero) raw = TimeSpan.Zero;
                return raw;
            }
        }

        public string DurationText
        {
            get { return Duration.ToString(@"hh\:mm\:ss"); }
        }

        public void AddSet(SetEntry set)
        {
            _sets.Add(set);
        }

        public void RemoveSetAt(int index)
        {
            if (index < 0 || index >= _sets.Count) return;
            _sets.RemoveAt(index);
        }

        public void ReplaceSetAt(int index, SetEntry set)
        {
            if (index < 0 || index >= _sets.Count) return;
            _sets[index] = set;
        }

        public TrainingVolume TotalVolume
        {
            get
            {
                TrainingVolume sum = new TrainingVolume(0);
                foreach (SetEntry s in _sets)
                    sum = sum + s.Volume(); // operator + ✅
                return sum;
            }
        }

        public double TotalVolumeValue { get { return TotalVolume.Value; } }

        public override string ToString()
        {
            return StartTime.ToString("dd.MM.yyyy HH:mm") + " (" + DurationText + "), Vol=" + TotalVolume;
        }
    }
    public static class StatisticsCalculator
    {
        public static SetEntry GetOverallPRByWeight(IEnumerable<WorkoutSession> sessions)
        {
            if (sessions == null) return null;

            SetEntry best = null;
            foreach (WorkoutSession s in sessions)
            {
                foreach (SetEntry set in s.Sets)
                {
                    if (best == null || set.WeightKg > best.WeightKg)
                        best = set;
                }
            }
            return best;
        }

        public static TrainingVolume GetVolumeSince(IEnumerable<WorkoutSession> sessions, DateTime from)
        {
            TrainingVolume sum = new TrainingVolume(0);
            foreach (WorkoutSession s in sessions)
            {
                if (s.StartTime >= from)
                    sum = sum + s.TotalVolume;
            }
            return sum;
        }

        public static List<string> GetMusclesSince(IEnumerable<WorkoutSession> sessions, DateTime from)
        {
            HashSet<string> muscles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (WorkoutSession s in sessions)
            {
                if (s.StartTime < from) continue;

                foreach (SetEntry set in s.Sets)
                {
                    foreach (string m in set.Exercise.PrimaryMuscles)
                        muscles.Add(m);
                }
            }

            return muscles.OrderBy(x => x).ToList();
        }
    }


    public class Class1
    {
    }
}
