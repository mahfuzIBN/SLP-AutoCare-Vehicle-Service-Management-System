using VehicleServiceCenter;

namespace VehicleServiceCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void pnlBrand_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string query = @"SELECT Role
                         FROM Users
                         WHERE Username = @Username
                         AND Password = @Password";

                using var command =
                    new Microsoft.Data.SqlClient.SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@Username",
                    txtUsername.Text.Trim()
                );

                command.Parameters.AddWithValue(
                    "@Password",
                    txtPassword.Text
                );

                object? result = command.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString()!;

                    MessageBox.Show(
                        "Login successful!\nWelcome " + txtUsername.Text,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    DashboardForm dashboard = new DashboardForm();
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}