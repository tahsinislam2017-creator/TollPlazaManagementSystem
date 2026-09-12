using Microsoft.Data.SqlClient;

namespace TollPlazaManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        // Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Check if username or password is empty
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string query = @"
SELECT UserID, FullName, Role
FROM Users
WHERE Username = @Username
  AND PasswordHash = CONVERT(
      VARCHAR(64),
      HASHBYTES(
          'SHA2_256',
          CONVERT(VARCHAR(100), @Password)
      ),
      2
  )
  AND AccountStatus = 'Active'";

            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Username",
                            username
                        );

                        command.Parameters.AddWithValue(
                            "@Password",
                            password
                        );

                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Get logged-in user information
                                int userId =
                                    Convert.ToInt32(
                                        reader["UserID"]
                                    );

                                string fullName =
                                    reader["FullName"]
                                    ?.ToString() ?? "User";

                                string role =
                                    reader["Role"]
                                    ?.ToString() ?? "";

                                MessageBox.Show(
                                    $"Login successful!\n\n" +
                                    $"Welcome, {fullName}\n" +
                                    $"Role: {role}",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                // Open Admin Dashboard
                                if (role.Equals(
                                    "Admin",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    AdminDashboard dashboard =
                                        new AdminDashboard();

                                    dashboard.Show();

                                    // Hide Login Form
                                    this.Hide();
                                }

                                // Open Operator Dashboard
                                else if (role.Equals(
                                    "Operator",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    // Pass the logged-in Operator UserID
                                    // to the Operator Dashboard
                                    OperatorDashboardForm
                                        operatorDashboard =
                                        new OperatorDashboardForm(
                                            userId
                                        );

                                    operatorDashboard.Show();

                                    // Hide Login Form
                                    this.Hide();
                                }

                                // Invalid role
                                else
                                {
                                    MessageBox.Show(
                                        "Your account role is not recognized.",
                                        "Role Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                    );
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid username or password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
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

        private void panel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblSubtitle_Click(
            object sender,
            EventArgs e)
        {
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void btnExit_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}