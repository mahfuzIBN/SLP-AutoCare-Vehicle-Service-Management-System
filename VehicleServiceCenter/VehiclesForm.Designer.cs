namespace VehicleServiceCenter
{
    partial class VehiclesForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            btnDeleteVehicle = new Button();
            btnEditVehicle = new Button();
            dgvVehicles = new DataGridView();
            btnAddVehicle = new Button();
            txtSearchVehicle = new TextBox();
            lblCustomersSubtitle = new Label();
            lblCustomersTitle = new Label();
            button1 = new Button();
            panel1 = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkSlateGray;
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(panel1);
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
            pnlSidebar.TabIndex = 2;
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
            btnLogout.Location = new Point(15, 1149);
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
            pnlLogoutDivider.Location = new Point(20, 1128);
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
            btnServiceRequests.BackColor = Color.DarkSlateGray;
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
            btnServiceRequests.Click += btnServiceRequests_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Teal;
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
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.BackColor = Color.IndianRed;
            btnDeleteVehicle.Cursor = Cursors.Hand;
            btnDeleteVehicle.FlatAppearance.BorderSize = 0;
            btnDeleteVehicle.FlatStyle = FlatStyle.Flat;
            btnDeleteVehicle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteVehicle.ForeColor = Color.White;
            btnDeleteVehicle.Location = new Point(652, 596);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(130, 40);
            btnDeleteVehicle.TabIndex = 19;
            btnDeleteVehicle.Text = "DELETE";
            btnDeleteVehicle.UseVisualStyleBackColor = false;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // btnEditVehicle
            // 
            btnEditVehicle.BackColor = Color.DarkSlateGray;
            btnEditVehicle.Cursor = Cursors.Hand;
            btnEditVehicle.FlatAppearance.BorderSize = 0;
            btnEditVehicle.FlatStyle = FlatStyle.Flat;
            btnEditVehicle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditVehicle.ForeColor = Color.White;
            btnEditVehicle.Location = new Point(388, 596);
            btnEditVehicle.Name = "btnEditVehicle";
            btnEditVehicle.Size = new Size(130, 40);
            btnEditVehicle.TabIndex = 18;
            btnEditVehicle.Text = "EDIT";
            btnEditVehicle.UseVisualStyleBackColor = false;
            btnEditVehicle.Click += btnEditVehicle_Click;
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AllowUserToDeleteRows = false;
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.BackgroundColor = Color.White;
            dgvVehicles.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVehicles.ColumnHeadersHeight = 35;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvVehicles.DefaultCellStyle = dataGridViewCellStyle4;
            dgvVehicles.Location = new Point(290, 180);
            dgvVehicles.MultiSelect = false;
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.RowHeadersVisible = false;
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.RowTemplate.Height = 35;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new Size(730, 390);
            dgvVehicles.TabIndex = 17;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.BackColor = Color.Teal;
            btnAddVehicle.Cursor = Cursors.Hand;
            btnAddVehicle.FlatAppearance.BorderSize = 0;
            btnAddVehicle.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAddVehicle.FlatStyle = FlatStyle.Flat;
            btnAddVehicle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddVehicle.ForeColor = Color.White;
            btnAddVehicle.Location = new Point(850, 116);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(170, 40);
            btnAddVehicle.TabIndex = 16;
            btnAddVehicle.Text = "+ Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = false;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // txtSearchVehicle
            // 
            txtSearchVehicle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchVehicle.Location = new Point(290, 120);
            txtSearchVehicle.Multiline = true;
            txtSearchVehicle.Name = "txtSearchVehicle";
            txtSearchVehicle.PlaceholderText = "Search by registration, brand or model...";
            txtSearchVehicle.Size = new Size(430, 32);
            txtSearchVehicle.TabIndex = 15;
            txtSearchVehicle.TextChanged += txtSearchVehicle_TextChanged;
            // 
            // lblCustomersSubtitle
            // 
            lblCustomersSubtitle.AutoSize = true;
            lblCustomersSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomersSubtitle.ForeColor = Color.DimGray;
            lblCustomersSubtitle.Location = new Point(284, 75);
            lblCustomersSubtitle.Name = "lblCustomersSubtitle";
            lblCustomersSubtitle.Size = new Size(223, 23);
            lblCustomersSubtitle.TabIndex = 14;
            lblCustomersSubtitle.Text = "Manage vehicle information";
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersTitle.ForeColor = Color.DarkSlateGray;
            lblCustomersTitle.Location = new Point(282, 35);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(163, 50);
            lblCustomersTitle.TabIndex = 13;
            lblCustomersTitle.Text = "Vehicles";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.DarkSlateGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button1.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(15, 579);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(210, 42);
            button1.TabIndex = 8;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(20, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 7;
            // 
            // VehiclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnDeleteVehicle);
            Controls.Add(btnEditVehicle);
            Controls.Add(dgvVehicles);
            Controls.Add(btnAddVehicle);
            Controls.Add(txtSearchVehicle);
            Controls.Add(lblCustomersSubtitle);
            Controls.Add(lblCustomersTitle);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VehiclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicles";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
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
        private Button btnDeleteVehicle;
        private Button btnEditVehicle;
        private DataGridView dgvVehicles;
        private Button btnAddVehicle;
        private TextBox txtSearchVehicle;
        private Label lblCustomersSubtitle;
        private Label lblCustomersTitle;
        private Button button1;
        private Panel panel1;
    }
}