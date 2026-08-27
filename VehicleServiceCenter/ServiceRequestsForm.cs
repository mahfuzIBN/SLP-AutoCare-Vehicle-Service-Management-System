using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleServiceCenter
{
    public partial class ServiceRequestsForm : Form
    {
        public ServiceRequestsForm()
        {
            InitializeComponent();
            LoadServiceRequests();
        }
        private void LoadServiceRequests()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();

                string query = @"
            SELECT
                sr.RequestID,
                sr.VehicleID,
                v.RegistrationNumber,
                sr.RequestDate,
                sr.ServiceType,
                sr.ProblemDescription,
                sr.Status
            FROM dbo.ServiceRequests sr
            INNER JOIN dbo.Vehicles v
                ON sr.VehicleID = v.VehicleID
            ORDER BY sr.RequestID DESC;";

                using var adapter =
                    new Microsoft.Data.SqlClient.SqlDataAdapter(query, connection);

                var table = new System.Data.DataTable();

                adapter.Fill(table);

                dgvServiceRequests.DataSource = table;

                dgvServiceRequests.Columns["RequestID"]!.HeaderText = "ID";
                dgvServiceRequests.Columns["RegistrationNumber"]!.HeaderText = "Reg. No.";
                dgvServiceRequests.Columns["RequestDate"]!.HeaderText = "Date";
                dgvServiceRequests.Columns["ServiceType"]!.HeaderText = "Service Type";
                dgvServiceRequests.Columns["ProblemDescription"]!.HeaderText = "Problem";
                dgvServiceRequests.Columns["Status"]!.HeaderText = "Status";

                dgvServiceRequests.Columns["VehicleID"]!.Visible = false;

                dgvServiceRequests.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load service requests.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void blSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void ServiceRequestsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            using var form = new ServiceRequestEditForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadServiceRequests();
            }

        }

        private void txtSearchRequest_TextChanged(object sender, EventArgs e)
        {
            if (dgvServiceRequests.DataSource is System.Data.DataTable table)
            {
                string search = txtSearchRequest.Text.Trim()
                    .Replace("'", "''");

                table.DefaultView.RowFilter =
                    $"ServiceType LIKE '%{search}%' " +
                    $"OR Status LIKE '%{search}%' " +
                    $"OR RegistrationNumber LIKE '%{search}%' " +
                    $"OR ProblemDescription LIKE '%{search}%'";
            }
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (dgvServiceRequests.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a service request first.",
                    "Edit Service Request",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row = dgvServiceRequests.CurrentRow;

            int id =
                Convert.ToInt32(row.Cells["RequestID"].Value);

            int vehicleId =
                Convert.ToInt32(row.Cells["VehicleID"].Value);

            DateTime requestDate =
                Convert.ToDateTime(row.Cells["RequestDate"].Value);

            string serviceType =
                row.Cells["ServiceType"].Value?.ToString() ?? "";

            string problem =
                row.Cells["ProblemDescription"].Value?.ToString() ?? "";

            string status =
                row.Cells["Status"].Value?.ToString() ?? "";

            using var form = new ServiceRequestEditForm(
                id,
                vehicleId,
                requestDate,
                serviceType,
                problem,
                status);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadServiceRequests();
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
           
                if (dgvServiceRequests.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Please select a service request first.",
                        "Delete Service Request",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int requestId =
                    Convert.ToInt32(
                        dgvServiceRequests.CurrentRow.Cells["RequestID"].Value);

                string serviceType =
                    dgvServiceRequests.CurrentRow.Cells["ServiceType"].Value?.ToString() ?? "";

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{serviceType}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                try
                {
                    using var connection = DatabaseConnection.GetConnection();
                    connection.Open();

                    string query = @"
            DELETE FROM dbo.ServiceRequests
            WHERE RequestID = @RequestID;";

                    using var command =
                        new Microsoft.Data.SqlClient.SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@RequestID", requestId);

                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Service request deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadServiceRequests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to delete service request.\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
