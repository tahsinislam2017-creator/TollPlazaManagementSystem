using Microsoft.Data.SqlClient;

namespace TollPlazaManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Runs automatically when the Admin Dashboard opens
        private void AdminDashboard_Load(
            object sender,
            EventArgs e)
        {
            LoadDashboardData();
        }

        // =================================================
        // LOAD DASHBOARD STATISTICS
        // =================================================
        private void LoadDashboardData()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                // 1. Total Users
                string userQuery =
                    "SELECT COUNT(*) FROM Users";

                using (
                    SqlCommand command =
                    new SqlCommand(
                        userQuery,
                        connection
                    )
                )
                {
                    lblTotalUsers.Text =
                        command.ExecuteScalar()
                        ?.ToString()
                        ?? "0";
                }

                // 2. Total Toll Plazas
                string plazaQuery =
                    "SELECT COUNT(*) FROM TollPlazas";

                using (
                    SqlCommand command =
                    new SqlCommand(
                        plazaQuery,
                        connection
                    )
                )
                {
                    lblTotalPlazas.Text =
                        command.ExecuteScalar()
                        ?.ToString()
                        ?? "0";
                }

                // 3. Total Vehicles
                string vehicleQuery =
                    "SELECT COUNT(*) FROM Vehicles";

                using (
                    SqlCommand command =
                    new SqlCommand(
                        vehicleQuery,
                        connection
                    )
                )
                {
                    lblTotalVehicles.Text =
                        command.ExecuteScalar()
                        ?.ToString()
                        ?? "0";
                }

                // 4. Today's Transactions
                string transactionQuery = @"
SELECT COUNT(*)
FROM TollTransactions
WHERE CAST(TransactionDate AS DATE)
      = CAST(GETDATE() AS DATE);";

                using (
                    SqlCommand command =
                    new SqlCommand(
                        transactionQuery,
                        connection
                    )
                )
                {
                    lblTodayTransactions.Text =
                        command.ExecuteScalar()
                        ?.ToString()
                        ?? "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Dashboard data could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // DASHBOARD BUTTON
        // =================================================
        private void btnDashboard_Click(
            object sender,
            EventArgs e)
        {
            LoadDashboardData();

            MessageBox.Show(
                "Dashboard data has been refreshed.",
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // =================================================
        // USERS MANAGEMENT BUTTON
        // =================================================
        private void btnUsers_Click(
            object sender,
            EventArgs e)
        {
            UsersManagementForm usersForm =
                new UsersManagementForm();

            usersForm.ShowDialog();

            // Refresh dashboard after returning
            LoadDashboardData();
        }

        // =================================================
        // ADMIN TRANSACTIONS BUTTON
        // =================================================
        private void btnTransactions_Click(
            object sender,
            EventArgs e)
        {
            AdminTransactionForm
                transactionForm =
                new AdminTransactionForm();

            // Show the transaction form
            transactionForm.ShowDialog();

            // Refresh dashboard after returning
            LoadDashboardData();
        }

        // =================================================
        // TOLL SETUP BUTTON
        // =================================================
        private void btnTollSetup_Click(
      object sender,
      EventArgs e)
        {
            TollSetupForm tollSetupForm =
                new TollSetupForm();

            // Open Toll Setup as a child dialog
            tollSetupForm.ShowDialog();

            // Refresh dashboard data after returning
            LoadDashboardData();
        }

        // =================================================
        // LOGOUT BUTTON
        // =================================================
        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                this.Hide();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();

            reportsForm.ShowDialog();
        }
    }
}