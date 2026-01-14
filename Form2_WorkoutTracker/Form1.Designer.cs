namespace Form2_WorkoutTracker
{
    partial class Form2
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
            this.tb_ImeVaje = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajbtn = new System.Windows.Forms.Button();
            this.opustibtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_moč = new System.Windows.Forms.RadioButton();
            this.rd_kardio = new System.Windows.Forms.RadioButton();
            this.rd_regeneracija = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ImeVaje
            // 
            this.tb_ImeVaje.Location = new System.Drawing.Point(12, 72);
            this.tb_ImeVaje.Name = "tb_ImeVaje";
            this.tb_ImeVaje.Size = new System.Drawing.Size(100, 20);
            this.tb_ImeVaje.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(189, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 197);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primarna misicna skupina";
            // 
            // dodajbtn
            // 
            this.dodajbtn.Location = new System.Drawing.Point(431, 136);
            this.dodajbtn.Name = "dodajbtn";
            this.dodajbtn.Size = new System.Drawing.Size(75, 23);
            this.dodajbtn.TabIndex = 6;
            this.dodajbtn.Text = "&Dodaj";
            this.dodajbtn.UseVisualStyleBackColor = true;
            // 
            // opustibtn
            // 
            this.opustibtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.opustibtn.Location = new System.Drawing.Point(431, 165);
            this.opustibtn.Name = "opustibtn";
            this.opustibtn.Size = new System.Drawing.Size(75, 23);
            this.opustibtn.TabIndex = 7;
            this.opustibtn.Text = "&Opusti";
            this.opustibtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime vaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "na kateri napravi se dela";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Prsa",
            "Hrbet",
            "Trup",
            "Noge",
            "Rame",
            "Biceps",
            "Triceps"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(187, 169);
            this.checkedListBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_regeneracija);
            this.groupBox2.Controls.Add(this.rd_kardio);
            this.groupBox2.Controls.Add(this.rd_moč);
            this.groupBox2.Location = new System.Drawing.Point(15, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tip vaje";
            // 
            // rd_moč
            // 
            this.rd_moč.AutoSize = true;
            this.rd_moč.Location = new System.Drawing.Point(7, 29);
            this.rd_moč.Name = "rd_moč";
            this.rd_moč.Size = new System.Drawing.Size(46, 17);
            this.rd_moč.TabIndex = 0;
            this.rd_moč.TabStop = true;
            this.rd_moč.Text = "Moč";
            this.rd_moč.UseVisualStyleBackColor = true;
            // 
            // rd_kardio
            // 
            this.rd_kardio.AutoSize = true;
            this.rd_kardio.Location = new System.Drawing.Point(7, 52);
            this.rd_kardio.Name = "rd_kardio";
            this.rd_kardio.Size = new System.Drawing.Size(55, 17);
            this.rd_kardio.TabIndex = 1;
            this.rd_kardio.TabStop = true;
            this.rd_kardio.Text = "Kardio";
            this.rd_kardio.UseVisualStyleBackColor = true;
            // 
            // rd_regeneracija
            // 
            this.rd_regeneracija.AutoSize = true;
            this.rd_regeneracija.Location = new System.Drawing.Point(7, 76);
            this.rd_regeneracija.Name = "rd_regeneracija";
            this.rd_regeneracija.Size = new System.Drawing.Size(88, 17);
            this.rd_regeneracija.TabIndex = 2;
            this.rd_regeneracija.TabStop = true;
            this.rd_regeneracija.Text = "Regeneracija";
            this.rd_regeneracija.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.dodajbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.opustibtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opustibtn);
            this.Controls.Add(this.dodajbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_ImeVaje);
            this.Name = "Form2";
            this.Text = "add Exercise Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ImeVaje;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajbtn;
        private System.Windows.Forms.Button opustibtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_regeneracija;
        private System.Windows.Forms.RadioButton rd_kardio;
        private System.Windows.Forms.RadioButton rd_moč;
    }
}

