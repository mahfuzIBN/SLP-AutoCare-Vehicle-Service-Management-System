namespace VehicleServiceCenter
{
    partial class CustomersForm
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
            lblCustomersTitle = new Label();
            lblCustomersSubtitle = new Label();
            txtSearchCustomer = new TextBox();
            btnAddCustomer = new Button();
            dgvCustomers = new DataGridView();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
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
            pnlSidebar.TabIndex = 1;
            pnlSidebar.Paint += pnlSidebar_Paint;
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
            btnLogout.Location = new Point(15, 579);
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
            pnlLogoutDivider.Location = new Point(20, 570);
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
            btnCustomers.BackColor = Color.Teal;
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
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersTitle.ForeColor = Color.DarkSlateGray;
            lblCustomersTitle.Location = new Point(290, 35);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(205, 50);
            lblCustomersTitle.TabIndex = 2;
            lblCustomersTitle.Text = "Customers";
            // 
            // lblCustomersSubtitle
            // 
            lblCustomersSubtitle.AutoSize = true;
            lblCustomersSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomersSubtitle.ForeColor = Color.DimGray;
            lblCustomersSubtitle.Location = new Point(292, 75);
            lblCustomersSubtitle.Name = "lblCustomersSubtitle";
            lblCustomersSubtitle.Size = new Size(242, 23);
            lblCustomersSubtitle.TabIndex = 3;
            lblCustomersSubtitle.Text = "Manage customer information";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchCustomer.Location = new Point(290, 120);
            txtSearchCustomer.Multiline = true;
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.PlaceholderText = "Search by name, phone or email...";
            txtSearchCustomer.Size = new Size(430, 32);
            txtSearchCustomer.TabIndex = 4;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.Teal;
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(850, 116);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(170, 40);
            btnAddCustomer.TabIndex = 5;
            btnAddCustomer.Text = "+ Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomers.ColumnHeadersHeight = 35;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.Location = new Point(290, 180);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 35;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(730, 390);
            dgvCustomers.TabIndex = 6;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.BackColor = Color.DarkSlateGray;
            btnEditCustomer.Cursor = Cursors.Hand;
            btnEditCustomer.FlatAppearance.BorderSize = 0;
            btnEditCustomer.FlatStyle = FlatStyle.Flat;
            btnEditCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCustomer.ForeColor = Color.White;
            btnEditCustomer.Location = new Point(388, 596);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(130, 40);
            btnEditCustomer.TabIndex = 11;
            btnEditCustomer.Text = "EDIT";
            btnEditCustomer.UseVisualStyleBackColor = false;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.IndianRed;
            btnDeleteCustomer.Cursor = Cursors.Hand;
            btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(652, 596);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(130, 40);
            btnDeleteCustomer.TabIndex = 12;
            btnDeleteCustomer.Text = "DELETE";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(dgvCustomers);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtSearchCustomer);
            Controls.Add(lblCustomersSubtitle);
            Controls.Add(lblCustomersTitle);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += CustomersForm_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnBilling;
        private Button btnRepairs;
        private Button btnMechanics;
        private Button btnServiceRequests;
        private Button btnVehicles;
        private Button btnCustomers;
        private Label lblSidebarSubtitle;
        private Label lblSidebarBrand;
        private Button btnDashboard;
        private Panel pnlLogoutDivider;
        private Button btnLogout;
        private Label lblCustomersTitle;
        private Label lblCustomersSubtitle;
        private TextBox txtSearchCustomer;
        private Button btnAddCustomer;
        private DataGridView dgvCustomers;
        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
    }
}