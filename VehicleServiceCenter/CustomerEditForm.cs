using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace VehicleServiceCenter
{
    public partial class CustomerEditForm : Form
    {
        private int? customerId = null;
        public CustomerEditForm()
        {
            InitializeComponent();
        }
        public CustomerEditForm(
    int id,
    string name,
    string phone,
    string email,
    string address)
        {
            InitializeComponent();

            customerId = id;

            Text = "Edit Customer";
            lblTitle.Text = "Edit Customer";
            blSubtitle.Text = "Update customer information";
            btnSave.Text = "UPDATE";

            txtCustomerName.Text = name;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            txtAddress.Text = address;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();

            // Required-field validation
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Customer name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCustomerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show(
                    "Phone number is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }

            // Basic phone validation
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Phone number must contain only digits.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }

            // Basic email validation
            if (!string.IsNullOrWhiteSpace(email) &&
                (!email.Contains("@") || !email.Contains(".")))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string query;

                if (customerId == null)
                {
                    query = @"
        INSERT INTO dbo.Customers
            (CustomerName, Phone, Email, Address)
        VALUES
            (@CustomerName, @Phone, @Email, @Address);";
                }
                else
                {
                    query = @"
        UPDATE dbo.Customers
        SET CustomerName = @CustomerName,
            Phone = @Phone,
            Email = @Email,
            Address = @Address
        WHERE CustomerID = @CustomerID;";
                }
           
                using var command =
                    new Microsoft.Data.SqlClient.SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CustomerName", name);
                command.Parameters.AddWithValue("@Phone", phone);

                command.Parameters.AddWithValue(
                    "@Email",
                    string.IsNullOrWhiteSpace(email)
                        ? DBNull.Value
                        : email);

                command.Parameters.AddWithValue(
                    "@Address",
                    string.IsNullOrWhiteSpace(address)
                        ? DBNull.Value
                        : address);
                if (customerId != null)
                {
                    command.Parameters.AddWithValue(
                        "@CustomerID",
                        customerId.Value);
                }
                command.ExecuteNonQuery();

                MessageBox.Show(
     customerId == null
         ? "Customer added successfully."
         : "Customer updated successfully.",
     "Success",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save customer.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            
        }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
