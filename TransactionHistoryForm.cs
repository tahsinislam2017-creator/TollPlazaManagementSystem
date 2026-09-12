using Microsoft.Data.SqlClient;
using System.Data;

namespace TollPlazaManagementSystem
{
    public partial class TransactionHistoryForm : Form
    {
        // Stores the UserID of the currently logged-in operator
        private readonly int loggedInOperatorId;

        // Receives the logged-in Operator ID
        public TransactionHistoryForm(int operatorId)
        {
            InitializeComponent();

            loggedInOperatorId = operatorId;
        }

        // =================================================
        // FORM LOAD
        // =================================================
        private void TransactionHistoryForm_Load(
            object sender,
            EventArgs e)
        {
            // Show the current date
            lblHistoryDate.Text =
                DateTime.Now.ToString(
                    "dddd, dd MMMM yyyy"
                );

            // Load all transactions of the logged-in operator
            LoadTransactionHistory();
        }

        // =================================================
        // LOAD TRANSACTION HISTORY
        // =================================================
        private void LoadTransactionHistory(
            string vehicleNumber = "")
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT
    TT.TransactionID
        AS [Transaction ID],

    V.RegistrationNumber
        AS [Vehicle Number],

    TP.PlazaName
        AS [Toll Plaza],

    TB.BoothNumber
        AS [Toll Booth],

    VC.CategoryName
        AS [Vehicle Category],

    TT.TollAmount
        AS [Toll Amount],

    TT.PaymentMethod
        AS [Payment Method],

    TT.TransactionDate
        AS [Transaction Date],

    TT.TransactionStatus
        AS [Status]

FROM TollTransactions TT

INNER JOIN Vehicles V
    ON TT.VehicleID =
       V.VehicleID

INNER JOIN TollPlazas TP
    ON TT.PlazaID =
       TP.PlazaID

INNER JOIN TollBooths TB
    ON TT.BoothID =
       TB.BoothID

INNER JOIN VehicleCategories VC
    ON V.CategoryID =
       VC.CategoryID

WHERE TT.OperatorID =
      @OperatorID

AND
(
    @VehicleNumber = ''
    OR
    V.RegistrationNumber
        LIKE '%' +
             @VehicleNumber +
             '%'
)

ORDER BY
    TT.TransactionDate DESC;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@OperatorID",
                    loggedInOperatorId
                );

                command.Parameters.AddWithValue(
                    "@VehicleNumber",
                    vehicleNumber
                );

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        command
                    );

                DataTable dataTable =
                    new DataTable();

                adapter.Fill(
                    dataTable
                );

                // Show records in DataGridView
                dgvTransactionHistory
                    .DataSource =
                    dataTable;

                // Make the DataGridView easier to read
                dgvTransactionHistory
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode
                    .Fill;

                dgvTransactionHistory
                    .SelectionMode =
                    DataGridViewSelectionMode
                    .FullRowSelect;

                dgvTransactionHistory
                    .ReadOnly = true;

                dgvTransactionHistory
                    .AllowUserToAddRows =
                    false;

                dgvTransactionHistory
                    .AllowUserToDeleteRows =
                    false;

                dgvTransactionHistory
                    .RowHeadersVisible =
                    false;

                // Update transaction count
                lblTotalHistoryCount.Text =
                    dataTable.Rows.Count
                    .ToString();

                // Calculate total collection
                decimal totalCollection = 0;

                foreach (
                    DataRow row
                    in dataTable.Rows
                )
                {
                    if (
                        row["Toll Amount"]
                        != DBNull.Value
                    )
                    {
                        totalCollection +=
                            Convert.ToDecimal(
                                row["Toll Amount"]
                            );
                    }
                }

                lblTotalHistoryCollection
                    .Text =
                    "৳ " +
                    totalCollection
                    .ToString(
                        "N2"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Transaction history could not " +
                    "be loaded.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // SEARCH BUTTON
        // =================================================
        private void btnSearchHistory_Click(
            object sender,
            EventArgs e)
        {
            string vehicleNumber =
                txtSearchVehicle
                .Text
                .Trim();

            LoadTransactionHistory(
                vehicleNumber
            );
        }

        // =================================================
        // REFRESH BUTTON
        // =================================================
        private void btnRefreshHistory_Click(
            object sender,
            EventArgs e)
        {
            // Clear the search box
            txtSearchVehicle.Clear();

            // Reload all operator transactions
            LoadTransactionHistory();

            // Put the cursor back in the search box
            txtSearchVehicle.Focus();
        }

        // =================================================
        // BACK BUTTON
        // =================================================
        private void btnBackHistory_Click(
            object sender,
            EventArgs e)
        {
            // Close this form and return to
            // the already-open Operator Dashboard
            this.Close();
        }

        private void label1_Click(
    object sender,
    EventArgs e)
        {
            // No action is needed.
        }

    }
}