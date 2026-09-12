using Microsoft.Data.SqlClient;
using System.Data;

namespace TollPlazaManagementSystem
{
    public partial class UsersManagementForm : Form
    {
        public UsersManagementForm()
        {
            InitializeComponent();
        }

        // Runs automatically when the form opens
        private void UsersManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Loads all users from the SQL Server database
        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
SELECT
    UserID,
    FullName,
    Username,
    Role,
    AccountStatus,
    CreatedAt
FROM Users
ORDER BY UserID DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvUsers.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Users could not be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Refresh button
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            LoadUsers();
        }

        // Search users by name, username, or role
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearch.Text.Trim();

            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = @"
SELECT
    UserID,
    FullName,
    Username,
    Role,
    AccountStatus,
    CreatedAt
FROM Users
WHERE FullName LIKE @Search
   OR Username LIKE @Search
   OR Role LIKE @Search
ORDER BY UserID DESC";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%"
                        );

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvUsers.DataSource =
                                table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" +
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (AddUserForm addUserForm =
           new AddUserForm())
            {
                if (addUserForm.ShowDialog() ==
                    DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }



        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Check whether a user row is selected
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a user from the table first.",
                    "No User Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Get the UserID from the selected row
            int userId = Convert.ToInt32(
                dgvUsers.CurrentRow.Cells["UserID"].Value
            );

            // Open the Update User form
            using (UpdateUserForm updateForm =
                   new UpdateUserForm(userId))
            {
                // If the update was successful,
                // reload the users table
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void btnDeleteUser_Click(
    object sender,
    EventArgs e)
        {
            // Check whether a user row is selected
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a user from the table first.",
                    "No User Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Get selected user's information
            int userId = Convert.ToInt32(
                dgvUsers.CurrentRow.Cells["UserID"].Value
            );

            string fullName =
                dgvUsers.CurrentRow.Cells["FullName"]
                .Value?.ToString() ?? "this user";

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete:\n\n" +
                $"{fullName}?\n\n" +
                "This action cannot be undone.",
                "Confirm User Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Stop if the admin clicks No
            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = @"
DELETE FROM Users
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
                            "@UserID",
                            userId
                        );

                        int rowsAffected =
                            command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "User deleted successfully.",
                                "Delete Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // Reload the DataGridView
                            LoadUsers();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The selected user could not be found.",
                                "Delete Failed",
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
                    "The user could not be deleted.\n\n" +
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



    }
}
