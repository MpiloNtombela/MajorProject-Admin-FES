namespace RegistrationSystem
{
    partial class BankingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankingForm));
            this.BankingDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.ExDateContainer_panel = new System.Windows.Forms.Panel();
            this.ExpiryDate_label = new System.Windows.Forms.Label();
            this.ExDate_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExpMonth_combobox = new System.Windows.Forms.ComboBox();
            this.ExpYear_combobox = new System.Windows.Forms.ComboBox();
            this.CVVorCVC_control = new RegistrationSystem.UserControls.UcInputField();
            this.CardNumber_control = new RegistrationSystem.UserControls.UcInputField();
            this.CardholderName_control = new RegistrationSystem.UserControls.UcInputField();
            this.BankName_control = new RegistrationSystem.UserControls.UcInputField();
            this.AddBank_btn = new System.Windows.Forms.Button();
            this.XePayLogo = new System.Windows.Forms.Panel();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.PayPartIcon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BankingDetails_groupbox.SuspendLayout();
            this.ExDateContainer_panel.SuspendLayout();
            this.ExDate_panel.SuspendLayout();
            this.XePayLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankingDetails_groupbox
            // 
            this.BankingDetails_groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BankingDetails_groupbox.Controls.Add(this.ExDateContainer_panel);
            this.BankingDetails_groupbox.Controls.Add(this.CVVorCVC_control);
            this.BankingDetails_groupbox.Controls.Add(this.CardNumber_control);
            this.BankingDetails_groupbox.Controls.Add(this.CardholderName_control);
            this.BankingDetails_groupbox.Controls.Add(this.BankName_control);
            this.BankingDetails_groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BankingDetails_groupbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankingDetails_groupbox.ForeColor = System.Drawing.Color.White;
            this.BankingDetails_groupbox.Location = new System.Drawing.Point(10, 7);
            this.BankingDetails_groupbox.Name = "BankingDetails_groupbox";
            this.BankingDetails_groupbox.Size = new System.Drawing.Size(356, 429);
            this.BankingDetails_groupbox.TabIndex = 31;
            this.BankingDetails_groupbox.TabStop = false;
            this.BankingDetails_groupbox.Text = "Banking Detals";
            // 
            // ExDateContainer_panel
            // 
            this.ExDateContainer_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExDateContainer_panel.Controls.Add(this.ExpiryDate_label);
            this.ExDateContainer_panel.Controls.Add(this.ExDate_panel);
            this.ExDateContainer_panel.Location = new System.Drawing.Point(10, 286);
            this.ExDateContainer_panel.Name = "ExDateContainer_panel";
            this.ExDateContainer_panel.Size = new System.Drawing.Size(171, 73);
            this.ExDateContainer_panel.TabIndex = 6;
            // 
            // ExpiryDate_label
            // 
            this.ExpiryDate_label.AutoSize = true;
            this.ExpiryDate_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDate_label.ForeColor = System.Drawing.Color.Gray;
            this.ExpiryDate_label.Location = new System.Drawing.Point(3, 2);
            this.ExpiryDate_label.Name = "ExpiryDate_label";
            this.ExpiryDate_label.Size = new System.Drawing.Size(66, 15);
            this.ExpiryDate_label.TabIndex = 21;
            this.ExpiryDate_label.Text = "Expiry Date";
            // 
            // ExDate_panel
            // 
            this.ExDate_panel.Controls.Add(this.label3);
            this.ExDate_panel.Controls.Add(this.label4);
            this.ExDate_panel.Controls.Add(this.panel3);
            this.ExDate_panel.Controls.Add(this.ExpMonth_combobox);
            this.ExDate_panel.Controls.Add(this.ExpYear_combobox);
            this.ExDate_panel.Location = new System.Drawing.Point(7, 20);
            this.ExDate_panel.Name = "ExDate_panel";
            this.ExDate_panel.Size = new System.Drawing.Size(158, 50);
            this.ExDate_panel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(92, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(16, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 3);
            this.panel3.TabIndex = 17;
            // 
            // ExpMonth_combobox
            // 
            this.ExpMonth_combobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExpMonth_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.ExpMonth_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpMonth_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpMonth_combobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpMonth_combobox.ForeColor = System.Drawing.Color.White;
            this.ExpMonth_combobox.FormatString = "N0";
            this.ExpMonth_combobox.FormattingEnabled = true;
            this.ExpMonth_combobox.Location = new System.Drawing.Point(83, 19);
            this.ExpMonth_combobox.Name = "ExpMonth_combobox";
            this.ExpMonth_combobox.Size = new System.Drawing.Size(74, 25);
            this.ExpMonth_combobox.TabIndex = 2;
            this.ExpMonth_combobox.TabStop = false;
            this.ExpMonth_combobox.Tag = "WinInputControl";
            // 
            // ExpYear_combobox
            // 
            this.ExpYear_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.ExpYear_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpYear_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpYear_combobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpYear_combobox.ForeColor = System.Drawing.Color.White;
            this.ExpYear_combobox.FormatString = "N0";
            this.ExpYear_combobox.FormattingEnabled = true;
            this.ExpYear_combobox.Location = new System.Drawing.Point(3, 20);
            this.ExpYear_combobox.Name = "ExpYear_combobox";
            this.ExpYear_combobox.Size = new System.Drawing.Size(74, 25);
            this.ExpYear_combobox.TabIndex = 1;
            this.ExpYear_combobox.TabStop = false;
            this.ExpYear_combobox.Tag = "WinInputControl";
            // 
            // CVVorCVC_control
            // 
            this.CVVorCVC_control.AutoSize = true;
            this.CVVorCVC_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.CVVorCVC_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVorCVC_control.InputHasError = false;
            this.CVVorCVC_control.InputLabel = "cvc/cvv";
            this.CVVorCVC_control.InputMax = 3;
            this.CVVorCVC_control.InputMin = 3;
            this.CVVorCVC_control.InputText = "cvc/cvv";
            this.CVVorCVC_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Number;
            this.CVVorCVC_control.Location = new System.Drawing.Point(187, 300);
            this.CVVorCVC_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CVVorCVC_control.Name = "CVVorCVC_control";
            this.CVVorCVC_control.Size = new System.Drawing.Size(163, 63);
            this.CVVorCVC_control.TabIndex = 4;
            this.CVVorCVC_control.Tag = "CustomInputControl";
            // 
            // CardNumber_control
            // 
            this.CardNumber_control.AutoSize = true;
            this.CardNumber_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.CardNumber_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber_control.InputHasError = false;
            this.CardNumber_control.InputLabel = "Card Number";
            this.CardNumber_control.InputMax = 16;
            this.CardNumber_control.InputMin = 16;
            this.CardNumber_control.InputText = "Card Number";
            this.CardNumber_control.InputType = RegistrationSystem.UserControls.UcInputField.InputTypes.Number;
            this.CardNumber_control.Location = new System.Drawing.Point(10, 202);
            this.CardNumber_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardNumber_control.Name = "CardNumber_control";
            this.CardNumber_control.Size = new System.Drawing.Size(344, 63);
            this.CardNumber_control.TabIndex = 2;
            this.CardNumber_control.Tag = "CustomInputControl";
            // 
            // CardholderName_control
            // 
            this.CardholderName_control.AutoSize = true;
            this.CardholderName_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.CardholderName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardholderName_control.InputHasError = false;
            this.CardholderName_control.InputLabel = "Cardholder Name";
            this.CardholderName_control.InputMax = 64;
            this.CardholderName_control.InputMin = 3;
            this.CardholderName_control.InputText = "Cardholder Name";
            this.CardholderName_control.Location = new System.Drawing.Point(6, 131);
            this.CardholderName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardholderName_control.Name = "CardholderName_control";
            this.CardholderName_control.Size = new System.Drawing.Size(344, 63);
            this.CardholderName_control.TabIndex = 1;
            this.CardholderName_control.Tag = "CustomInputControl";
            // 
            // BankName_control
            // 
            this.BankName_control.AutoSize = true;
            this.BankName_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BankName_control.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankName_control.InputHasError = false;
            this.BankName_control.InputLabel = "Bank Name";
            this.BankName_control.InputMax = 32;
            this.BankName_control.InputMin = 3;
            this.BankName_control.InputText = "Bank Name";
            this.BankName_control.Location = new System.Drawing.Point(6, 48);
            this.BankName_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BankName_control.Name = "BankName_control";
            this.BankName_control.Size = new System.Drawing.Size(344, 63);
            this.BankName_control.TabIndex = 0;
            this.BankName_control.Tag = "CustomInputControl";
            // 
            // AddBank_btn
            // 
            this.AddBank_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.AddBank_btn.FlatAppearance.BorderSize = 0;
            this.AddBank_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBank_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBank_btn.ForeColor = System.Drawing.Color.White;
            this.AddBank_btn.Location = new System.Drawing.Point(8, 469);
            this.AddBank_btn.Name = "AddBank_btn";
            this.AddBank_btn.Size = new System.Drawing.Size(356, 34);
            this.AddBank_btn.TabIndex = 32;
            this.AddBank_btn.Text = "ADD BANK DETAILS";
            this.AddBank_btn.UseVisualStyleBackColor = false;
            this.AddBank_btn.Click += new System.EventHandler(this.AddBank_btn_Click);
            // 
            // XePayLogo
            // 
            this.XePayLogo.Controls.Add(this.LogoIcon);
            this.XePayLogo.Controls.Add(this.PayPartIcon);
            this.XePayLogo.Location = new System.Drawing.Point(204, 509);
            this.XePayLogo.Name = "XePayLogo";
            this.XePayLogo.Size = new System.Drawing.Size(64, 28);
            this.XePayLogo.TabIndex = 33;
            // 
            // LogoIcon
            // 
            this.LogoIcon.Image = global::RegistrationSystem.Properties.Resources.favicon_16x16;
            this.LogoIcon.Location = new System.Drawing.Point(3, 3);
            this.LogoIcon.Name = "LogoIcon";
            this.LogoIcon.Size = new System.Drawing.Size(28, 22);
            this.LogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoIcon.TabIndex = 35;
            this.LogoIcon.TabStop = false;
            // 
            // PayPartIcon
            // 
            this.PayPartIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayPartIcon.AutoSize = true;
            this.PayPartIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayPartIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayPartIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.PayPartIcon.Location = new System.Drawing.Point(26, 7);
            this.PayPartIcon.Margin = new System.Windows.Forms.Padding(0);
            this.PayPartIcon.Name = "PayPartIcon";
            this.PayPartIcon.Size = new System.Drawing.Size(38, 21);
            this.PayPartIcon.TabIndex = 0;
            this.PayPartIcon.Text = "Pay";
            this.PayPartIcon.Click += new System.EventHandler(this.PayPartIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(117, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Protected by";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.XePayLogo);
            this.panel1.Controls.Add(this.BankingDetails_groupbox);
            this.panel1.Controls.Add(this.AddBank_btn);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 545);
            this.panel1.TabIndex = 35;
            // 
            // BankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(377, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking Form";
            this.Load += new System.EventHandler(this.BankingForm_Load);
            this.BankingDetails_groupbox.ResumeLayout(false);
            this.BankingDetails_groupbox.PerformLayout();
            this.ExDateContainer_panel.ResumeLayout(false);
            this.ExDateContainer_panel.PerformLayout();
            this.ExDate_panel.ResumeLayout(false);
            this.ExDate_panel.PerformLayout();
            this.XePayLogo.ResumeLayout(false);
            this.XePayLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BankingDetails_groupbox;
        private System.Windows.Forms.Panel ExDateContainer_panel;
        private System.Windows.Forms.Label ExpiryDate_label;
        private System.Windows.Forms.Panel ExDate_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ExpMonth_combobox;
        private System.Windows.Forms.ComboBox ExpYear_combobox;
        private UserControls.UcInputField CVVorCVC_control;
        private UserControls.UcInputField CardNumber_control;
        private UserControls.UcInputField CardholderName_control;
        private UserControls.UcInputField BankName_control;
        private System.Windows.Forms.Button AddBank_btn;
        private System.Windows.Forms.Panel XePayLogo;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Label PayPartIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}