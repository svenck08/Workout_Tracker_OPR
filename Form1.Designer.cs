namespace Workout_Tracker_OPR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lb_vaje = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbIzbiraVaje = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKoncajTrening = new System.Windows.Forms.Button();
            this.btnPavzaNadaljuj = new System.Windows.Forms.Button();
            this.btnZacniTrening = new System.Windows.Forms.Button();
            this.lblCasTreninga = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numRpe = new System.Windows.Forms.NumericUpDown();
            this.btnIzbrisiSet = new System.Windows.Forms.Button();
            this.numPonovitve = new System.Windows.Forms.NumericUpDown();
            this.lblSkupniVolumen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTrenutniSeti = new System.Windows.Forms.DataGridView();
            this.btnDodajPotrdi = new System.Windows.Forms.Button();
            this.numTeza = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnItbrisiPodatke = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Vaje = new System.Windows.Forms.Label();
            this.btnDodajVajo = new System.Windows.Forms.Button();
            this.btnSpremeniVajo = new System.Windows.Forms.Button();
            this.btnOdstraniVajo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPonovitve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeza)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lb_vaje);
            this.tabControl1.Location = new System.Drawing.Point(66, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 188);
            this.tabControl1.TabIndex = 0;
            // 
            // lb_vaje
            // 
            this.lb_vaje.Location = new System.Drawing.Point(4, 22);
            this.lb_vaje.Name = "lb_vaje";
            this.lb_vaje.Padding = new System.Windows.Forms.Padding(3);
            this.lb_vaje.Size = new System.Drawing.Size(413, 162);
            this.lb_vaje.TabIndex = 0;
            this.lb_vaje.Text = "List Vseh Vaj";
            this.lb_vaje.UseVisualStyleBackColor = true;
            this.lb_vaje.Click += new System.EventHandler(this.List_vaj_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(67, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Statusni label";
            // 
            // cmbIzbiraVaje
            // 
            this.cmbIzbiraVaje.FormattingEnabled = true;
            this.cmbIzbiraVaje.Location = new System.Drawing.Point(6, 40);
            this.cmbIzbiraVaje.Name = "cmbIzbiraVaje";
            this.cmbIzbiraVaje.Size = new System.Drawing.Size(121, 21);
            this.cmbIzbiraVaje.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKoncajTrening);
            this.groupBox1.Controls.Add(this.btnPavzaNadaljuj);
            this.groupBox1.Controls.Add(this.btnZacniTrening);
            this.groupBox1.Controls.Add(this.lblCasTreninga);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numRpe);
            this.groupBox1.Controls.Add(this.btnIzbrisiSet);
            this.groupBox1.Controls.Add(this.numPonovitve);
            this.groupBox1.Controls.Add(this.lblSkupniVolumen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvTrenutniSeti);
            this.groupBox1.Controls.Add(this.btnDodajPotrdi);
            this.groupBox1.Controls.Add(this.numTeza);
            this.groupBox1.Controls.Add(this.cmbIzbiraVaje);
            this.groupBox1.Location = new System.Drawing.Point(66, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trening";
            // 
            // btnKoncajTrening
            // 
            this.btnKoncajTrening.Location = new System.Drawing.Point(543, 98);
            this.btnKoncajTrening.Name = "btnKoncajTrening";
            this.btnKoncajTrening.Size = new System.Drawing.Size(100, 23);
            this.btnKoncajTrening.TabIndex = 20;
            this.btnKoncajTrening.Text = "Končaj trening";
            this.btnKoncajTrening.UseVisualStyleBackColor = true;
            // 
            // btnPavzaNadaljuj
            // 
            this.btnPavzaNadaljuj.Location = new System.Drawing.Point(543, 68);
            this.btnPavzaNadaljuj.Name = "btnPavzaNadaljuj";
            this.btnPavzaNadaljuj.Size = new System.Drawing.Size(100, 23);
            this.btnPavzaNadaljuj.TabIndex = 19;
            this.btnPavzaNadaljuj.Text = "Pavza / Nadaljuj";
            this.btnPavzaNadaljuj.UseVisualStyleBackColor = true;
            // 
            // btnZacniTrening
            // 
            this.btnZacniTrening.Location = new System.Drawing.Point(543, 38);
            this.btnZacniTrening.Name = "btnZacniTrening";
            this.btnZacniTrening.Size = new System.Drawing.Size(100, 23);
            this.btnZacniTrening.TabIndex = 18;
            this.btnZacniTrening.Text = "Začni trening";
            this.btnZacniTrening.UseVisualStyleBackColor = true;
            // 
            // lblCasTreninga
            // 
            this.lblCasTreninga.AutoSize = true;
            this.lblCasTreninga.Location = new System.Drawing.Point(130, 95);
            this.lblCasTreninga.Name = "lblCasTreninga";
            this.lblCasTreninga.Size = new System.Drawing.Size(41, 13);
            this.lblCasTreninga.TabIndex = 17;
            this.lblCasTreninga.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Čas Treninga";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 20);
            this.button2.TabIndex = 15;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ponovitve";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Teža";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Izbira Vaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Izbira RPE (6-10)";
            // 
            // numRpe
            // 
            this.numRpe.Location = new System.Drawing.Point(269, 93);
            this.numRpe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRpe.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numRpe.Name = "numRpe";
            this.numRpe.Size = new System.Drawing.Size(120, 20);
            this.numRpe.TabIndex = 10;
            this.numRpe.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btnIzbrisiSet
            // 
            this.btnIzbrisiSet.Location = new System.Drawing.Point(395, 64);
            this.btnIzbrisiSet.Name = "btnIzbrisiSet";
            this.btnIzbrisiSet.Size = new System.Drawing.Size(100, 23);
            this.btnIzbrisiSet.TabIndex = 9;
            this.btnIzbrisiSet.Text = "izbriši";
            this.btnIzbrisiSet.UseVisualStyleBackColor = true;
            // 
            // numPonovitve
            // 
            this.numPonovitve.Location = new System.Drawing.Point(269, 41);
            this.numPonovitve.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numPonovitve.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPonovitve.Name = "numPonovitve";
            this.numPonovitve.Size = new System.Drawing.Size(120, 20);
            this.numPonovitve.TabIndex = 8;
            this.numPonovitve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSkupniVolumen
            // 
            this.lblSkupniVolumen.AutoSize = true;
            this.lblSkupniVolumen.Location = new System.Drawing.Point(7, 95);
            this.lblSkupniVolumen.Name = "lblSkupniVolumen";
            this.lblSkupniVolumen.Size = new System.Drawing.Size(35, 13);
            this.lblSkupniVolumen.TabIndex = 7;
            this.lblSkupniVolumen.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Skupni volumen vaj";
            // 
            // dgvTrenutniSeti
            // 
            this.dgvTrenutniSeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenutniSeti.Location = new System.Drawing.Point(10, 139);
            this.dgvTrenutniSeti.Name = "dgvTrenutniSeti";
            this.dgvTrenutniSeti.Size = new System.Drawing.Size(707, 190);
            this.dgvTrenutniSeti.TabIndex = 5;
            // 
            // btnDodajPotrdi
            // 
            this.btnDodajPotrdi.Location = new System.Drawing.Point(395, 38);
            this.btnDodajPotrdi.Name = "btnDodajPotrdi";
            this.btnDodajPotrdi.Size = new System.Drawing.Size(100, 23);
            this.btnDodajPotrdi.TabIndex = 4;
            this.btnDodajPotrdi.Text = "Dodaj / Potrdi";
            this.btnDodajPotrdi.UseVisualStyleBackColor = true;
            // 
            // numTeza
            // 
            this.numTeza.Location = new System.Drawing.Point(133, 41);
            this.numTeza.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numTeza.Name = "numTeza";
            this.numTeza.Size = new System.Drawing.Size(120, 20);
            this.numTeza.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnItbrisiPodatke);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(857, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 616);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shranjeni treningi / statistika";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(470, 231);
            this.dataGridView2.TabIndex = 21;
            // 
            // btnItbrisiPodatke
            // 
            this.btnItbrisiPodatke.Location = new System.Drawing.Point(362, 124);
            this.btnItbrisiPodatke.Name = "btnItbrisiPodatke";
            this.btnItbrisiPodatke.Size = new System.Drawing.Size(100, 23);
            this.btnItbrisiPodatke.TabIndex = 4;
            this.btnItbrisiPodatke.Text = "Izbriši podatke";
            this.btnItbrisiPodatke.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "PR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trenirane misicne skupine ta dan,teden,mesec";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Volumen vaj (dan,teden,mesec)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // Vaje
            // 
            this.Vaje.AutoSize = true;
            this.Vaje.Location = new System.Drawing.Point(67, 64);
            this.Vaje.Name = "Vaje";
            this.Vaje.Size = new System.Drawing.Size(28, 13);
            this.Vaje.TabIndex = 6;
            this.Vaje.Text = "Vaje";
            // 
            // btnDodajVajo
            // 
            this.btnDodajVajo.Location = new System.Drawing.Point(504, 102);
            this.btnDodajVajo.Name = "btnDodajVajo";
            this.btnDodajVajo.Size = new System.Drawing.Size(98, 23);
            this.btnDodajVajo.TabIndex = 7;
            this.btnDodajVajo.Text = "Dodaj Vajo";
            this.btnDodajVajo.UseVisualStyleBackColor = true;
            // 
            // btnSpremeniVajo
            // 
            this.btnSpremeniVajo.Location = new System.Drawing.Point(504, 171);
            this.btnSpremeniVajo.Name = "btnSpremeniVajo";
            this.btnSpremeniVajo.Size = new System.Drawing.Size(98, 23);
            this.btnSpremeniVajo.TabIndex = 8;
            this.btnSpremeniVajo.Text = "Spremeni Vajo";
            this.btnSpremeniVajo.UseVisualStyleBackColor = true;
            // 
            // btnOdstraniVajo
            // 
            this.btnOdstraniVajo.Location = new System.Drawing.Point(504, 241);
            this.btnOdstraniVajo.Name = "btnOdstraniVajo";
            this.btnOdstraniVajo.Size = new System.Drawing.Size(98, 23);
            this.btnOdstraniVajo.TabIndex = 9;
            this.btnOdstraniVajo.Text = "Odstrani Vajo";
            this.btnOdstraniVajo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 710);
            this.Controls.Add(this.btnOdstraniVajo);
            this.Controls.Add(this.btnSpremeniVajo);
            this.Controls.Add(this.btnDodajVajo);
            this.Controls.Add(this.Vaje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPonovitve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeza)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lb_vaje;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbIzbiraVaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTrenutniSeti;
        private System.Windows.Forms.Button btnDodajPotrdi;
        private System.Windows.Forms.NumericUpDown numTeza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnItbrisiPodatke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSkupniVolumen;
        private System.Windows.Forms.Label Vaje;
        private System.Windows.Forms.Button btnDodajVajo;
        private System.Windows.Forms.Button btnSpremeniVajo;
        private System.Windows.Forms.Button btnOdstraniVajo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRpe;
        private System.Windows.Forms.Button btnIzbrisiSet;
        private System.Windows.Forms.NumericUpDown numPonovitve;
        private System.Windows.Forms.Button btnKoncajTrening;
        private System.Windows.Forms.Button btnPavzaNadaljuj;
        private System.Windows.Forms.Button btnZacniTrening;
        private System.Windows.Forms.Label lblCasTreninga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

