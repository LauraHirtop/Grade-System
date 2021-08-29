namespace Proiect_complet_nou
{
    partial class InfoShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty of Letters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bellow you have all the data related to the exams already taken.";
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Semester,
            this.Grade,
            this.Status});
            this.tableInfo.Location = new System.Drawing.Point(16, 111);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.Size = new System.Drawing.Size(717, 265);
            this.tableInfo.TabIndex = 2;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.DataPropertyName = "subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Promovare";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.ForeColor = System.Drawing.Color.Maroon;
            this.buttonLogout.Location = new System.Drawing.Point(573, 22);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(160, 32);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // InfoShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(750, 406);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tableInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoShow";
            this.Text = "InfoShow";
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tableInfo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}