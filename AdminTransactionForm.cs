using Microsoft.Data.SqlClient;
using System.Data;

namespace TollPlazaManagementSystem
{
    public partial class AdminTransactionForm : Form
    {
        public AdminTransactionForm()
        {
            InitializeComponent();
        }

        // =================================================
        // FORM LOAD
        // =================================================
        private void AdminTransactionForm_Load(
            object sender,
            EventArgs e)
        {
            // Show the current date
            lblAdminTransactionDate.Text =
                DateTime.Now.ToString(
                    "dddd, dd MMMM yyyy"
                );

            // Load all transactions
            LoadAdminTransactions();
        }

        // =================================================
        // LOAD ALL ADMIN TRANSACTIONS
        // =================================================
        private void LoadAdminTransactions(
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

    U.FullName
        AS [Operator Name],

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

INNER JOIN Users U
    ON TT.OperatorID =
       U.UserID

WHERE
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
                dgvAdminTransactions
                    .DataSource =
                    dataTable;

                // DataGridView settings
                dgvAdminTransactions
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode
                    .Fill;

                dgvAdminTransactions
                    .SelectionMode =
                    DataGridViewSelectionMode
                    .FullRowSelect;

                dgvAdminTransactions
                    .ReadOnly = true;

                dgvAdminTransactions
                    .AllowUserToAddRows =
                    false;

                dgvAdminTransactions
                    .AllowUserToDeleteRows =
                    false;

                dgvAdminTransactions
                    .RowHeadersVisible =
                    false;

                // Show total transaction count
                lblAdminTotalTransactions.Text =
                    dataTable.Rows.Count
                    .ToString();

                // Calculate total toll collection
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

                // Show total collection
                lblAdminTotalCollection.Text =
                    "৳ " +
                    totalCollection
                    .ToString(
                        "N2"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Admin transaction records " +
                    "could not be loaded.\n\n" +
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
        private void btnAdminSearch_Click(
            object sender,
            EventArgs e)
        {
            string vehicleNumber =
                txtAdminVehicleSearch
                .Text
                .Trim();

            LoadAdminTransactions(
                vehicleNumber
            );
        }

        // =================================================
        // REFRESH BUTTON
        // =================================================
        private void btnAdminRefresh_Click(
            object sender,
            EventArgs e)
        {
            // Clear the search box
            txtAdminVehicleSearch.Clear();

            // Reload all transactions
            LoadAdminTransactions();

            // Put the cursor in the search box
            txtAdminVehicleSearch.Focus();
        }

        // =================================================
        // BACK BUTTON
        // =================================================
        private void btnAdminBack_Click(
            object sender,
            EventArgs e)
        {
            // Close this form.
            // The Admin Dashboard will be shown again
            // by the dashboard navigation code.
            this.Close();
        }
    }
}