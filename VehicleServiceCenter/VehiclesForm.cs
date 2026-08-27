using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleServiceCenter
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
            LoadVehicles();
        }
        private void LoadVehicles()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();

                string query = @"
        SELECT
    v.VehicleID,
    v.CustomerID,
    c.CustomerName,
    v.RegistrationNumber,
    v.Brand,
    v.Model,
    v.VehicleType,
    v.ManufacturingYear,
    v.ImagePath
            FROM dbo.Vehicles v
            INNER JOIN dbo.Customers c
                ON v.CustomerID = c.CustomerID
            ORDER BY v.VehicleID DESC;";

                using var adapter =
                    new Microsoft.Data.SqlClient.SqlDataAdapter(query, connection);

                var table = new System.Data.DataTable();

                adapter.Fill(table);

                dgvVehicles.DataSource = table;

                dgvVehicles.Columns["VehicleID"]!.HeaderText = "ID";
                dgvVehicles.Columns["CustomerName"]!.HeaderText = "Customer";
                dgvVehicles.Columns["RegistrationNumber"]!.HeaderText = "Reg. No.";
                dgvVehicles.Columns["Brand"]!.HeaderText = "Brand";
                dgvVehicles.Columns["Model"]!.HeaderText = "Model";
                dgvVehicles.Columns["VehicleType"]!.HeaderText = "Vehicle Type";
                dgvVehicles.Columns["ManufacturingYear"]!.HeaderText = "Year";
                dgvVehicles.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

                dgvVehicles.Columns["VehicleID"]!.FillWeight = 75;
                dgvVehicles.Columns["CustomerName"]!.FillWeight = 95;
                dgvVehicles.Columns["RegistrationNumber"]!.FillWeight = 120;
                dgvVehicles.Columns["Brand"]!.FillWeight = 80;
                dgvVehicles.Columns["Model"]!.FillWeight = 80;
                dgvVehicles.Columns["VehicleType"]!.FillWeight = 105;
                dgvVehicles.Columns["ManufacturingYear"]!.FillWeight = 60;
                dgvVehicles.Columns["CustomerID"]!.Visible = false;
                dgvVehicles.Columns["ImagePath"]!.Visible = false;

                dgvVehicles.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load vehicles.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            if (dgvVehicles.DataSource is System.Data.DataTable table)
            {
                string search = txtSearchVehicle.Text.Trim()
                    .Replace("'", "''");

                table.DefaultView.RowFilter =
                    $"RegistrationNumber LIKE '%{search}%' " +
                    $"OR Brand LIKE '%{search}%' " +
                    $"OR Model LIKE '%{search}%' " +
                    $"OR VehicleType LIKE '%{search}%' " +
                    $"OR CustomerName LIKE '%{search}%'";
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            using var form = new VehicleEditForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadVehicles();
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a vehicle first.",
                    "Edit Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row = dgvVehicles.CurrentRow;

            int id =
                Convert.ToInt32(row.Cells["VehicleID"].Value);

            int customerId =
                Convert.ToInt32(row.Cells["CustomerID"].Value);

            string registration =
                row.Cells["RegistrationNumber"].Value?.ToString() ?? "";

            string brand =
                row.Cells["Brand"].Value?.ToString() ?? "";

            string model =
                row.Cells["Model"].Value?.ToString() ?? "";

            string vehicleType =
                row.Cells["VehicleType"].Value?.ToString() ?? "";

            int year =
                Convert.ToInt32(row.Cells["ManufacturingYear"].Value);

            string imagePath =
                row.Cells["ImagePath"].Value == DBNull.Value
                    ? ""
                    : row.Cells["ImagePath"].Value?.ToString() ?? "";

            using var form = new VehicleEditForm(
                id,
                customerId,
                registration,
                brand,
                model,
                vehicleType,
                year,
                imagePath);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadVehicles();
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a vehicle first.",
                    "Delete Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int vehicleId =
                Convert.ToInt32(
                    dgvVehicles.CurrentRow.Cells["VehicleID"].Value);

            string registration =
                dgvVehicles.CurrentRow.Cells["RegistrationNumber"].Value?.ToString() ?? "";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete vehicle '{registration}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string checkQuery = @"
            SELECT COUNT(*)
            FROM dbo.ServiceRequests
            WHERE VehicleID = @VehicleID;";

                using var checkCommand =
                    new Microsoft.Data.SqlClient.SqlCommand(
                        checkQuery,
                        connection);

                checkCommand.Parameters.AddWithValue(
                    "@VehicleID",
                    vehicleId);

                int requestCount =
                    Convert.ToInt32(
                        checkCommand.ExecuteScalar());

                if (requestCount > 0)
                {
                    MessageBox.Show(
                        $"Cannot delete this vehicle because {requestCount} service request(s) are linked to it.",
                        "Delete Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string imagePath =
                    dgvVehicles.CurrentRow.Cells["ImagePath"].Value == DBNull.Value
                        ? ""
                        : dgvVehicles.CurrentRow.Cells["ImagePath"].Value?.ToString() ?? "";

                string deleteQuery = @"
            DELETE FROM dbo.Vehicles
            WHERE VehicleID = @VehicleID;";

                using var deleteCommand =
                    new Microsoft.Data.SqlClient.SqlCommand(
                        deleteQuery,
                        connection);

                deleteCommand.Parameters.AddWithValue(
                    "@VehicleID",
                    vehicleId);

                deleteCommand.ExecuteNonQuery();

                if (!string.IsNullOrWhiteSpace(imagePath) &&
                    System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    catch
                    {
                        // Vehicle is already deleted.
                        // Image cleanup failure should not block the operation.
                    }
                }

                MessageBox.Show(
                    "Vehicle deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete vehicle.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnServiceRequests_Click(object sender, EventArgs e)
        {

        }
    }
}
