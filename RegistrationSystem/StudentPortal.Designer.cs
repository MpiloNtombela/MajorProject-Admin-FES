namespace RegistrationSystem
{
    partial class StudentPortal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPortal));
            this.StudentPortal_tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.RegisteredSubjectsContainer_panel = new System.Windows.Forms.Panel();
            this.MakePaymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisteredSubjects_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.payments_datagrid = new System.Windows.Forms.DataGridView();
            this.StudentProfileTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PaymentStatsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StatsRegNumPanel = new System.Windows.Forms.Panel();
            this.AmountDue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AmountPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AmountOwing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ApprovalDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NextPaymentDataPanel = new System.Windows.Forms.Panel();
            this.NextPaymentDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ApproveRegBtn = new System.Windows.Forms.Button();
            this.ReloadData = new System.Windows.Forms.PictureBox();
            this.RefreshToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Navbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutBtn = new System.Windows.Forms.PictureBox();
            this.AdminDetails = new System.Windows.Forms.Label();
            this.StudentPortal_tablelayout.SuspendLayout();
            this.RegisteredSubjectsContainer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payments_datagrid)).BeginInit();
            this.StudentProfileTableLayout.SuspendLayout();
            this.PaymentStatsPanel.SuspendLayout();
            this.StatsRegNumPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.NextPaymentDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadData)).BeginInit();
            this.Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPortal_tablelayout
            // 
            this.StudentPortal_tablelayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentPortal_tablelayout.ColumnCount = 2;
            this.StudentPortal_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.StudentPortal_tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.StudentPortal_tablelayout.Controls.Add(this.RegisteredSubjectsContainer_panel, 1, 0);
            this.StudentPortal_tablelayout.Controls.Add(this.StudentProfileTableLayout, 0, 0);
            this.StudentPortal_tablelayout.Location = new System.Drawing.Point(12, 48);
            this.StudentPortal_tablelayout.Name = "StudentPortal_tablelayout";
            this.StudentPortal_tablelayout.RowCount = 1;
            this.StudentPortal_tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentPortal_tablelayout.Size = new System.Drawing.Size(1115, 571);
            this.StudentPortal_tablelayout.TabIndex = 1;
            // 
            // RegisteredSubjectsContainer_panel
            // 
            this.RegisteredSubjectsContainer_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.MakePaymentButton);
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.label2);
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.RegisteredSubjects_flowlayout);
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.label3);
            this.RegisteredSubjectsContainer_panel.Controls.Add(this.payments_datagrid);
            this.RegisteredSubjectsContainer_panel.Location = new System.Drawing.Point(498, 3);
            this.RegisteredSubjectsContainer_panel.Name = "RegisteredSubjectsContainer_panel";
            this.RegisteredSubjectsContainer_panel.Size = new System.Drawing.Size(614, 565);
            this.RegisteredSubjectsContainer_panel.TabIndex = 4;
            // 
            // MakePaymentButton
            // 
            this.MakePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakePaymentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakePaymentButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.MakePaymentButton.Location = new System.Drawing.Point(431, 10);
            this.MakePaymentButton.Name = "MakePaymentButton";
            this.MakePaymentButton.Size = new System.Drawing.Size(136, 34);
            this.MakePaymentButton.TabIndex = 12;
            this.MakePaymentButton.Text = "MAKE PAYMENT";
            this.MakePaymentButton.UseVisualStyleBackColor = true;
            this.MakePaymentButton.Click += new System.EventHandler(this.MakePaymentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registered Subjects";
            // 
            // RegisteredSubjects_flowlayout
            // 
            this.RegisteredSubjects_flowlayout.AutoScroll = true;
            this.RegisteredSubjects_flowlayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.RegisteredSubjects_flowlayout.Location = new System.Drawing.Point(78, 270);
            this.RegisteredSubjects_flowlayout.Name = "RegisteredSubjects_flowlayout";
            this.RegisteredSubjects_flowlayout.Size = new System.Drawing.Size(489, 285);
            this.RegisteredSubjects_flowlayout.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(75, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payment Records";
            // 
            // payments_datagrid
            // 
            this.payments_datagrid.AllowUserToAddRows = false;
            this.payments_datagrid.AllowUserToDeleteRows = false;
            this.payments_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payments_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.payments_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payments_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.payments_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payments_datagrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.payments_datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.payments_datagrid.Location = new System.Drawing.Point(78, 50);
            this.payments_datagrid.MultiSelect = false;
            this.payments_datagrid.Name = "payments_datagrid";
            this.payments_datagrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payments_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.payments_datagrid.RowHeadersVisible = false;
            this.payments_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.payments_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payments_datagrid.ShowEditingIcon = false;
            this.payments_datagrid.Size = new System.Drawing.Size(489, 167);
            this.payments_datagrid.TabIndex = 5;
            // 
            // StudentProfileTableLayout
            // 
            this.StudentProfileTableLayout.ColumnCount = 2;
            this.StudentProfileTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentProfileTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.StudentProfileTableLayout.Controls.Add(this.PaymentStatsPanel, 1, 0);
            this.StudentProfileTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.StudentProfileTableLayout.Location = new System.Drawing.Point(3, 3);
            this.StudentProfileTableLayout.Name = "StudentProfileTableLayout";
            this.StudentProfileTableLayout.RowCount = 2;
            this.StudentProfileTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.72598F));
            this.StudentProfileTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.StudentProfileTableLayout.Size = new System.Drawing.Size(408, 562);
            this.StudentProfileTableLayout.TabIndex = 5;
            // 
            // PaymentStatsPanel
            // 
            this.PaymentStatsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentStatsPanel.Controls.Add(this.StatsRegNumPanel);
            this.PaymentStatsPanel.Controls.Add(this.panel2);
            this.PaymentStatsPanel.Controls.Add(this.panel3);
            this.PaymentStatsPanel.Location = new System.Drawing.Point(268, 3);
            this.PaymentStatsPanel.Name = "PaymentStatsPanel";
            this.PaymentStatsPanel.Size = new System.Drawing.Size(137, 352);
            this.PaymentStatsPanel.TabIndex = 12;
            this.PaymentStatsPanel.Visible = false;
            // 
            // StatsRegNumPanel
            // 
            this.StatsRegNumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.StatsRegNumPanel.Controls.Add(this.AmountDue);
            this.StatsRegNumPanel.Controls.Add(this.label5);
            this.StatsRegNumPanel.Location = new System.Drawing.Point(3, 3);
            this.StatsRegNumPanel.Name = "StatsRegNumPanel";
            this.StatsRegNumPanel.Size = new System.Drawing.Size(131, 111);
            this.StatsRegNumPanel.TabIndex = 0;
            // 
            // AmountDue
            // 
            this.AmountDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.AmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountDue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDue.ForeColor = System.Drawing.Color.Orange;
            this.AmountDue.Location = new System.Drawing.Point(3, 57);
            this.AmountDue.Multiline = true;
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.ReadOnly = true;
            this.AmountDue.Size = new System.Drawing.Size(125, 47);
            this.AmountDue.TabIndex = 2;
            this.AmountDue.Text = "0";
            this.AmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(22, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount Due";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.AmountPaid);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(3, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 111);
            this.panel2.TabIndex = 2;
            // 
            // AmountPaid
            // 
            this.AmountPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.AmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountPaid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaid.ForeColor = System.Drawing.Color.Orange;
            this.AmountPaid.Location = new System.Drawing.Point(3, 57);
            this.AmountPaid.Multiline = true;
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.Size = new System.Drawing.Size(125, 47);
            this.AmountPaid.TabIndex = 3;
            this.AmountPaid.Text = "0";
            this.AmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(20, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount Paid";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.AmountOwing);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 111);
            this.panel3.TabIndex = 3;
            // 
            // AmountOwing
            // 
            this.AmountOwing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.AmountOwing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountOwing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOwing.ForeColor = System.Drawing.Color.Orange;
            this.AmountOwing.Location = new System.Drawing.Point(3, 57);
            this.AmountOwing.Multiline = true;
            this.AmountOwing.Name = "AmountOwing";
            this.AmountOwing.ReadOnly = true;
            this.AmountOwing.Size = new System.Drawing.Size(125, 47);
            this.AmountOwing.TabIndex = 4;
            this.AmountOwing.Text = "0";
            this.AmountOwing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount Owing";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextPaymentDataPanel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.35294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.64706F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 170);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.ApprovalDate);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 82);
            this.panel4.TabIndex = 7;
            // 
            // ApprovalDate
            // 
            this.ApprovalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ApprovalDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApprovalDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalDate.ForeColor = System.Drawing.Color.DimGray;
            this.ApprovalDate.Location = new System.Drawing.Point(6, 40);
            this.ApprovalDate.Multiline = true;
            this.ApprovalDate.Name = "ApprovalDate";
            this.ApprovalDate.ReadOnly = true;
            this.ApprovalDate.Size = new System.Drawing.Size(243, 40);
            this.ApprovalDate.TabIndex = 4;
            this.ApprovalDate.Text = "--/--/----";
            this.ApprovalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(79, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Approval Date";
            // 
            // NextPaymentDataPanel
            // 
            this.NextPaymentDataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.NextPaymentDataPanel.Controls.Add(this.NextPaymentDate);
            this.NextPaymentDataPanel.Controls.Add(this.label6);
            this.NextPaymentDataPanel.Location = new System.Drawing.Point(3, 91);
            this.NextPaymentDataPanel.Name = "NextPaymentDataPanel";
            this.NextPaymentDataPanel.Size = new System.Drawing.Size(252, 76);
            this.NextPaymentDataPanel.TabIndex = 6;
            // 
            // NextPaymentDate
            // 
            this.NextPaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.NextPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NextPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPaymentDate.ForeColor = System.Drawing.Color.DimGray;
            this.NextPaymentDate.Location = new System.Drawing.Point(6, 40);
            this.NextPaymentDate.Multiline = true;
            this.NextPaymentDate.Name = "NextPaymentDate";
            this.NextPaymentDate.ReadOnly = true;
            this.NextPaymentDate.Size = new System.Drawing.Size(243, 40);
            this.NextPaymentDate.TabIndex = 4;
            this.NextPaymentDate.Text = "--/--/----";
            this.NextPaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(66, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Next Payment Date";
            // 
            // ApproveRegBtn
            // 
            this.ApproveRegBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ApproveRegBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ApproveRegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApproveRegBtn.FlatAppearance.BorderSize = 0;
            this.ApproveRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveRegBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveRegBtn.ForeColor = System.Drawing.Color.White;
            this.ApproveRegBtn.Location = new System.Drawing.Point(899, 628);
            this.ApproveRegBtn.Name = "ApproveRegBtn";
            this.ApproveRegBtn.Size = new System.Drawing.Size(178, 34);
            this.ApproveRegBtn.TabIndex = 13;
            this.ApproveRegBtn.Text = "APPROVE REGISTRATION";
            this.ApproveRegBtn.UseVisualStyleBackColor = false;
            this.ApproveRegBtn.Click += new System.EventHandler(this.ApproveRegBtn_Click);
            // 
            // ReloadData
            // 
            this.ReloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadData.Image = global::RegistrationSystem.Properties.Resources.favicon_32x32;
            this.ReloadData.Location = new System.Drawing.Point(1084, 628);
            this.ReloadData.Name = "ReloadData";
            this.ReloadData.Size = new System.Drawing.Size(43, 36);
            this.ReloadData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ReloadData.TabIndex = 14;
            this.ReloadData.TabStop = false;
            this.RefreshToolTip.SetToolTip(this.ReloadData, "Refresh Student Portal");
            this.ReloadData.Click += new System.EventHandler(this.ReloadData_Click);
            // 
            // RefreshToolTip
            // 
            this.RefreshToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.RefreshToolTip.ToolTipTitle = "Refresh Page";
            // 
            // Navbar
            // 
            this.Navbar.Controls.Add(this.label1);
            this.Navbar.Controls.Add(this.pictureBox1);
            this.Navbar.Controls.Add(this.LogoutBtn);
            this.Navbar.Controls.Add(this.AdminDetails);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1139, 42);
            this.Navbar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "STUDENT PORTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::RegistrationSystem.Properties.Resources.favicon_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Image = global::RegistrationSystem.Properties.Resources.power;
            this.LogoutBtn.Location = new System.Drawing.Point(1093, 3);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(36, 36);
            this.LogoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.TabStop = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AdminDetails
            // 
            this.AdminDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminDetails.AutoEllipsis = true;
            this.AdminDetails.AutoSize = true;
            this.AdminDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDetails.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AdminDetails.Location = new System.Drawing.Point(836, 12);
            this.AdminDetails.Name = "AdminDetails";
            this.AdminDetails.Size = new System.Drawing.Size(112, 20);
            this.AdminDetails.TabIndex = 0;
            this.AdminDetails.Text = "Admin Details";
            this.AdminDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1139, 674);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.ReloadData);
            this.Controls.Add(this.ApproveRegBtn);
            this.Controls.Add(this.StudentPortal_tablelayout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentPortal_Load);
            this.StudentPortal_tablelayout.ResumeLayout(false);
            this.RegisteredSubjectsContainer_panel.ResumeLayout(false);
            this.RegisteredSubjectsContainer_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payments_datagrid)).EndInit();
            this.StudentProfileTableLayout.ResumeLayout(false);
            this.PaymentStatsPanel.ResumeLayout(false);
            this.StatsRegNumPanel.ResumeLayout(false);
            this.StatsRegNumPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.NextPaymentDataPanel.ResumeLayout(false);
            this.NextPaymentDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadData)).EndInit();
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel StudentPortal_tablelayout;
        private System.Windows.Forms.Panel RegisteredSubjectsContainer_panel;
        private System.Windows.Forms.DataGridView payments_datagrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel StudentProfileTableLayout;
        private System.Windows.Forms.FlowLayoutPanel PaymentStatsPanel;
        private System.Windows.Forms.Panel StatsRegNumPanel;
        private System.Windows.Forms.TextBox AmountDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AmountPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AmountOwing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ApprovalDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel NextPaymentDataPanel;
        private System.Windows.Forms.TextBox NextPaymentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MakePaymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel RegisteredSubjects_flowlayout;
        private System.Windows.Forms.Button ApproveRegBtn;
        private System.Windows.Forms.PictureBox ReloadData;
        private System.Windows.Forms.ToolTip RefreshToolTip;
        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LogoutBtn;
        private System.Windows.Forms.Label AdminDetails;
    }
}