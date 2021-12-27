namespace RegistrationSystem.UserControls
{
    partial class UcPaymentPlan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaymentPlanBG_panel = new System.Windows.Forms.Panel();
            this.Months_label = new System.Windows.Forms.Label();
            this.ExpectedPay_label = new System.Windows.Forms.Label();
            this.SelectPayment_picturebox = new System.Windows.Forms.PictureBox();
            this.PaymentPlanDescription_label = new System.Windows.Forms.Label();
            this.PaymentPlanLength_label = new System.Windows.Forms.Label();
            this.PaymentPlanTitle_label = new System.Windows.Forms.Label();
            this.PaymentPlanBG_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPayment_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPlanBG_panel
            // 
            this.PaymentPlanBG_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.PaymentPlanBG_panel.Controls.Add(this.Months_label);
            this.PaymentPlanBG_panel.Controls.Add(this.ExpectedPay_label);
            this.PaymentPlanBG_panel.Controls.Add(this.SelectPayment_picturebox);
            this.PaymentPlanBG_panel.Controls.Add(this.PaymentPlanDescription_label);
            this.PaymentPlanBG_panel.Controls.Add(this.PaymentPlanLength_label);
            this.PaymentPlanBG_panel.Controls.Add(this.PaymentPlanTitle_label);
            this.PaymentPlanBG_panel.ForeColor = System.Drawing.Color.LightGray;
            this.PaymentPlanBG_panel.Location = new System.Drawing.Point(3, 3);
            this.PaymentPlanBG_panel.Name = "PaymentPlanBG_panel";
            this.PaymentPlanBG_panel.Size = new System.Drawing.Size(219, 304);
            this.PaymentPlanBG_panel.TabIndex = 0;
            // 
            // Months_label
            // 
            this.Months_label.AutoSize = true;
            this.Months_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Months_label.ForeColor = System.Drawing.Color.LightGray;
            this.Months_label.Location = new System.Drawing.Point(73, 112);
            this.Months_label.Name = "Months_label";
            this.Months_label.Size = new System.Drawing.Size(115, 37);
            this.Months_label.TabIndex = 15;
            this.Months_label.Text = "Months";
            this.Months_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpectedPay_label
            // 
            this.ExpectedPay_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpectedPay_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpectedPay_label.ForeColor = System.Drawing.Color.LightGray;
            this.ExpectedPay_label.Location = new System.Drawing.Point(3, 270);
            this.ExpectedPay_label.Name = "ExpectedPay_label";
            this.ExpectedPay_label.Size = new System.Drawing.Size(213, 21);
            this.ExpectedPay_label.TabIndex = 14;
            this.ExpectedPay_label.Text = "Expected Pay";
            this.ExpectedPay_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectPayment_picturebox
            // 
            this.SelectPayment_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectPayment_picturebox.Image = global::RegistrationSystem.Properties.Resources.check_icon;
            this.SelectPayment_picturebox.Location = new System.Drawing.Point(187, 3);
            this.SelectPayment_picturebox.Name = "SelectPayment_picturebox";
            this.SelectPayment_picturebox.Size = new System.Drawing.Size(29, 27);
            this.SelectPayment_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectPayment_picturebox.TabIndex = 13;
            this.SelectPayment_picturebox.TabStop = false;
            this.SelectPayment_picturebox.Click += new System.EventHandler(this.SelectPayment_picturebox_Click);
            // 
            // PaymentPlanDescription_label
            // 
            this.PaymentPlanDescription_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPlanDescription_label.ForeColor = System.Drawing.Color.LightGray;
            this.PaymentPlanDescription_label.Location = new System.Drawing.Point(8, 184);
            this.PaymentPlanDescription_label.Name = "PaymentPlanDescription_label";
            this.PaymentPlanDescription_label.Size = new System.Drawing.Size(202, 74);
            this.PaymentPlanDescription_label.TabIndex = 12;
            this.PaymentPlanDescription_label.Text = "Payment Plan Description";
            this.PaymentPlanDescription_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PaymentPlanLength_label
            // 
            this.PaymentPlanLength_label.AutoSize = true;
            this.PaymentPlanLength_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPlanLength_label.ForeColor = System.Drawing.Color.LightGray;
            this.PaymentPlanLength_label.Location = new System.Drawing.Point(40, 112);
            this.PaymentPlanLength_label.Name = "PaymentPlanLength_label";
            this.PaymentPlanLength_label.Size = new System.Drawing.Size(33, 37);
            this.PaymentPlanLength_label.TabIndex = 11;
            this.PaymentPlanLength_label.Text = "0";
            this.PaymentPlanLength_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentPlanTitle_label
            // 
            this.PaymentPlanTitle_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentPlanTitle_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPlanTitle_label.ForeColor = System.Drawing.Color.LightGray;
            this.PaymentPlanTitle_label.Location = new System.Drawing.Point(11, 40);
            this.PaymentPlanTitle_label.Name = "PaymentPlanTitle_label";
            this.PaymentPlanTitle_label.Size = new System.Drawing.Size(205, 25);
            this.PaymentPlanTitle_label.TabIndex = 10;
            this.PaymentPlanTitle_label.Text = "Payment Plan Title";
            this.PaymentPlanTitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcPaymentPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.PaymentPlanBG_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcPaymentPlan";
            this.Size = new System.Drawing.Size(225, 310);
            this.Load += new System.EventHandler(this.UcPaymentPlan_Load);
            this.PaymentPlanBG_panel.ResumeLayout(false);
            this.PaymentPlanBG_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPayment_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentPlanBG_panel;
        private System.Windows.Forms.Label ExpectedPay_label;
        private System.Windows.Forms.PictureBox SelectPayment_picturebox;
        private System.Windows.Forms.Label PaymentPlanDescription_label;
        private System.Windows.Forms.Label PaymentPlanLength_label;
        private System.Windows.Forms.Label PaymentPlanTitle_label;
        private System.Windows.Forms.Label Months_label;
    }
}
