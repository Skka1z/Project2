namespace OOPlab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubjectColm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PairNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameOfTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "TxtBoxSubject";
            this.textBox1.Location = new System.Drawing.Point(631, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 29);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleName = "LblSubject";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AccessibleName = "LblNumberOfLecture";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecture №";
            // 
            // label3
            // 
            this.label3.AccessibleName = "LblDayOfTheWeek";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day of the week";
            // 
            // label4
            // 
            this.label4.AccessibleName = "LblSurename";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname of lector";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "TxtBoxSurenaeOfLectore";
            this.textBox4.Location = new System.Drawing.Point(631, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 29);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.AccessibleName = "BtnAdd";
            this.button1.Location = new System.Drawing.Point(923, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBoxDayOfWeek
            // 
            this.ComboBoxDayOfWeek.AccessibleName = "ComboBoxDayOfWeek";
            this.ComboBoxDayOfWeek.FormattingEnabled = true;
            this.ComboBoxDayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.ComboBoxDayOfWeek.Location = new System.Drawing.Point(631, 160);
            this.ComboBoxDayOfWeek.Name = "ComboBoxDayOfWeek";
            this.ComboBoxDayOfWeek.Size = new System.Drawing.Size(232, 32);
            this.ComboBoxDayOfWeek.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(631, 111);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(232, 29);
            this.numericUpDown1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectColm,
            this.PairNumber,
            this.DayOfWeek,
            this.SurnameOfTeacher});
            this.dataGridView1.Location = new System.Drawing.Point(57, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1386, 606);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SubjectColm
            // 
            this.SubjectColm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectColm.HeaderText = "Subject";
            this.SubjectColm.MinimumWidth = 8;
            this.SubjectColm.Name = "SubjectColm";
            // 
            // PairNumber
            // 
            this.PairNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PairNumber.FillWeight = 70F;
            this.PairNumber.HeaderText = "Pair Number";
            this.PairNumber.MinimumWidth = 8;
            this.PairNumber.Name = "PairNumber";
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.HeaderText = "Day of week";
            this.DayOfWeek.MinimumWidth = 8;
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Width = 150;
            // 
            // SurnameOfTeacher
            // 
            this.SurnameOfTeacher.HeaderText = "Teacher Surname ";
            this.SurnameOfTeacher.MinimumWidth = 8;
            this.SurnameOfTeacher.Name = "SurnameOfTeacher";
            this.SurnameOfTeacher.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1512, 1037);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ComboBoxDayOfWeek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LessonSchedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBoxDayOfWeek;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectColm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PairNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameOfTeacher;
    }
}

