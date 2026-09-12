using Microsoft.Data.SqlClient;

namespace TollPlazaManagementSystem
{
    public partial class UpdateUserForm : Form
    {
        // Stores the UserID of the selected user
        private int selectedUserId;

        // Constructor receives the selected UserID
        public UpdateUserForm(int userId)
        {
            InitializeComponent();

            selectedUserId = userId;
        }

        // Runs automatically when the form opens
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            // Add Role values
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Operator");

            // Add Account Status values
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

            // Load the selected user's information
            LoadUserData();
        }

        // Gets the selected user's information from SQL Server
        private void LoadUserData()
        {
            string query = @"
SELECT FullName, Username, Phone, Email, Role, AccountStatus
FROM Users
WHERE UserID = @UserID";

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
                            "@UserID", selectedUserId);

                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text =
                                    reader["FullName"].ToString();

                                txtUsername.Text =
                                    reader["Username"].ToString();

                                txtPhone.Text =
                                    reader["Phone"].ToString();

                                txtEmail.Text =
                                    reader["Email"].ToString();

                                cmbRole.Text =
                                    reader["Role"].ToString();

                                cmbStatus.Text =
                                    reader["AccountStatus"].ToString();

                                // Password is intentionally empty
                                // The password changes only if a new
                                // password is entered.
                                txtPassword.Clear();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "The selected user was not found.",
                                    "User Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "User information could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Updates the selected user
        private void btnUpdateUser_Click(
            object sender,
            EventArgs e)
        {
            string fullName =
                txtFullName.Text.Trim();

            string username =
                txtUsername.Text.Trim();

            string newPassword =
                txtPassword.Text;

            string phone =
                txtPhone.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string role =
                cmbRole.Text;

            string status =
                cmbStatus.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show(
                    "Please complete all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // If no new password is entered,
                    // keep the old password unchanged.
                    string query;

                    if (string.IsNullOrWhiteSpace(newPassword))
                    {
                        query = @"
UPDATE Users
SET
    FullName = @FullName,
    Username = @Username,
    Phone = @Phone,
    Email = @Email,
    Role = @Role,
    AccountStatus = @AccountStatus
WHERE UserID = @UserID";
                    }
                    else
                    {
                        query = @"
UPDATE Users
SET
    FullName = @FullName,
    Username = @Username,
    PasswordHash = CONVERT(
        VARCHAR(64),
        HASHBYTES(
            'SHA2_256',
            CONVERT(VARCHAR(100), @Password)
        ),
        2
    ),
    Phone = @Phone,
    Email = @Email,
    Role = @Role,
    AccountStatus = @AccountStatus
WHERE UserID = @UserID";
                    }

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@FullName", fullName);

                        command.Parameters.AddWithValue(
                            "@Username", username);

                        command.Parameters.AddWithValue(
                            "@Phone", phone);

                        command.Parameters.AddWithValue(
                            "@Email", email);

                        command.Parameters.AddWithValue(
                            "@Role", role);

                        command.Parameters.AddWithValue(
                            "@AccountStatus", status);

                        command.Parameters.AddWithValue(
                            "@UserID", selectedUserId);

                        // Add password only when the user
                        // entered a new password.
                        if (!string.IsNullOrWhiteSpace(
                            newPassword))
                        {
                            command.Parameters.AddWithValue(
                                "@Password", newPassword);
                        }

                        int rowsAffected =
                            command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "User updated successfully!",
                                "Update Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            this.DialogResult =
                                DialogResult.OK;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The user could not be updated.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Closes the form without saving
        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}