using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleServiceCenter
{
    public partial class VehicleEditForm : Form
    {
        private string selectedImagePath = "";
        private string existingImagePath = "";
        private int? vehicleId = null;
        public VehicleEditForm()


        {
            InitializeComponent();

            LoadCustomers();
            cmbVehicleType.Items.AddRange(new string[]
{
    "Sedan",
    "SUV",
    "Hatchback",
    "Pickup",
    "Microbus",
    "Van",
    "Coupe",
    "Other"
});

            cmbVehicleType.SelectedIndex = -1;
        }
        public VehicleEditForm(
    int id,
    int customerId,
    string registration,
    string brand,
    string model,
    string vehicleType,
    int manufacturingYear,
    string imagePath)
    : this()
        {
            vehicleId = id;
            existingImagePath = imagePath ?? "";

            Text = "Edit Vehicle";
            lblTitle.Text = "Edit Vehicle";
            blSubtitle.Text = "Update vehicle information";
            btnSave.Text = "UPDATE";

            cmbCustomer.SelectedValue = customerId;
            txtRegistrationNumber.Text = registration;
            txtBrand.Text = brand;
            txtModel.Text = model;
            cmbVehicleType.SelectedItem = vehicleType;
            nudManufacturingYear.Value = manufacturingYear;

            if (!string.IsNullOrWhiteSpace(existingImagePath) &&
                System.IO.File.Exists(existingImagePath))
            {
                using var tempImage =
                    Image.FromFile(existingImagePath);

                picVehicle.Image =
                    new Bitmap(tempImage);
            }
        }
        private void LoadCustomers()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();

                string query = @"
            SELECT CustomerID, CustomerName
            FROM dbo.Customers
            ORDER BY CustomerName;";

                using var adapter =
                    new Microsoft.Data.SqlClient.SqlDataAdapter(query, connection);

                var table = new System.Data.DataTable();

                adapter.Fill(table);

                cmbCustomer.DataSource = table;
                cmbCustomer.DisplayMember = "CustomerName";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load customers.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void lblManufacturingYear_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Select Vehicle Image";
            dialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;

                using var tempImage = Image.FromFile(selectedImagePath);

                picVehicle.Image?.Dispose();
                picVehicle.Image = new Bitmap(tempImage);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a customer.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCustomer.Focus();
                return;
            }

            string registration = txtRegistrationNumber.Text.Trim();
            string brand = txtBrand.Text.Trim();
            string model = txtModel.Text.Trim();

            if (string.IsNullOrWhiteSpace(registration))
            {
                MessageBox.Show(
                    "Registration number is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRegistrationNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show(
                    "Brand is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBrand.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show(
                    "Model is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtModel.Focus();
                return;
            }

            if (cmbVehicleType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a vehicle type.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbVehicleType.Focus();
                return;
            }

            try
            {
                int customerId =
                    Convert.ToInt32(cmbCustomer.SelectedValue);

                string vehicleType =
                    cmbVehicleType.SelectedItem!.ToString()!;

                int year =
                    Convert.ToInt32(nudManufacturingYear.Value);

                using var connection =
                    DatabaseConnection.GetConnection();

                connection.Open();

                // Check duplicate registration number
                string checkQuery;

                if (vehicleId == null)
                {
                    checkQuery = @"
                SELECT COUNT(*)
                FROM dbo.Vehicles
                WHERE RegistrationNumber = @RegistrationNumber;";
                }
                else
                {
                    checkQuery = @"
                SELECT COUNT(*)
                FROM dbo.Vehicles
                WHERE RegistrationNumber = @RegistrationNumber
                AND VehicleID <> @VehicleID;";
                }

                using var checkCommand =
                    new Microsoft.Data.SqlClient.SqlCommand(
                        checkQuery,
                        connection);

                checkCommand.Parameters.AddWithValue(
                    "@RegistrationNumber",
                    registration);

                if (vehicleId != null)
                {
                    checkCommand.Parameters.AddWithValue(
                        "@VehicleID",
                        vehicleId.Value);
                }

                int duplicateCount =
                    Convert.ToInt32(checkCommand.ExecuteScalar());

                if (duplicateCount > 0)
                {
                    MessageBox.Show(
                        "A vehicle with this registration number already exists.",
                        "Duplicate Vehicle",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtRegistrationNumber.Focus();
                    return;
                }

                // Keep current photo when editing
                string? savedImagePath =
                    vehicleId == null
                        ? null
                        : existingImagePath;

                // Save a newly selected photo
                if (!string.IsNullOrWhiteSpace(selectedImagePath))
                {
                    string imageFolder =
                        System.IO.Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData),
                            "SLP AutoCare",
                            "VehicleImages");

                    System.IO.Directory.CreateDirectory(imageFolder);

                    string extension =
                        System.IO.Path.GetExtension(selectedImagePath);

                    string fileName =
                        Guid.NewGuid().ToString() + extension;

                    savedImagePath =
                        System.IO.Path.Combine(
                            imageFolder,
                            fileName);

                    System.IO.File.Copy(
                        selectedImagePath,
                        savedImagePath,
                        true);
                }

                string query;

                if (vehicleId == null)
                {
                    query = @"
                INSERT INTO dbo.Vehicles
                (
                    CustomerID,
                    RegistrationNumber,
                    Brand,
                    Model,
                    VehicleType,
                    ManufacturingYear,
                    ImagePath
                )
                VALUES
                (
                    @CustomerID,
                    @RegistrationNumber,
                    @Brand,
                    @Model,
                    @VehicleType,
                    @ManufacturingYear,
                    @ImagePath
                );";
                }
                else
                {
                    query = @"
                UPDATE dbo.Vehicles
                SET CustomerID = @CustomerID,
                    RegistrationNumber = @RegistrationNumber,
                    Brand = @Brand,
                    Model = @Model,
                    VehicleType = @VehicleType,
                    ManufacturingYear = @ManufacturingYear,
                    ImagePath = @ImagePath
                WHERE VehicleID = @VehicleID;";
                }

                using var command =
                    new Microsoft.Data.SqlClient.SqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@CustomerID",
                    customerId);

                command.Parameters.AddWithValue(
                    "@RegistrationNumber",
                    registration);

                command.Parameters.AddWithValue(
                    "@Brand",
                    brand);

                command.Parameters.AddWithValue(
                    "@Model",
                    model);

                command.Parameters.AddWithValue(
                    "@VehicleType",
                    vehicleType);

                command.Parameters.AddWithValue(
                    "@ManufacturingYear",
                    year);

                command.Parameters.AddWithValue(
                    "@ImagePath",
                    string.IsNullOrWhiteSpace(savedImagePath)
                        ? DBNull.Value
                        : savedImagePath);

                if (vehicleId != null)
                {
                    command.Parameters.AddWithValue(
                        "@VehicleID",
                        vehicleId.Value);
                }

                command.ExecuteNonQuery();

                MessageBox.Show(
                    vehicleId == null
                        ? "Vehicle added successfully."
                        : "Vehicle updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save vehicle.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}