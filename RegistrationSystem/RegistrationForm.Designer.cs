using RegistrationSystem.UserControls;

namespace RegistrationSystem
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegistrationForm_panel = new System.Windows.Forms.Panel();
            this.ConfirmPasscode_control = new RegistrationSystem.UserControls.UcInputField();
            this.Passcode_control = new RegistrationSystem.UserControls.UcInputField();
            this.EmailAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.LastName_control = new RegistrationSystem.UserControls.UcInputField();
            this.FirstName_control = new RegistrationSystem.UserControls.UcInputField();
            this.Register_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.Register_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quote_label = new System.Windows.Forms.Label();
            this.Register_errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.RegistrationForm_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Register_errorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quote_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 534);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.RegistrationForm_panel);
            this.panel2.Controls.Add(this.Register_button);
            this.panel2.Controls.Add(this.Close_button);
            this.panel2.Controls.Add(this.Register_label);
            this.panel2.Location = new System.Drawing.Point(244, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 531);
            this.panel2.TabIndex = 2;
            // 
            // RegistrationForm_panel
            // 
            this.RegistrationForm_panel.Controls.Add(this.ConfirmPasscode_control);
            this.RegistrationForm_panel.Controls.Add(this.Passcode_control);
            this.RegistrationForm_panel.Controls.Add(this.EmailAddress_control);
            this.RegistrationForm_panel.Controls.Add(this.LastName_control);
            this.RegistrationForm_panel.Controls.Add(this.FirstName_control);
            this.RegistrationForm_panel.Location = new System.Drawing.Point(10, 47);
            this.RegistrationForm_panel.Name = "RegistrationForm_panel";
            this.RegistrationForm_panel.Size = new System.Drawing.Size(307, 376);
            this.RegistrationForm_panel.TabIndex = 16;
            // 
            // ConfirmPasscode_control
            // 
            this.ConfirmPasscode_control.AutoSize = true;
            this.ConfirmPasscode_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ConfirmPasscode_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasscode_control.InputHasError = false;
            this.ConfirmPasscode_control.InputLabel = "Confirm Password";
            this.ConfirmPasscode_control.InputMax = 10;
            this.ConfirmPasscode_control.InputMin = 5;
            this.ConfirmPasscode_control.InputText = "Confirm Password";
            this.ConfirmPasscode_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Secrete;
            this.ConfirmPasscode_control.Location = new System.Drawing.Point(3, 288);
            this.ConfirmPasscode_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPasscode_control.Name = "ConfirmPasscode_control";
            this.ConfirmPasscode_control.Size = new System.Drawing.Size(299, 63);
            this.ConfirmPasscode_control.TabIndex = 17;
            this.ConfirmPasscode_control.Tag = "CustomInputControl";
            this.ConfirmPasscode_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // Passcode_control
            // 
            this.Passcode_control.AutoSize = true;
            this.Passcode_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Passcode_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passcode_control.InputHasError = false;
            this.Passcode_control.InputLabel = "Password";
            this.Passcode_control.InputMax = 10;
            this.Passcode_control.InputMin = 5;
            this.Passcode_control.InputText = "Password";
            this.Passcode_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Secrete;
            this.Passcode_control.Location = new System.Drawing.Point(3, 217);
            this.Passcode_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Passcode_control.Name = "Passcode_control";
            this.Passcode_control.Size = new System.Drawing.Size(299, 63);
            this.Passcode_control.TabIndex = 16;
            this.Passcode_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
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
            this.EmailAddress_control.Location = new System.Drawing.Point(3, 146);
            this.EmailAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailAddress_control.Name = "EmailAddress_control";
            this.EmailAddress_control.Size = new System.Drawing.Size(299, 63);
            this.EmailAddress_control.TabIndex = 14;
            this.EmailAddress_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // LastName_control
            // 
            this.LastName_control.AutoSize = true;
            this.LastName_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LastName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_control.InputHasError = false;
            this.LastName_control.InputLabel = "Last Name";
            this.LastName_control.InputMax = 32;
            this.LastName_control.InputMin = 3;
            this.LastName_control.InputText = "Last Name";
            this.LastName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.LastName_control.Location = new System.Drawing.Point(3, 75);
            this.LastName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastName_control.Name = "LastName_control";
            this.LastName_control.Size = new System.Drawing.Size(299, 63);
            this.LastName_control.TabIndex = 12;
            this.LastName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
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
            this.FirstName_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Word;
            this.FirstName_control.Location = new System.Drawing.Point(3, 4);
            this.FirstName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName_control.Name = "FirstName_control";
            this.FirstName_control.Size = new System.Drawing.Size(299, 63);
            this.FirstName_control.TabIndex = 10;
            this.FirstName_control.InputFieldError += new System.EventHandler<RegistrationSystem.UserControls.InputFieldErrorEventArgs>(this.InputFieldError_Event);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.DarkOrange;
            this.Register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_button.FlatAppearance.BorderSize = 0;
            this.Register_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.ForeColor = System.Drawing.Color.White;
            this.Register_button.Location = new System.Drawing.Point(20, 429);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(279, 37);
            this.Register_button.TabIndex = 15;
            this.Register_button.Text = "REGISTER";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Close_button.Location = new System.Drawing.Point(279, 9);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(33, 29);
            this.Close_button.TabIndex = 14;
            this.Close_button.Text = "❌";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_label.Location = new System.Drawing.Point(92, 6);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(154, 32);
            this.Register_label.TabIndex = 13;
            this.Register_label.Text = "Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "~ Nelson Mandela";
            // 
            // Quote_label
            // 
            this.Quote_label.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quote_label.ForeColor = System.Drawing.Color.White;
            this.Quote_label.Location = new System.Drawing.Point(24, 82);
            this.Quote_label.Name = "Quote_label";
            this.Quote_label.Size = new System.Drawing.Size(212, 299);
            this.Quote_label.TabIndex = 0;
            this.Quote_label.Text = "\"Education is the most powerful weapon which you can use to change the world.\"";
            // 
            // Register_errorprovider
            // 
            this.Register_errorprovider.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(571, 534);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.RegistrationForm_panel.ResumeLayout(false);
            this.RegistrationForm_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Register_errorprovider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quote_label;
        private System.Windows.Forms.ErrorProvider Register_errorprovider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel RegistrationForm_panel;
        private UcInputField ConfirmPasscode_control;
        private UcInputField Passcode_control;
        private UcInputField EmailAddress_control;
        private UcInputField LastName_control;
        private UcInputField FirstName_control;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Label Register_label;
    }
}