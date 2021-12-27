using RegistrationSystem.UserControls;

namespace RegistrationSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogIn_label = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.Passcode_control = new RegistrationSystem.UserControls.UcInputField();
            this.EmailAddress_control = new RegistrationSystem.UserControls.UcInputField();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIn_label
            // 
            this.LogIn_label.AutoSize = true;
            this.LogIn_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_label.ForeColor = System.Drawing.Color.White;
            this.LogIn_label.Location = new System.Drawing.Point(131, 12);
            this.LogIn_label.Name = "LogIn_label";
            this.LogIn_label.Size = new System.Drawing.Size(87, 32);
            this.LogIn_label.TabIndex = 2;
            this.LogIn_label.Text = "Log In";
            // 
            // Close_button
            // 
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Close_button.Location = new System.Drawing.Point(305, 15);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(31, 29);
            this.Close_button.TabIndex = 5;
            this.Close_button.Text = "❌";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Controls.Add(this.LogIn_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 81);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.LogIn_button);
            this.panel2.Controls.Add(this.Passcode_control);
            this.panel2.Controls.Add(this.EmailAddress_control);
            this.panel2.Location = new System.Drawing.Point(2, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 337);
            this.panel2.TabIndex = 7;
            // 
            // LogIn_button
            // 
            this.LogIn_button.BackColor = System.Drawing.Color.DarkOrange;
            this.LogIn_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_button.FlatAppearance.BorderSize = 0;
            this.LogIn_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.LogIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogIn_button.Location = new System.Drawing.Point(12, 235);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(315, 37);
            this.LogIn_button.TabIndex = 10;
            this.LogIn_button.Text = "LOG IN";
            this.LogIn_button.UseVisualStyleBackColor = false;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // Passcode_control
            // 
            this.Passcode_control.AutoSize = true;
            this.Passcode_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Passcode_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passcode_control.InputHasError = false;
            this.Passcode_control.InputLabel = "Password";
            this.Passcode_control.InputText = "Password";
            this.Passcode_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Secrete;
            this.Passcode_control.Location = new System.Drawing.Point(9, 122);
            this.Passcode_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Passcode_control.Name = "Passcode_control";
            this.Passcode_control.Size = new System.Drawing.Size(326, 67);
            this.Passcode_control.TabIndex = 9;
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
            this.EmailAddress_control.Location = new System.Drawing.Point(9, 47);
            this.EmailAddress_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailAddress_control.Name = "EmailAddress_control";
            this.EmailAddress_control.Size = new System.Drawing.Size(326, 67);
            this.EmailAddress_control.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(348, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LogIn_label;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogIn_button;
        private UcInputField Passcode_control;
        private UcInputField EmailAddress_control;
    }
}