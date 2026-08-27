using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleServiceCenter
{
    public partial class ServiceRequestEditForm : Form
    {
        private int? requestId = null;
        public ServiceRequestEditForm()
        {
            InitializeComponent();

            LoadVehicles();

            cmbServiceType.Items.Clear();
            cmbServiceType.Items.AddRange(new string[]
            {
        "Oil Change",
        "Brake Service",
        "AC Service",
        "Engine Check",
        "Battery Check",
        "General Service",
        "Other"
            });

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[]
            {
        "Pending",
        "In Progress",
        "Completed"
            });

            cmbServiceType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }
        public ServiceRequestEditForm(
    int id,
    int vehicleId,
    DateTime requestDate,
    string serviceType,
    string problemDescription,
    string status)
    : this()
        {
            requestId = id;

            Text = "Edit Service Request";
            lblTitle.Text = "Edit Service Request";
            lblSubtitle.Text = "Update service request information";
            btnSave.Text = "UPDATE";

            cmbVehicle.SelectedValue = vehicleId;
            dtpRequestDate.Value = requestDate;
            cmbServiceType.SelectedItem = serviceType;
            txtProblemDescription.Text = problemDescription;
            cmbStatus.SelectedItem = status;
        }
        private void LoadVehicles()
        {
            try
            {
                using var connection = DatabaseConnection.GetConnection();

                string query = @"
            SELECT
                VehicleID,
                RegistrationNumber + ' - ' + Brand + ' ' + Model AS VehicleDisplay
            FROM dbo.Vehicles
            ORDER BY RegistrationNumber;";

                using var adapter =
                    new Microsoft.Data.SqlClient.SqlDataAdapter(query, connection);

                var table = new System.Data.DataTable();
                adapter.Fill(table);

                cmbVehicle.DataSource = table;
                cmbVehicle.DisplayMember = "VehicleDisplay";
                cmbVehicle.ValueMember = "VehicleID";
                cmbVehicle.SelectedIndex = -1;
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

        private void blSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                if (cmbVehicle.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a vehicle.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (cmbServiceType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a service type.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string problem = txtProblemDescription.Text.Trim();

                if (string.IsNullOrWhiteSpace(problem))
                {
                    MessageBox.Show("Problem description is required.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a status.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    int vehicleId = Convert.ToInt32(cmbVehicle.SelectedValue);
                    string serviceType = cmbServiceType.SelectedItem!.ToString()!;
                    string status = cmbStatus.SelectedItem!.ToString()!;

                    using var connection = DatabaseConnection.GetConnection();
                    connection.Open();


                string query;

                if (requestId == null)
                {
                    query = @"
        INSERT INTO dbo.ServiceRequests
        (
            VehicleID,
            RequestDate,
            ServiceType,
            ProblemDescription,
            Status
        )
        VALUES
        (
            @VehicleID,
            @RequestDate,
            @ServiceType,
            @ProblemDescription,
            @Status
        );";
                }
                else
                {
                    query = @"
        UPDATE dbo.ServiceRequests
        SET VehicleID = @VehicleID,
            RequestDate = @RequestDate,
            ServiceType = @ServiceType,
            ProblemDescription = @ProblemDescription,
            Status = @Status
        WHERE RequestID = @RequestID;";
                }

                using var command =
                    new Microsoft.Data.SqlClient.SqlCommand(query, connection);

                command.Parameters.AddWithValue("@VehicleID", vehicleId);
                command.Parameters.AddWithValue("@RequestDate", dtpRequestDate.Value.Date);
                command.Parameters.AddWithValue("@ServiceType", serviceType);
                command.Parameters.AddWithValue("@ProblemDescription", problem);
                command.Parameters.AddWithValue("@Status", status);

                if (requestId != null)
                {
                    command.Parameters.AddWithValue(
                        "@RequestID",
                        requestId.Value);
                }

                command.ExecuteNonQuery();

                MessageBox.Show(
                    requestId == null
                        ? "Service request added successfully."
                        : "Service request updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();

                DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to save service request.\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
        }
    }
