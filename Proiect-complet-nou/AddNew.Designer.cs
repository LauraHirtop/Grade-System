namespace Proiect_complet_nou
{
    partial class AddNew
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
            this.comboStudents = new System.Windows.Forms.ComboBox();
            this.labelstudent = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.comboSubjects = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboStudents
            // 
            this.comboStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboStudents.FormattingEnabled = true;
            this.comboStudents.Items.AddRange(new object[] {
            "-Select Name-"});
            this.comboStudents.Location = new System.Drawing.Point(80, 14);
            this.comboStudents.Name = "comboStudents";
            this.comboStudents.Size = new System.Drawing.Size(239, 28);
            this.comboStudents.TabIndex = 0;
            // 
            // labelstudent
            // 
            this.labelstudent.AutoSize = true;
            this.labelstudent.Location = new System.Drawing.Point(12, 17);
            this.labelstudent.Name = "labelstudent";
            this.labelstudent.Size = new System.Drawing.Size(62, 20);
            this.labelstudent.TabIndex = 1;
            this.labelstudent.Text = "Student";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(15, 57);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(59, 20);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject";
            // 
            // comboSubjects
            // 
            this.comboSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboSubjects.FormattingEnabled = true;
            this.comboSubjects.Location = new System.Drawing.Point(80, 54);
            this.comboSubjects.Name = "comboSubjects";
            this.comboSubjects.Size = new System.Drawing.Size(239, 28);
            this.comboSubjects.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 28);
            this.textBox1.TabIndex = 4;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(25, 98);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(49, 20);
            this.labelGrade.TabIndex = 5;
            this.labelGrade.Text = "Grade";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox3.Location = new System.Drawing.Point(242, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(77, 28);
            this.comboBox3.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(183, 98);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 20);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Passed";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonInsert.Location = new System.Drawing.Point(218, 139);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(101, 34);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Add";
            this.buttonInsert.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(16, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 34);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(338, 186);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboSubjects);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelstudent);
            this.Controls.Add(this.comboStudents);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStudents;
        private System.Windows.Forms.Label labelstudent;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboSubjects;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonCancel;
    }
}