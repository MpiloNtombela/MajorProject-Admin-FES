namespace RegistrationSystem.UserControls
{
    partial class UcSubject
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
            this.bg_panel = new System.Windows.Forms.Panel();
            this.MatricMarkContainer_panel = new System.Windows.Forms.Panel();
            this.MatricMark_label = new System.Windows.Forms.Label();
            this.MatricMark_textbox = new System.Windows.Forms.TextBox();
            this.Percent_label = new System.Windows.Forms.Label();
            this.R_label = new System.Windows.Forms.Label();
            this.SelectSubject_picturebox = new System.Windows.Forms.PictureBox();
            this.SubjectCode_label = new System.Windows.Forms.Label();
            this.SubjectPrice_label = new System.Windows.Forms.Label();
            this.SubjectDescription_label = new System.Windows.Forms.Label();
            this.SubjectName_label = new System.Windows.Forms.Label();
            this.bg_panel.SuspendLayout();
            this.MatricMarkContainer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSubject_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_panel
            // 
            this.bg_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.bg_panel.Controls.Add(this.MatricMarkContainer_panel);
            this.bg_panel.Controls.Add(this.R_label);
            this.bg_panel.Controls.Add(this.SelectSubject_picturebox);
            this.bg_panel.Controls.Add(this.SubjectCode_label);
            this.bg_panel.Controls.Add(this.SubjectPrice_label);
            this.bg_panel.Controls.Add(this.SubjectDescription_label);
            this.bg_panel.Controls.Add(this.SubjectName_label);
            this.bg_panel.Location = new System.Drawing.Point(3, 3);
            this.bg_panel.Name = "bg_panel";
            this.bg_panel.Size = new System.Drawing.Size(392, 110);
            this.bg_panel.TabIndex = 1;
            this.bg_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bg_panel_Paint);
            // 
            // MatricMarkContainer_panel
            // 
            this.MatricMarkContainer_panel.Controls.Add(this.MatricMark_label);
            this.MatricMarkContainer_panel.Controls.Add(this.MatricMark_textbox);
            this.MatricMarkContainer_panel.Controls.Add(this.Percent_label);
            this.MatricMarkContainer_panel.Location = new System.Drawing.Point(305, 69);
            this.MatricMarkContainer_panel.Name = "MatricMarkContainer_panel";
            this.MatricMarkContainer_panel.Size = new System.Drawing.Size(83, 38);
            this.MatricMarkContainer_panel.TabIndex = 13;
            // 
            // MatricMark_label
            // 
            this.MatricMark_label.AutoSize = true;
            this.MatricMark_label.ForeColor = System.Drawing.Color.DimGray;
            this.MatricMark_label.Location = new System.Drawing.Point(8, 2);
            this.MatricMark_label.Name = "MatricMark_label";
            this.MatricMark_label.Size = new System.Drawing.Size(68, 13);
            this.MatricMark_label.TabIndex = 14;
            this.MatricMark_label.Text = "Matric Mark";
            // 
            // MatricMark_textbox
            // 
            this.MatricMark_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.MatricMark_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatricMark_textbox.Location = new System.Drawing.Point(4, 16);
            this.MatricMark_textbox.MaxLength = 3;
            this.MatricMark_textbox.Multiline = true;
            this.MatricMark_textbox.Name = "MatricMark_textbox";
            this.MatricMark_textbox.Size = new System.Drawing.Size(51, 19);
            this.MatricMark_textbox.TabIndex = 11;
            this.MatricMark_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatricMark_textbox.TextChanged += new System.EventHandler(this.MatricMark_textbox_TextChanged);
            this.MatricMark_textbox.Leave += new System.EventHandler(this.MatricMark_textbox_Leave);
            // 
            // Percent_label
            // 
            this.Percent_label.AutoSize = true;
            this.Percent_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent_label.Location = new System.Drawing.Point(61, 18);
            this.Percent_label.Name = "Percent_label";
            this.Percent_label.Size = new System.Drawing.Size(19, 17);
            this.Percent_label.TabIndex = 12;
            this.Percent_label.Text = "%";
            // 
            // R_label
            // 
            this.R_label.AutoSize = true;
            this.R_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_label.ForeColor = System.Drawing.Color.LightGray;
            this.R_label.Location = new System.Drawing.Point(90, 85);
            this.R_label.Name = "R_label";
            this.R_label.Size = new System.Drawing.Size(16, 17);
            this.R_label.TabIndex = 10;
            this.R_label.Text = "R";
            // 
            // SelectSubject_picturebox
            // 
            this.SelectSubject_picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSubject_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectSubject_picturebox.Image = global::RegistrationSystem.Properties.Resources.check_icon;
            this.SelectSubject_picturebox.Location = new System.Drawing.Point(364, 4);
            this.SelectSubject_picturebox.Name = "SelectSubject_picturebox";
            this.SelectSubject_picturebox.Size = new System.Drawing.Size(24, 25);
            this.SelectSubject_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectSubject_picturebox.TabIndex = 9;
            this.SelectSubject_picturebox.TabStop = false;
            this.SelectSubject_picturebox.Click += new System.EventHandler(this.SelectSubject_picturebox_Click);
            // 
            // SubjectCode_label
            // 
            this.SubjectCode_label.BackColor = System.Drawing.Color.DarkOrange;
            this.SubjectCode_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCode_label.ForeColor = System.Drawing.Color.White;
            this.SubjectCode_label.Location = new System.Drawing.Point(3, 3);
            this.SubjectCode_label.Name = "SubjectCode_label";
            this.SubjectCode_label.Size = new System.Drawing.Size(81, 103);
            this.SubjectCode_label.TabIndex = 8;
            this.SubjectCode_label.Text = "SCODE";
            this.SubjectCode_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectPrice_label
            // 
            this.SubjectPrice_label.AutoSize = true;
            this.SubjectPrice_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectPrice_label.ForeColor = System.Drawing.Color.LightGray;
            this.SubjectPrice_label.Location = new System.Drawing.Point(112, 86);
            this.SubjectPrice_label.Name = "SubjectPrice_label";
            this.SubjectPrice_label.Size = new System.Drawing.Size(47, 17);
            this.SubjectPrice_label.TabIndex = 7;
            this.SubjectPrice_label.Text = "000.00";
            // 
            // SubjectDescription_label
            // 
            this.SubjectDescription_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectDescription_label.ForeColor = System.Drawing.Color.DimGray;
            this.SubjectDescription_label.Location = new System.Drawing.Point(90, 32);
            this.SubjectDescription_label.Name = "SubjectDescription_label";
            this.SubjectDescription_label.Size = new System.Drawing.Size(299, 34);
            this.SubjectDescription_label.TabIndex = 6;
            this.SubjectDescription_label.Text = "Subject Description here...";
            // 
            // SubjectName_label
            // 
            this.SubjectName_label.AutoSize = true;
            this.SubjectName_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName_label.ForeColor = System.Drawing.Color.LightGray;
            this.SubjectName_label.Location = new System.Drawing.Point(85, 4);
            this.SubjectName_label.Name = "SubjectName_label";
            this.SubjectName_label.Size = new System.Drawing.Size(135, 25);
            this.SubjectName_label.TabIndex = 5;
            this.SubjectName_label.Text = "Subject Name";
            // 
            // UcSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bg_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcSubject";
            this.Size = new System.Drawing.Size(398, 116);
            this.Load += new System.EventHandler(this.ucSubject_Load);
            this.bg_panel.ResumeLayout(false);
            this.bg_panel.PerformLayout();
            this.MatricMarkContainer_panel.ResumeLayout(false);
            this.MatricMarkContainer_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSubject_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg_panel;
        private System.Windows.Forms.PictureBox SelectSubject_picturebox;
        private System.Windows.Forms.Label SubjectCode_label;
        private System.Windows.Forms.Label SubjectPrice_label;
        private System.Windows.Forms.Label SubjectDescription_label;
        private System.Windows.Forms.Label SubjectName_label;
        private System.Windows.Forms.Label R_label;
        private System.Windows.Forms.Panel MatricMarkContainer_panel;
        private System.Windows.Forms.TextBox MatricMark_textbox;
        private System.Windows.Forms.Label Percent_label;
        private System.Windows.Forms.Label MatricMark_label;
    }
}
