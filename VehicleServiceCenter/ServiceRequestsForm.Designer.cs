namespace VehicleServiceCenter
{
    partial class ServiceRequestsForm
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
            btnLogout = new Button();
            pnlLogoutDivider = new Panel();
            btnDashboard = new Button();
            btnBilling = new Button();
            btnRepairs = new Button();
            btnMechanics = new Button();
            btnServiceRequests = new Button();
            btnVehicles = new Button();
            btnCustomers = new Button();
            lblSidebarSubtitle = new Label();
            lblSidebarBrand = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtSearchRequest = new TextBox();
            btnAddRequest = new Button();
            dgvServiceRequests = new DataGridView();
            btnEditRequest = new Button();
            btnDeleteRequest = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceRequests).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkSlateGray;
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pnlLogoutDivider);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnBilling);
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
            pnlSidebar.TabIndex = 3;
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
            btnLogout.Location = new Point(15, 1702);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(210, 42);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlLogoutDivider
            // 
            pnlLogoutDivider.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLogoutDivider.BackColor = Color.Gainsboro;
            pnlLogoutDivider.Location = new Point(20, 1681);
            pnlLogoutDivider.Name = "pnlLogoutDivider";
            pnlLogoutDivider.Size = new Size(200, 1);
            pnlLogoutDivider.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkSlateGray;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(15, 130);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(210, 42);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
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
            btnBilling.Location = new Point(15, 490);
            btnBilling.Name = "btnBilling";
            btnBilling.Padding = new Padding(15, 0, 0, 0);
            btnBilling.Size = new Size(210, 42);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Billing";
            btnBilling.TextAlign = ContentAlignment.MiddleLeft;
            btnBilling.UseVisualStyleBackColor = true;
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
            btnRepairs.Location = new Point(15, 430);
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
            btnMechanics.Location = new Point(15, 370);
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
            btnServiceRequests.BackColor = Color.Teal;
            btnServiceRequests.Cursor = Cursors.Hand;
            btnServiceRequests.FlatAppearance.BorderSize = 0;
            btnServiceRequests.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnServiceRequests.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnServiceRequests.FlatStyle = FlatStyle.Flat;
            btnServiceRequests.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServiceRequests.ForeColor = Color.White;
            btnServiceRequests.Location = new Point(15, 310);
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
            btnVehicles.Location = new Point(15, 250);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Padding = new Padding(15, 0, 0, 0);
            btnVehicles.Size = new Size(210, 42);
            btnVehicles.TabIndex = 3;
            btnVehicles.Text = "Vehicles";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.DarkSlateGray;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(15, 190);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 0, 0, 0);
            btnCustomers.Size = new Size(210, 42);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
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
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(290, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 40);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Service Requests";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(290, 78);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 25);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Manage service requests";
            lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            lblSubtitle.Click += blSubtitle_Click;
            // 
            // txtSearchRequest
            // 
            txtSearchRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchRequest.Location = new Point(290, 125);
            txtSearchRequest.Multiline = true;
            txtSearchRequest.Name = "txtSearchRequest";
            txtSearchRequest.PlaceholderText = "Search by service type or status...";
            txtSearchRequest.Size = new Size(430, 32);
            txtSearchRequest.TabIndex = 6;
            txtSearchRequest.TextChanged += txtSearchRequest_TextChanged;
            // 
            // btnAddRequest
            // 
            btnAddRequest.BackColor = Color.Teal;
            btnAddRequest.Cursor = Cursors.Hand;
            btnAddRequest.FlatAppearance.BorderSize = 0;
            btnAddRequest.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAddRequest.FlatStyle = FlatStyle.Flat;
            btnAddRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRequest.ForeColor = Color.White;
            btnAddRequest.Location = new Point(800, 120);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(160, 40);
            btnAddRequest.TabIndex = 7;
            btnAddRequest.Text = "+ Add Request";
            btnAddRequest.UseVisualStyleBackColor = false;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // dgvServiceRequests
            // 
            dgvServiceRequests.AllowUserToAddRows = false;
            dgvServiceRequests.AllowUserToDeleteRows = false;
            dgvServiceRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceRequests.BackgroundColor = Color.White;
            dgvServiceRequests.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvServiceRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServiceRequests.ColumnHeadersHeight = 35;
            dgvServiceRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvServiceRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvServiceRequests.Location = new Point(275, 190);
            dgvServiceRequests.MultiSelect = false;
            dgvServiceRequests.Name = "dgvServiceRequests";
            dgvServiceRequests.ReadOnly = true;
            dgvServiceRequests.RowHeadersVisible = false;
            dgvServiceRequests.RowHeadersWidth = 51;
            dgvServiceRequests.RowTemplate.Height = 35;
            dgvServiceRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceRequests.Size = new Size(670, 385);
            dgvServiceRequests.TabIndex = 8;
            // 
            // btnEditRequest
            // 
            btnEditRequest.BackColor = Color.DarkSlateGray;
            btnEditRequest.Cursor = Cursors.Hand;
            btnEditRequest.FlatAppearance.BorderSize = 0;
            btnEditRequest.FlatStyle = FlatStyle.Flat;
            btnEditRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditRequest.ForeColor = Color.White;
            btnEditRequest.Location = new Point(380, 588);
            btnEditRequest.Name = "btnEditRequest";
            btnEditRequest.Size = new Size(130, 40);
            btnEditRequest.TabIndex = 12;
            btnEditRequest.Text = "EDIT";
            btnEditRequest.UseVisualStyleBackColor = false;
            btnEditRequest.Click += btnEditRequest_Click;
            // 
            // btnDeleteRequest
            // 
            btnDeleteRequest.BackColor = Color.IndianRed;
            btnDeleteRequest.Cursor = Cursors.Hand;
            btnDeleteRequest.FlatAppearance.BorderSize = 0;
            btnDeleteRequest.FlatStyle = FlatStyle.Flat;
            btnDeleteRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRequest.ForeColor = Color.White;
            btnDeleteRequest.Location = new Point(650, 588);
            btnDeleteRequest.Name = "btnDeleteRequest";
            btnDeleteRequest.Size = new Size(130, 40);
            btnDeleteRequest.TabIndex = 13;
            btnDeleteRequest.Text = "DELETE";
            btnDeleteRequest.UseVisualStyleBackColor = false;
            btnDeleteRequest.Click += btnDeleteRequest_Click;
            // 
            // ServiceRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnDeleteRequest);
            Controls.Add(btnEditRequest);
            Controls.Add(dgvServiceRequests);
            Controls.Add(btnAddRequest);
            Controls.Add(txtSearchRequest);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlSidebar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServiceRequestsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Requests";
            Load += ServiceRequestsForm_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServiceRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Panel pnlLogoutDivider;
        private Button btnDashboard;
        private Button btnBilling;
        private Button btnRepairs;
        private Button btnMechanics;
        private Button btnServiceRequests;
        private Button btnVehicles;
        private Button btnCustomers;
        private Label lblSidebarSubtitle;
        private Label lblSidebarBrand;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtSearchRequest;
        private Button btnAddRequest;
        private DataGridView dgvServiceRequests;
        private Button btnEditRequest;
        private Button btnDeleteRequest;
    }
}