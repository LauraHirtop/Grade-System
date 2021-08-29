namespace Proiect_complet_nou
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
            this.title = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(21, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Faculty of Letters";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(189, 72);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(80, 22);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(97, 97);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(275, 29);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(97, 168);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(275, 29);
            this.password.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(189, 143);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 22);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(166, 267);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(134, 45);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(97, 217);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(78, 26);
            this.radioStudent.TabIndex = 6;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Location = new System.Drawing.Point(255, 217);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(77, 26);
            this.radioTeacher.TabIndex = 7;
            this.radioTeacher.TabStop = true;
            this.radioTeacher.Text = "teacher";
            this.radioTeacher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(481, 382);
            this.Controls.Add(this.radioTeacher);
            this.Controls.Add(this.radioStudent);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioTeacher;
    }
}

