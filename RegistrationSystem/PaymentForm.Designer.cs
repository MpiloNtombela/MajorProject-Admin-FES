namespace RegistrationSystem
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.PayNowBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.XePayLogo = new System.Windows.Forms.Panel();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.PayPartIcon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalDue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegistrationFee = new System.Windows.Forms.Label();
            this.RegistrationFeeLabel = new System.Windows.Forms.Label();
            this.TuitionFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NoteReg = new System.Windows.Forms.Label();
            this.TuitionFeeCalc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.XePayLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PayNowBtn
            // 
            this.PayNowBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.PayNowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayNowBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PayNowBtn.FlatAppearance.BorderSize = 0;
            this.PayNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayNowBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayNowBtn.ForeColor = System.Drawing.Color.White;
            this.PayNowBtn.Location = new System.Drawing.Point(480, 276);
            this.PayNowBtn.Name = "PayNowBtn";
            this.PayNowBtn.Size = new System.Drawing.Size(128, 34);
            this.PayNowBtn.TabIndex = 31;
            this.PayNowBtn.Text = "PAY NOW";
            this.PayNowBtn.UseVisualStyleBackColor = false;
            this.PayNowBtn.Click += new System.EventHandler(this.PayNowBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(263, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Powered by";
            // 
            // XePayLogo
            // 
            this.XePayLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.XePayLogo.Controls.Add(this.LogoIcon);
            this.XePayLogo.Controls.Add(this.PayPartIcon);
            this.XePayLogo.Location = new System.Drawing.Point(349, 325);
            this.XePayLogo.Name = "XePayLogo";
            this.XePayLogo.Size = new System.Drawing.Size(64, 28);
            this.XePayLogo.TabIndex = 35;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Payment Gateway";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.49306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.50694F));
            this.tableLayoutPanel1.Controls.Add(this.RegistrationFee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RegistrationFeeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TuitionFee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.58621F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.41379F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 98);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // TotalDue
            // 
            this.TotalDue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalDue.AutoSize = true;
            this.TotalDue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDue.ForeColor = System.Drawing.Color.LimeGreen;
            this.TotalDue.Location = new System.Drawing.Point(550, 6);
            this.TotalDue.Name = "TotalDue";
            this.TotalDue.Size = new System.Drawing.Size(23, 25);
            this.TotalDue.TabIndex = 5;
            this.TotalDue.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total Due";
            // 
            // RegistrationFee
            // 
            this.RegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RegistrationFee.AutoSize = true;
            this.RegistrationFee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationFee.ForeColor = System.Drawing.Color.White;
            this.RegistrationFee.Location = new System.Drawing.Point(550, 59);
            this.RegistrationFee.Name = "RegistrationFee";
            this.RegistrationFee.Size = new System.Drawing.Size(23, 25);
            this.RegistrationFee.TabIndex = 3;
            this.RegistrationFee.Text = "0";
            // 
            // RegistrationFeeLabel
            // 
            this.RegistrationFeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RegistrationFeeLabel.AutoSize = true;
            this.RegistrationFeeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationFeeLabel.ForeColor = System.Drawing.Color.Silver;
            this.RegistrationFeeLabel.Location = new System.Drawing.Point(3, 59);
            this.RegistrationFeeLabel.Name = "RegistrationFeeLabel";
            this.RegistrationFeeLabel.Size = new System.Drawing.Size(155, 25);
            this.RegistrationFeeLabel.TabIndex = 2;
            this.RegistrationFeeLabel.Text = "Registration Fee";
            // 
            // TuitionFee
            // 
            this.TuitionFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TuitionFee.AutoSize = true;
            this.TuitionFee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuitionFee.ForeColor = System.Drawing.Color.White;
            this.TuitionFee.Location = new System.Drawing.Point(550, 10);
            this.TuitionFee.Name = "TuitionFee";
            this.TuitionFee.Size = new System.Drawing.Size(23, 25);
            this.TuitionFee.TabIndex = 1;
            this.TuitionFee.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tuition Fee";
            // 
            // NoteReg
            // 
            this.NoteReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoteReg.AutoSize = true;
            this.NoteReg.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteReg.ForeColor = System.Drawing.Color.DarkGray;
            this.NoteReg.Location = new System.Drawing.Point(29, 238);
            this.NoteReg.Name = "NoteReg";
            this.NoteReg.Size = new System.Drawing.Size(261, 13);
            this.NoteReg.TabIndex = 39;
            this.NoteReg.Text = "Note: *Registration Fee is a madatory one time fee";
            // 
            // TuitionFeeCalc
            // 
            this.TuitionFeeCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TuitionFeeCalc.AutoSize = true;
            this.TuitionFeeCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuitionFeeCalc.ForeColor = System.Drawing.Color.DarkGray;
            this.TuitionFeeCalc.Location = new System.Drawing.Point(183, 218);
            this.TuitionFeeCalc.Name = "TuitionFeeCalc";
            this.TuitionFeeCalc.Size = new System.Drawing.Size(60, 13);
            this.TuitionFeeCalc.TabIndex = 40;
            this.TuitionFeeCalc.Text = "calculation";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(29, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Note: *Tuition Fee calculation (AmountDue / PaymentPlan)";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Orange;
            this.CancelButton.Location = new System.Drawing.Point(331, 276);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(143, 34);
            this.CancelButton.TabIndex = 42;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.PayNowBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.TuitionFeeCalc);
            this.panel1.Controls.Add(this.XePayLogo);
            this.panel1.Controls.Add(this.NoteReg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 356);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(32, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 10);
            this.panel2.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.49215F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.50785F));
            this.tableLayoutPanel2.Controls.Add(this.TotalDue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 150);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 38);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.XePayLogo.ResumeLayout(false);
            this.XePayLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PayNowBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel XePayLogo;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Label PayPartIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TotalDue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RegistrationFee;
        private System.Windows.Forms.Label RegistrationFeeLabel;
        private System.Windows.Forms.Label TuitionFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NoteReg;
        private System.Windows.Forms.Label TuitionFeeCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
    }
}