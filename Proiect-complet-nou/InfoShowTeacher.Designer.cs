namespace Proiect_complet_nou
{
    partial class InfoShowTeacher
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
            this.Titlu = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.textMic = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tableTeacher = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonAllData = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlu
            // 
            this.Titlu.AutoSize = true;
            this.Titlu.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlu.Location = new System.Drawing.Point(22, 15);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(200, 32);
            this.Titlu.TabIndex = 0;
            this.Titlu.Text = "Faculty of Letters";
            // 
            // buttonLogout
            // 
            this.buttonLogout.ForeColor = System.Drawing.Color.Maroon;
            this.buttonLogout.Location = new System.Drawing.Point(689, 17);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(149, 36);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // comboSearch
            // 
            this.comboSearch.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "Name",
            "Subject",
            "Semester"});
            this.comboSearch.Location = new System.Drawing.Point(185, 66);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(236, 28);
            this.comboSearch.TabIndex = 2;
            // 
            // textMic
            // 
            this.textMic.AutoSize = true;
            this.textMic.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMic.Location = new System.Drawing.Point(58, 70);
            this.textMic.Name = "textMic";
            this.textMic.Size = new System.Drawing.Size(98, 26);
            this.textMic.TabIndex = 3;
            this.textMic.Text = "Search by:";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(448, 66);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(234, 28);
            this.searchBox.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSearch.Location = new System.Drawing.Point(700, 61);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 35);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = ">";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tableTeacher
            // 
            this.tableTeacher.AllowUserToAddRows = false;
            this.tableTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableTeacher.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tableTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTeacher.Location = new System.Drawing.Point(218, 104);
            this.tableTeacher.Name = "tableTeacher";
            this.tableTeacher.Size = new System.Drawing.Size(620, 358);
            this.tableTeacher.TabIndex = 6;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveChanges.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSaveChanges.Location = new System.Drawing.Point(28, 241);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(150, 31);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Add Entry";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonAllData
            // 
            this.buttonAllData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAllData.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAllData.Location = new System.Drawing.Point(12, 117);
            this.buttonAllData.Name = "buttonAllData";
            this.buttonAllData.Size = new System.Drawing.Size(194, 48);
            this.buttonAllData.TabIndex = 8;
            this.buttonAllData.Text = "GET ALL THE DATA";
            this.buttonAllData.UseVisualStyleBackColor = false;
            this.buttonAllData.Click += new System.EventHandler(this.buttonAllData_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(63, 399);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 35);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelete.Location = new System.Drawing.Point(28, 294);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 31);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete entry";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Operations:";
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonModify.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonModify.Location = new System.Drawing.Point(28, 345);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(150, 32);
            this.buttonModify.TabIndex = 12;
            this.buttonModify.Text = "Modify grade";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // InfoShowTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(854, 474);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAllData);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.tableTeacher);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.textMic);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.Titlu);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoShowTeacher";
            this.Text = "InfoShowTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.tableTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label textMic;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView tableTeacher;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonAllData;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModify;
    }
}