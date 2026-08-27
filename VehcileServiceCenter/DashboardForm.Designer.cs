namespace VehicleServiceCenter
{
    partial class DashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnBilling = new Button();
            btnSpareParts = new Button();
            btnRepairs = new Button();
            btnMechanics = new Button();
            btnServiceRequests = new Button();
            btnVehicles = new Button();
            btnCustomers = new Button();
            lblSidebarSubtitle = new Label();
            lblSidebarBrand = new Label();
            pnlDivider = new Panel();
            btnDashboard = new Button();
            pnlLogoutDivider = new Panel();
            btnLogout = new Button();
            lblDashboardTitle = new Label();
            lblDashboardSubtitle = new Label();
            pnlCustomersCard = new Panel();
            lblTotalCustomers = new Label();
            lblCustomersText = new Label();
            pnlVehiclesCard = new Panel();
            lblTotalVehicles = new Label();
            lblVehiclesText = new Label();
            pnlServiceRequestsCard = new Panel();
            lblTotalServiceRequests = new Label();
            lblServiceRequestsText = new Label();
            panel1 = new Panel();
            lblTotalRepairs = new Label();
            label2 = new Label();
            lblRecentRequestsTitle = new Label();
            dgvRecentRequests = new DataGridView();
            pnlSidebar.SuspendLayout();
            pnlCustomersCard.SuspendLayout();
            pnlVehiclesCard.SuspendLayout();
            pnlServiceRequestsCard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequests).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkSlateGray;
            pnlSidebar.Controls.Add(btnBilling);
            pnlSidebar.Controls.Add(btnSpareParts);
            pnlSidebar.Controls.Add(btnRepairs);
            pnlSidebar.Controls.Add(btnMechanics);
            pnlSidebar.Controls.Add(btnServiceRequests);
            pnlSidebar.Controls.Add(btnVehicles);
            pnlSidebar.Controls.Add(btnCustomers);
            pnlSidebar.Controls.Add(lblSidebarSubtitle);
            pnlSidebar.Controls.Add(lblSidebarBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 653);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnBilling
            // 
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnBilling.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(15, 485);
            btnBilling.Name = "btnBilling";
            btnBilling.Padding = new Padding(15, 0, 0, 0);
            btnBilling.Size = new Size(210, 42);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Billing";
            btnBilling.TextAlign = ContentAlignment.MiddleLeft;
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnSpareParts
            // 
            btnSpareParts.Cursor = Cursors.Hand;
            btnSpareParts.FlatAppearance.BorderSize = 0;
            btnSpareParts.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnSpareParts.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnSpareParts.FlatStyle = FlatStyle.Flat;
            btnSpareParts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSpareParts.ForeColor = Color.White;
            btnSpareParts.Location = new Point(15, 435);
            btnSpareParts.Name = "btnSpareParts";
            btnSpareParts.Padding = new Padding(15, 0, 0, 0);
            btnSpareParts.Size = new Size(210, 42);
            btnSpareParts.TabIndex = 3;
            btnSpareParts.Text = "Spare Parts";
            btnSpareParts.TextAlign = ContentAlignment.MiddleLeft;
            btnSpareParts.UseVisualStyleBackColor = true;
            btnSpareParts.Click += btnSpareParts_Click;
            // 
            // btnRepairs
            // 
            btnRepairs.Cursor = Cursors.Hand;
            btnRepairs.FlatAppearance.BorderSize = 0;
            btnRepairs.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnRepairs.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnRepairs.FlatStyle = FlatStyle.Flat;
            btnRepairs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRepairs.ForeColor = Color.White;
            btnRepairs.Location = new Point(15, 385);
            btnRepairs.Name = "btnRepairs";
            btnRepairs.Padding = new Padding(15, 0, 0, 0);
            btnRepairs.Size = new Size(210, 42);
            btnRepairs.TabIndex = 3;
            btnRepairs.Text = "Repairs";
            btnRepairs.TextAlign = ContentAlignment.MiddleLeft;
            btnRepairs.UseVisualStyleBackColor = true;
            // 
            // btnMechanics
            // 
            btnMechanics.Cursor = Cursors.Hand;
            btnMechanics.FlatAppearance.BorderSize = 0;
            btnMechanics.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnMechanics.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnMechanics.FlatStyle = FlatStyle.Flat;
            btnMechanics.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMechanics.ForeColor = Color.White;
            btnMechanics.Location = new Point(15, 335);
            btnMechanics.Name = "btnMechanics";
            btnMechanics.Padding = new Padding(15, 0, 0, 0);
            btnMechanics.Size = new Size(210, 42);
            btnMechanics.TabIndex = 3;
            btnMechanics.Text = "Mechanics";
            btnMechanics.TextAlign = ContentAlignment.MiddleLeft;
            btnMechanics.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequests
            // 
            btnServiceRequests.BackColor = Color.DarkSlateGray;
            btnServiceRequests.Cursor = Cursors.Hand;
            btnServiceRequests.FlatAppearance.BorderSize = 0;
            btnServiceRequests.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnServiceRequests.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnServiceRequests.FlatStyle = FlatStyle.Flat;
            btnServiceRequests.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServiceRequests.ForeColor = Color.White;
            btnServiceRequests.Location = new Point(15, 285);
            btnServiceRequests.Name = "btnServiceRequests";
            btnServiceRequests.Padding = new Padding(15, 0, 0, 0);
            btnServiceRequests.Size = new Size(210, 42);
            btnServiceRequests.TabIndex = 3;
            btnServiceRequests.Text = "Service Requests";
            btnServiceRequests.TextAlign = ContentAlignment.MiddleLeft;
            btnServiceRequests.UseVisualStyleBackColor = false;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.DarkSlateGray;
            btnVehicles.Cursor = Cursors.Hand;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnVehicles.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVehicles.ForeColor = Color.White;
            btnVehicles.Location = new Point(15, 235);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Padding = new Padding(15, 0, 0, 0);
            btnVehicles.Size = new Size(210, 42);
            btnVehicles.TabIndex = 3;
            btnVehicles.Text = "Vehicles";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(15, 185);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 0, 0, 0);
            btnCustomers.Size = new Size(210, 42);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // lblSidebarSubtitle
            // 
            lblSidebarSubtitle.BackColor = Color.Transparent;
            lblSidebarSubtitle.Font = new Font("Lucida Console", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSidebarSubtitle.ForeColor = Color.Gainsboro;
            lblSidebarSubtitle.Location = new Point(20, 72);
            lblSidebarSubtitle.Name = "lblSidebarSubtitle";
            lblSidebarSubtitle.Size = new Size(220, 30);
            lblSidebarSubtitle.TabIndex = 1;
            lblSidebarSubtitle.Text = "VEHICLE SERVICE MANAGEMENT";
            lblSidebarSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            lblSidebarSubtitle.Click += label1_Click;
            // 
            // lblSidebarBrand
            // 
            lblSidebarBrand.BackColor = Color.Transparent;
            lblSidebarBrand.Font = new Font("ROG Fonts STRIX SCAR", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSidebarBrand.ForeColor = Color.White;
            lblSidebarBrand.Location = new Point(20, 30);
            lblSidebarBrand.Name = "lblSidebarBrand";
            lblSidebarBrand.Size = new Size(200, 45);
            lblSidebarBrand.TabIndex = 1;
            lblSidebarBrand.Text = "SLP AUTOCARE";
            lblSidebarBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.Gainsboro;
            pnlDivider.Location = new Point(20, 110);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(200, 1);
            pnlDivider.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Teal;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(15, 135);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(210, 42);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlLogoutDivider
            // 
            pnlLogoutDivider.BackColor = Color.Gainsboro;
            pnlLogoutDivider.Location = new Point(20, 565);
            pnlLogoutDivider.Name = "pnlLogoutDivider";
            pnlLogoutDivider.Size = new Size(200, 1);
            pnlLogoutDivider.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.DarkSlateGray;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(15, 585);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(210, 42);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.BackColor = Color.Transparent;
            lblDashboardTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.DarkSlateGray;
            lblDashboardTitle.Location = new Point(285, 35);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(400, 45);
            lblDashboardTitle.TabIndex = 5;
            lblDashboardTitle.Text = "Dashboard";
            lblDashboardTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.BackColor = Color.Transparent;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.ForeColor = Color.DimGray;
            lblDashboardSubtitle.Location = new Point(291, 78);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(400, 25);
            lblDashboardSubtitle.TabIndex = 6;
            lblDashboardSubtitle.Text = "Overview of your service center";
            // 
            // pnlCustomersCard
            // 
            pnlCustomersCard.BackColor = Color.White;
            pnlCustomersCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomersCard.Controls.Add(lblTotalCustomers);
            pnlCustomersCard.Controls.Add(lblCustomersText);
            pnlCustomersCard.Location = new Point(290, 125);
            pnlCustomersCard.Name = "pnlCustomersCard";
            pnlCustomersCard.Size = new Size(200, 120);
            pnlCustomersCard.TabIndex = 7;
            pnlCustomersCard.Paint += pnlCustomersCard_Paint;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.BackColor = Color.Transparent;
            lblTotalCustomers.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.ForeColor = Color.DarkSlateGray;
            lblTotalCustomers.Location = new Point(20, 15);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(160, 45);
            lblTotalCustomers.TabIndex = 10;
            lblTotalCustomers.Text = "0";
            lblTotalCustomers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCustomersText
            // 
            lblCustomersText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomersText.ForeColor = Color.DimGray;
            lblCustomersText.Location = new Point(20, 75);
            lblCustomersText.Name = "lblCustomersText";
            lblCustomersText.Size = new Size(160, 25);
            lblCustomersText.TabIndex = 9;
            lblCustomersText.Text = "Total Customers";
            lblCustomersText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlVehiclesCard
            // 
            pnlVehiclesCard.BackColor = Color.White;
            pnlVehiclesCard.BorderStyle = BorderStyle.FixedSingle;
            pnlVehiclesCard.Controls.Add(lblTotalVehicles);
            pnlVehiclesCard.Controls.Add(lblVehiclesText);
            pnlVehiclesCard.Location = new Point(510, 125);
            pnlVehiclesCard.Name = "pnlVehiclesCard";
            pnlVehiclesCard.Size = new Size(200, 120);
            pnlVehiclesCard.TabIndex = 11;
            // 
            // lblTotalVehicles
            // 
            lblTotalVehicles.BackColor = Color.Transparent;
            lblTotalVehicles.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVehicles.ForeColor = Color.DarkSlateGray;
            lblTotalVehicles.Location = new Point(20, 15);
            lblTotalVehicles.Name = "lblTotalVehicles";
            lblTotalVehicles.Size = new Size(160, 45);
            lblTotalVehicles.TabIndex = 10;
            lblTotalVehicles.Text = "0";
            lblTotalVehicles.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVehiclesText
            // 
            lblVehiclesText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehiclesText.ForeColor = Color.DimGray;
            lblVehiclesText.Location = new Point(20, 75);
            lblVehiclesText.Name = "lblVehiclesText";
            lblVehiclesText.Size = new Size(160, 25);
            lblVehiclesText.TabIndex = 9;
            lblVehiclesText.Text = "Total Vehicles";
            lblVehiclesText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlServiceRequestsCard
            // 
            pnlServiceRequestsCard.BackColor = Color.White;
            pnlServiceRequestsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlServiceRequestsCard.Controls.Add(lblTotalServiceRequests);
            pnlServiceRequestsCard.Controls.Add(lblServiceRequestsText);
            pnlServiceRequestsCard.Location = new Point(730, 125);
            pnlServiceRequestsCard.Name = "pnlServiceRequestsCard";
            pnlServiceRequestsCard.Size = new Size(200, 120);
            pnlServiceRequestsCard.TabIndex = 12;
            // 
            // lblTotalServiceRequests
            // 
            lblTotalServiceRequests.BackColor = Color.Transparent;
            lblTotalServiceRequests.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalServiceRequests.ForeColor = Color.DarkSlateGray;
            lblTotalServiceRequests.Location = new Point(20, 15);
            lblTotalServiceRequests.Name = "lblTotalServiceRequests";
            lblTotalServiceRequests.Size = new Size(160, 45);
            lblTotalServiceRequests.TabIndex = 10;
            lblTotalServiceRequests.Text = "0";
            lblTotalServiceRequests.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblServiceRequestsText
            // 
            lblServiceRequestsText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServiceRequestsText.ForeColor = Color.DimGray;
            lblServiceRequestsText.Location = new Point(20, 75);
            lblServiceRequestsText.Name = "lblServiceRequestsText";
            lblServiceRequestsText.Size = new Size(160, 25);
            lblServiceRequestsText.TabIndex = 9;
            lblServiceRequestsText.Text = "Service Requests";
            lblServiceRequestsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalRepairs);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(950, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 120);
            panel1.TabIndex = 13;
            // 
            // lblTotalRepairs
            // 
            lblTotalRepairs.BackColor = Color.Transparent;
            lblTotalRepairs.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRepairs.ForeColor = Color.DarkSlateGray;
            lblTotalRepairs.Location = new Point(20, 15);
            lblTotalRepairs.Name = "lblTotalRepairs";
            lblTotalRepairs.Size = new Size(160, 45);
            lblTotalRepairs.TabIndex = 10;
            lblTotalRepairs.Text = "0";
            lblTotalRepairs.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 9;
            label2.Text = "Total Repairs";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecentRequestsTitle
            // 
            lblRecentRequestsTitle.BackColor = Color.Transparent;
            lblRecentRequestsTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRequestsTitle.ForeColor = Color.DarkSlateGray;
            lblRecentRequestsTitle.Location = new Point(290, 285);
            lblRecentRequestsTitle.Name = "lblRecentRequestsTitle";
            lblRecentRequestsTitle.Size = new Size(400, 35);
            lblRecentRequestsTitle.TabIndex = 14;
            lblRecentRequestsTitle.Text = "Recent Service Requests";
            lblRecentRequestsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvRecentRequests
            // 
            dgvRecentRequests.AllowUserToAddRows = false;
            dgvRecentRequests.AllowUserToDeleteRows = false;
            dgvRecentRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentRequests.BackgroundColor = Color.White;
            dgvRecentRequests.BorderStyle = BorderStyle.None;
            dgvRecentRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRecentRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentRequests.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentRequests.EnableHeadersVisualStyles = false;
            dgvRecentRequests.Location = new Point(290, 330);
            dgvRecentRequests.MultiSelect = false;
            dgvRecentRequests.Name = "dgvRecentRequests";
            dgvRecentRequests.ReadOnly = true;
            dgvRecentRequests.RowHeadersVisible = false;
            dgvRecentRequests.RowHeadersWidth = 51;
            dgvRecentRequests.RowTemplate.Height = 35;
            dgvRecentRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentRequests.Size = new Size(820, 250);
            dgvRecentRequests.TabIndex = 15;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 653);
            Controls.Add(dgvRecentRequests);
            Controls.Add(lblRecentRequestsTitle);
            Controls.Add(panel1);
            Controls.Add(pnlServiceRequestsCard);
            Controls.Add(pnlVehiclesCard);
            Controls.Add(pnlCustomersCard);
            Controls.Add(lblDashboardSubtitle);
            Controls.Add(lblDashboardTitle);
            Controls.Add(btnLogout);
            Controls.Add(pnlLogoutDivider);
            Controls.Add(btnDashboard);
            Controls.Add(pnlDivider);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SLP AutoCare - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlCustomersCard.ResumeLayout(false);
            pnlVehiclesCard.ResumeLayout(false);
            pnlServiceRequestsCard.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblSidebarBrand;
        private Label lblSidebarSubtitle;
        private Panel pnlDivider;
        private Button btnDashboard;
        private Button btnCustomers;
        private Button btnVehicles;
        private Button btnServiceRequests;
        private Button btnMechanics;
        private Button btnRepairs;
        private Button btnSpareParts;
        private Button btnBilling;
        private Panel pnlLogoutDivider;
        private Button btnLogout;
        private Label lblDashboardTitle;
        private Label lblDashboardSubtitle;
        private Panel pnlCustomersCard;
        private Label lblTotalCustomers;
        private Label lblCustomersText;
        private Panel pnlVehiclesCard;
        private Label lblTotalVehicles;
        private Label lblVehiclesText;
        private Panel pnlServiceRequestsCard;
        private Label lblTotalServiceRequests;
        private Label lblServiceRequestsText;
        private Panel panel1;
        private Label lblTotalRepairs;
        private Label label2;
        private Label lblRecentRequestsTitle;
        private DataGridView dgvRecentRequests;
    }
}