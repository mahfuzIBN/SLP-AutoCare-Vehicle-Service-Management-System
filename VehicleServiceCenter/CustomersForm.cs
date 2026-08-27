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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();

                string query = @"
            SELECT
                CustomerID,
                CustomerName,
                Phone,
                Email,
                Address
            FROM dbo.Customers
            ORDER BY CustomerID DESC;";

                using var adapter =
                    new Microsoft.Data.SqlClient.SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvCustomers.DataSource = table;

                dgvCustomers.Columns["CustomerID"]!.HeaderText = "Customer ID";
                dgvCustomers.Columns["CustomerName"]!.HeaderText = "Customer Name";
                dgvCustomers.Columns["Phone"]!.HeaderText = "Phone";
                dgvCustomers.Columns["Email"]!.HeaderText = "Email";
                dgvCustomers.Columns["Address"]!.HeaderText = "Address";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load customers.\n" + ex.Message,
                    "Customers Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.DataSource is DataTable table)
            {
                string search = txtSearchCustomer.Text.Trim()
                    .Replace("'", "''");

                table.DefaultView.RowFilter =
                    $"CustomerName LIKE '%{search}%' " +
                    $"OR Phone LIKE '%{search}%' " +
                    $"OR Email LIKE '%{search}%' " +
                    $"OR Address LIKE '%{search}%'";
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using var form = new CustomerEditForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a customer first.",
                    "Edit Customer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            DataGridViewRow row = dgvCustomers.CurrentRow;

            int id = Convert.ToInt32(row.Cells["CustomerID"].Value);

            string name = row.Cells["CustomerName"].Value?.ToString() ?? "";
            string phone = row.Cells["Phone"].Value?.ToString() ?? "";
            string email = row.Cells["Email"].Value?.ToString() ?? "";
            string address = row.Cells["Address"].Value?.ToString() ?? "";
            using var form =
    new CustomerEditForm(id, name, phone, email, address);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a customer first.",
                    "Delete Customer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int customerId =
                Convert.ToInt32(
                    dgvCustomers.CurrentRow.Cells["CustomerID"].Value);

            string customerName =
                dgvCustomers.CurrentRow.Cells["CustomerName"].Value?.ToString() ?? "";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{customerName}'?",
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
    FROM dbo.Vehicles
    WHERE CustomerID = @CustomerID;";

                using var checkCommand =
                    new Microsoft.Data.SqlClient.SqlCommand(checkQuery, connection);

                checkCommand.Parameters.AddWithValue("@CustomerID", customerId);

                int vehicleCount =
                    Convert.ToInt32(checkCommand.ExecuteScalar());

                if (vehicleCount > 0)
                {
                    MessageBox.Show(
                        $"Cannot delete this customer because {vehicleCount} vehicle(s) are registered under this customer.",
                        "Delete Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                string query = @"
    DELETE FROM dbo.Customers
    WHERE CustomerID = @CustomerID;";

                using var command =
                    new Microsoft.Data.SqlClient.SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CustomerID", customerId);

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Customer deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete customer.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

