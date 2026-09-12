using Microsoft.Data.SqlClient;

namespace TollPlazaManagementSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();

            // Load ComboBox values when the form is created
            LoadComboBoxes();
        }

        // Loads Role and Account Status values
        private void LoadComboBoxes()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Operator");

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

            // Default selections
            cmbRole.SelectedIndex = 1;
            cmbStatus.SelectedIndex = 0;
        }

        // Save User button
        private void btnSaveUser_Click(
            object sender,
            EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            string role = cmbRole.SelectedItem?.ToString() ?? "";
            string status = cmbStatus.SelectedItem?.ToString() ?? "";

            // Validate required fields
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Minimum password length
            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must contain at least 6 characters.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            string checkUsernameQuery = @"
SELECT COUNT(*)
FROM Users
WHERE Username = @Username";

            string insertUserQuery = @"
INSERT INTO Users
(
    FullName,
    Username,
    PasswordHash,
    Phone,
    Email,
    Role,
    AccountStatus
)
VALUES
(
    @FullName,
    @Username,
    CONVERT(
        VARCHAR(64),
        HASHBYTES(
            'SHA2_256',
            CONVERT(VARCHAR(100), @Password)
        ),
        2
    ),
    @Phone,
    @Email,
    @Role,
    @AccountStatus
)";

            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Check whether the username already exists
                    using (SqlCommand checkCommand =
                           new SqlCommand(
                               checkUsernameQuery,
                               connection))
                    {
                        checkCommand.Parameters.AddWithValue(
                            "@Username",
                            username
                        );

                        int usernameCount =
                            Convert.ToInt32(
                                checkCommand.ExecuteScalar()
                            );

                        if (usernameCount > 0)
                        {
                            MessageBox.Show(
                                "This username already exists.\n\n" +
                                "Please choose another username.",
                                "Duplicate Username",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            txtUsername.Focus();
                            return;
                        }
                    }

                    // Insert the new user
                    using (SqlCommand insertCommand =
                           new SqlCommand(
                               insertUserQuery,
                               connection))
                    {
                        insertCommand.Parameters.AddWithValue(
                            "@FullName",
                            fullName
                        );

                        insertCommand.Parameters.AddWithValue(
                            "@Username",
                            username
                        );

                        insertCommand.Parameters.AddWithValue(
                            "@Password",
                            password
                        );

                        insertCommand.Parameters.AddWithValue(
                            "@Phone",
                            phone
                        );

                        insertCommand.Parameters.AddWithValue(
                            "@Email",
                            email
                        );

                        insertCommand.Parameters.AddWithValue(
                            "@Role",
                            role
                        );

                        insertCommand.Parameters.AddWithValue(
                            "@AccountStatus",
                            status
                        );

                        int rowsAffected =
                            insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "New user added successfully.",
                                "User Added",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // Tell Users Management that saving succeeded
                            DialogResult = DialogResult.OK;

                            // Close Add User form
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The user could not be added.",
                                "Save Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Cancel button
        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}