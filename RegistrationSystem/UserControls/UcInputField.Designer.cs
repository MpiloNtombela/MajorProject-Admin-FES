namespace RegistrationSystem.UserControls
{
    partial class UcInputField
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
            this.components = new System.ComponentModel.Container();
            this.InputField_textbox = new System.Windows.Forms.TextBox();
            this.InputFieldBorder_panel = new System.Windows.Forms.Panel();
            this.InputLabel_label = new System.Windows.Forms.Label();
            this.InvalidInput_picturebox = new System.Windows.Forms.PictureBox();
            this.InvalidInput_tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InvalidInput_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputField_textbox
            // 
            this.InputField_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputField_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.InputField_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputField_textbox.ForeColor = System.Drawing.Color.White;
            this.InputField_textbox.Location = new System.Drawing.Point(6, 20);
            this.InputField_textbox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.InputField_textbox.MaxLength = 0;
            this.InputField_textbox.Multiline = true;
            this.InputField_textbox.Name = "InputField_textbox";
            this.InputField_textbox.Size = new System.Drawing.Size(240, 37);
            this.InputField_textbox.TabIndex = 0;
            this.InputField_textbox.TextChanged += new System.EventHandler(this.InputField_textbox_TextChanged);
            this.InputField_textbox.Enter += new System.EventHandler(this.InputField_textbox_Enter);
            this.InputField_textbox.Leave += new System.EventHandler(this.InputField_textbox_Leave);
            // 
            // InputFieldBorder_panel
            // 
            this.InputFieldBorder_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFieldBorder_panel.BackColor = System.Drawing.Color.DarkGray;
            this.InputFieldBorder_panel.Location = new System.Drawing.Point(6, 50);
            this.InputFieldBorder_panel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.InputFieldBorder_panel.Name = "InputFieldBorder_panel";
            this.InputFieldBorder_panel.Size = new System.Drawing.Size(240, 10);
            this.InputFieldBorder_panel.TabIndex = 1;
            // 
            // InputLabel_label
            // 
            this.InputLabel_label.AutoSize = true;
            this.InputLabel_label.BackColor = System.Drawing.Color.Transparent;
            this.InputLabel_label.ForeColor = System.Drawing.Color.White;
            this.InputLabel_label.Location = new System.Drawing.Point(3, 0);
            this.InputLabel_label.Name = "InputLabel_label";
            this.InputLabel_label.Size = new System.Drawing.Size(72, 17);
            this.InputLabel_label.TabIndex = 2;
            this.InputLabel_label.Text = "Input Label";
            // 
            // InvalidInput_picturebox
            // 
            this.InvalidInput_picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvalidInput_picturebox.Location = new System.Drawing.Point(230, 31);
            this.InvalidInput_picturebox.Name = "InvalidInput_picturebox";
            this.InvalidInput_picturebox.Size = new System.Drawing.Size(16, 17);
            this.InvalidInput_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InvalidInput_picturebox.TabIndex = 3;
            this.InvalidInput_picturebox.TabStop = false;
            this.InvalidInput_tooltip.SetToolTip(this.InvalidInput_picturebox, "Mpilo");
            this.InvalidInput_picturebox.Visible = false;
            // 
            // UcInputField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.InvalidInput_picturebox);
            this.Controls.Add(this.InputField_textbox);
            this.Controls.Add(this.InputLabel_label);
            this.Controls.Add(this.InputFieldBorder_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcInputField";
            this.Size = new System.Drawing.Size(254, 69);
            this.Load += new System.EventHandler(this.ucInputField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvalidInput_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputField_textbox;
        private System.Windows.Forms.Panel InputFieldBorder_panel;
        private System.Windows.Forms.Label InputLabel_label;
        private System.Windows.Forms.PictureBox InvalidInput_picturebox;
        private System.Windows.Forms.ToolTip InvalidInput_tooltip;
    }
}
