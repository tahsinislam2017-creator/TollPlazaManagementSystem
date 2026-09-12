using Microsoft.Data.SqlClient;

namespace TollPlazaManagementSystem
{
    public partial class OperatorDashboardForm : Form
    {
        // Stores the UserID of the currently logged-in operator
        private readonly int loggedInOperatorId;

        // Receives the Operator UserID from LoginForm
        public OperatorDashboardForm(int operatorId)
        {
            InitializeComponent();

            loggedInOperatorId = operatorId;
        }

        // Runs automatically when the Operator Dashboard opens
        private void OperatorDashboardForm_Load(
            object sender,
            EventArgs e)
        {
            // Show the current date
            lblOperatorDate.Text =
                DateTime.Now.ToString(
                    "dddd, dd MMMM yyyy"
                );

            // Load dashboard information
            LoadOperatorDashboardData();
        }

        // Loads transaction statistics from SQL Server
        private void LoadOperatorDashboardData()
        {
            try
            {
                using (SqlConnection connection =
                       DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // 1. Today's total transactions
                    string todayTransactionQuery = @"
SELECT COUNT(*)
FROM TollTransactions
WHERE CAST(TransactionDate AS DATE)
      = CAST(GETDATE() AS DATE)";

                    using (SqlCommand command =
                           new SqlCommand(
                               todayTransactionQuery,
                               connection))
                    {
                        lblOperatorTodayTransactions.Text =
                            command.ExecuteScalar()
                            ?.ToString() ?? "0";
                    }

                    // 2. Today's total toll collection
                    string todayCollectionQuery = @"
SELECT ISNULL(
    SUM(TollAmount),
    0
)
FROM TollTransactions
WHERE CAST(TransactionDate AS DATE)
      = CAST(GETDATE() AS DATE)";

                    using (SqlCommand command =
                           new SqlCommand(
                               todayCollectionQuery,
                               connection))
                    {
                        decimal todayCollection =
                            Convert.ToDecimal(
                                command.ExecuteScalar()
                            );

                        lblOperatorTodayCollection.Text =
                            "৳ " +
                            todayCollection.ToString(
                                "N2"
                            );
                    }

                    // 3. Total transactions
                    string totalTransactionQuery = @"
SELECT COUNT(*)
FROM TollTransactions";

                    using (SqlCommand command =
                           new SqlCommand(
                               totalTransactionQuery,
                               connection))
                    {
                        lblOperatorTotalTransactions.Text =
                            command.ExecuteScalar()
                            ?.ToString() ?? "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Operator dashboard data could not " +
                    "be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Dashboard button
        private void btnOperatorDashboard_Click(
            object sender,
            EventArgs e)
        {
            // Reload dashboard statistics
            LoadOperatorDashboardData();
        }

        // New Toll Transaction button
        private void btnNewTransaction_Click(
     object sender,
     EventArgs e)
        {
            TollTransactionForm transactionForm =
                new TollTransactionForm(
                    loggedInOperatorId,
                    this
                );

            transactionForm.Show();

            // Hide the dashboard while the transaction
            // form is open
            this.Hide();
        }

        // Transaction History button
        private void btnTransactionHistory_Click(
     object sender,
     EventArgs e)
        {
            TransactionHistoryForm historyForm =
                new TransactionHistoryForm(
                    loggedInOperatorId
                );

            historyForm.Show();

            // Hide the Operator Dashboard
            this.Hide();

            // When Transaction History closes,
            // show the Operator Dashboard again
            historyForm.FormClosed +=
                (s, args) =>
                {
                    this.Show();

                    // Refresh dashboard information
                    LoadOperatorDashboardData();
                };
        }

        // Logout button
        private void btnOperatorLogout_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                // Open Login Form again
                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                // Close Operator Dashboard
                this.Close();
            }
        }
    }
}