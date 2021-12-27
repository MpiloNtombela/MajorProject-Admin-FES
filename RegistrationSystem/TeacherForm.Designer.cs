namespace RegistrationSystem
{
    partial class TeacherForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Button();
            this.TeacherDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.GenderContainer_panel = new System.Windows.Forms.Panel();
            this.GenderField_panel = new System.Windows.Forms.Panel();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Gender_combobox = new System.Windows.Forms.ComboBox();
            this.GenderBottom_panel = new System.Windows.Forms.Panel();
            this.AddTeacher_btn = new System.Windows.Forms.Button();
            this.EmailAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.Qualification_control = new RegistrationSystem.UserControls.UcInputField();
            this.LastName_control = new RegistrationSystem.UserControls.UcInputField();
            this.FirstName_control = new RegistrationSystem.UserControls.UcInputField();
            this.panel1.SuspendLayout();
            this.TeacherDetails_groupbox.SuspendLayout();
            this.GenderContainer_panel.SuspendLayout();
            this.GenderField_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Controls.Add(this.TeacherDetails_groupbox);
            this.panel1.Controls.Add(this.AddTeacher_btn);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 545);
            this.panel1.TabIndex = 36;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close_btn.FlatAppearance.BorderSize = 2;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.Red;
            this.Close_btn.Location = new System.Drawing.Point(11, 469);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(174, 34);
            this.Close_btn.TabIndex = 33;
            this.Close_btn.Text = "CANCEL";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // TeacherDetails_groupbox
            // 
            this.TeacherDetails_groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TeacherDetails_groupbox.Controls.Add(this.GenderContainer_panel);
            this.TeacherDetails_groupbox.Controls.Add(this.EmailAddress_control);
            this.TeacherDetails_groupbox.Controls.Add(this.Qualification_control);
            this.TeacherDetails_groupbox.Controls.Add(this.LastName_control);
            this.TeacherDetails_groupbox.Controls.Add(this.FirstName_control);
            this.TeacherDetails_groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherDetails_groupbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherDetails_groupbox.ForeColor = System.Drawing.Color.White;
            this.TeacherDetails_groupbox.Location = new System.Drawing.Point(10, 7);
            this.TeacherDetails_groupbox.Name = "TeacherDetails_groupbox";
            this.TeacherDetails_groupbox.Size = new System.Drawing.Size(356, 429);
            this.TeacherDetails_groupbox.TabIndex = 31;
            this.TeacherDetails_groupbox.TabStop = false;
            this.TeacherDetails_groupbox.Text = "Teacher Details";
            // 
            // GenderContainer_panel
            // 
            this.GenderContainer_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderContainer_panel.Controls.Add(this.GenderField_panel);
            this.GenderContainer_panel.Location = new System.Drawing.Point(9, 331);
            this.GenderContainer_panel.Name = "GenderContainer_panel";
            this.GenderContainer_panel.Size = new System.Drawing.Size(333, 63);
            this.GenderContainer_panel.TabIndex = 16;
            // 
            // GenderField_panel
            // 
            this.GenderField_panel.Controls.Add(this.Gender_label);
            this.GenderField_panel.Controls.Add(this.Gender_combobox);
            this.GenderField_panel.Controls.Add(this.GenderBottom_panel);
            this.GenderField_panel.Location = new System.Drawing.Point(4, 1);
            this.GenderField_panel.Name = "GenderField_panel";
            this.GenderField_panel.Size = new System.Drawing.Size(326, 57);
            this.GenderField_panel.TabIndex = 0;
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_label.ForeColor = System.Drawing.Color.DimGray;
            this.Gender_label.Location = new System.Drawing.Point(-3, 5);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(51, 17);
            this.Gender_label.TabIndex = 18;
            this.Gender_label.Text = "Gender";
            // 
            // Gender_combobox
            // 
            this.Gender_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.Gender_combobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_combobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_combobox.ForeColor = System.Drawing.Color.White;
            this.Gender_combobox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Gender_combobox.Location = new System.Drawing.Point(0, 29);
            this.Gender_combobox.Name = "Gender_combobox";
            this.Gender_combobox.Size = new System.Drawing.Size(326, 25);
            this.Gender_combobox.TabIndex = 0;
            this.Gender_combobox.TabStop = false;
            this.Gender_combobox.Tag = "WinInputControl";
            // 
            // GenderBottom_panel
            // 
            this.GenderBottom_panel.BackColor = System.Drawing.Color.DarkGray;
            this.GenderBottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenderBottom_panel.Location = new System.Drawing.Point(0, 54);
            this.GenderBottom_panel.Name = "GenderBottom_panel";
            this.GenderBottom_panel.Size = new System.Drawing.Size(326, 3);
            this.GenderBottom_panel.TabIndex = 19;
            // 
            // AddTeacher_btn
            // 
            this.AddTeacher_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.AddTeacher_btn.FlatAppearance.BorderSize = 0;
            this.AddTeacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeacher_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacher_btn.ForeColor = System.Drawing.Color.White;
            this.AddTeacher_btn.Location = new System.Drawing.Point(191, 469);
            this.AddTeacher_btn.Name = "AddTeacher_btn";
            this.AddTeacher_btn.Size = new System.Drawing.Size(173, 34);
            this.AddTeacher_btn.TabIndex = 32;
            this.AddTeacher_btn.Text = "ADD TEACHER";
            this.AddTeacher_btn.UseVisualStyleBackColor = false;
            this.AddTeacher_btn.Click += new System.EventHandler(this.AddTeacher_btn_Click);
            // 
            // EmailAddress_control
            // 
            this.EmailAddress_control.AutoSize = true;
            this.EmailAddress_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.EmailAddress_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress_control.InputHasError = false;
            this.EmailAddress_control.InputLabel = "Email Address";
            this.EmailAddress_control.InputText = "Email Address";
            this.EmailAddress_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Email;
            this.EmailAddress_control.Location = new System.Drawing.Point(6, 190);
            this.EmailAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailAddress_control.Name = "EmailAddress_control";
            this.EmailAddress_control.Size = new System.Drawing.Size(344, 63);
            this.EmailAddress_control.TabIndex = 2;
            this.EmailAddress_control.Tag = "CustomInputControl";
            // 
            // Qualification_control
            // 
            this.Qualification_control.AutoSize = true;
            this.Qualification_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Qualification_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qualification_control.InputHasError = false;
            this.Qualification_control.InputLabel = "Qualification (i.e degree)";
            this.Qualification_control.InputMax = 16;
            this.Qualification_control.InputMin = 1;
            this.Qualification_control.InputText = "Qualification (i.e degree)";
            this.Qualification_control.Location = new System.Drawing.Point(6, 261);
            this.Qualification_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qualification_control.Name = "Qualification_control";
            this.Qualification_control.Size = new System.Drawing.Size(344, 63);
            this.Qualification_control.TabIndex = 3;
            this.Qualification_control.Tag = "CustomInputControl";
            // 
            // LastName_control
            // 
            this.LastName_control.AutoSize = true;
            this.LastName_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LastName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_control.InputHasError = false;
            this.LastName_control.InputLabel = "Last Name";
            this.LastName_control.InputMax = 64;
            this.LastName_control.InputMin = 3;
            this.LastName_control.InputText = "Last Name";
            this.LastName_control.Location = new System.Drawing.Point(6, 119);
            this.LastName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastName_control.Name = "LastName_control";
            this.LastName_control.Size = new System.Drawing.Size(344, 63);
            this.LastName_control.TabIndex = 1;
            this.LastName_control.Tag = "CustomInputControl";
            // 
            // FirstName_control
            // 
            this.FirstName_control.AutoSize = true;
            this.FirstName_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.FirstName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_control.InputHasError = false;
            this.FirstName_control.InputLabel = "First Name";
            this.FirstName_control.InputMax = 32;
            this.FirstName_control.InputMin = 3;
            this.FirstName_control.InputText = "First Name";
            this.FirstName_control.Location = new System.Drawing.Point(6, 48);
            this.FirstName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName_control.Name = "FirstName_control";
            this.FirstName_control.Size = new System.Drawing.Size(344, 63);
            this.FirstName_control.TabIndex = 0;
            this.FirstName_control.Tag = "CustomInputControl";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(377, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.panel1.ResumeLayout(false);
            this.TeacherDetails_groupbox.ResumeLayout(false);
            this.TeacherDetails_groupbox.PerformLayout();
            this.GenderContainer_panel.ResumeLayout(false);
            this.GenderField_panel.ResumeLayout(false);
            this.GenderField_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox TeacherDetails_groupbox;
        private UserControls.UcInputField Qualification_control;
        private UserControls.UcInputField LastName_control;
        private UserControls.UcInputField FirstName_control;
        private System.Windows.Forms.Button AddTeacher_btn;
        private UserControls.UcInputField EmailAddress_control;
        private System.Windows.Forms.Panel GenderContainer_panel;
        private System.Windows.Forms.Panel GenderField_panel;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.ComboBox Gender_combobox;
        private System.Windows.Forms.Panel GenderBottom_panel;
        private System.Windows.Forms.Button Close_btn;
    }
}