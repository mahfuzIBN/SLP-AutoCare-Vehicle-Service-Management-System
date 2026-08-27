using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehicleServiceCenter;

namespace VehicleServiceCenter
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
            LoadRecentRequests();
        }
        private void LoadDashboardData()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                lblTotalCustomers.Text =
                    GetCount(connection, "Customers").ToString();

                lblTotalVehicles.Text =
                    GetCount(connection, "Vehicles").ToString();

                lblTotalServiceRequests.Text =
                    GetCount(connection, "ServiceRequests").ToString();

                lblTotalRepairs.Text =
                    GetCount(connection, "Repairs").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data.\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadRecentRequests()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();

                string query = @"
SELECT TOP 10 *
FROM dbo.ServiceRequests
ORDER BY RequestDate DESC, RequestID DESC;";
                using var adapter =
                    new Microsoft.Data.SqlClient.SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvRecentRequests.DataSource = table;


                dgvRecentRequests.Columns["RequestID"]!.HeaderText = "Request ID";
                dgvRecentRequests.Columns["VehicleID"]!.HeaderText = "Vehicle ID";
                dgvRecentRequests.Columns["RequestDate"]!.HeaderText = "Request Date";
                dgvRecentRequests.Columns["ServiceType"]!.HeaderText = "Service Type";
                dgvRecentRequests.Columns["ProblemDescription"]!.HeaderText = "Problem Description";
                dgvRecentRequests.Columns["Status"]!.HeaderText = "Status";

                dgvRecentRequests.Columns["RequestID"]!.FillWeight = 95;
                dgvRecentRequests.Columns["VehicleID"]!.FillWeight = 95;
                dgvRecentRequests.Columns["RequestDate"]!.FillWeight = 115;
                dgvRecentRequests.Columns["ServiceType"]!.FillWeight = 115;
                dgvRecentRequests.Columns["ProblemDescription"]!.FillWeight = 200;
                dgvRecentRequests.Columns["Status"]!.FillWeight = 90;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load recent service requests.\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private int GetCount(
            Microsoft.Data.SqlClient.SqlConnection connection,
            string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";

            using var command =
                new Microsoft.Data.SqlClient.SqlCommand(query, connection);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCustomersCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            this.Hide();
            customersForm.ShowDialog();
            this.Show();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            using var form = new VehiclesForm();
            form.ShowDialog(this);
        }

        private void btnSpareParts_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceRequests_Click(object sender, EventArgs e)
        {
            using var form = new ServiceRequestsForm();
            form.ShowDialog(this);
        }
    }
}
