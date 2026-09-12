using Microsoft.Data.SqlClient;
using System.Data;

namespace TollPlazaManagementSystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        // =================================================
        // FORM LOAD
        // =================================================
        private void ReportsForm_Load(
            object sender,
            EventArgs e)
        {
            // Set default date range
            dtpFromDate.Value =
                DateTime.Today.AddDays(-30);

            dtpToDate.Value =
                DateTime.Today;

            // Load filter data
            LoadReportPlazas();

            LoadReportCategories();

            // Load summary information
            LoadReportSummary();

            // Load transaction reports
            LoadReports();
        }

        // =================================================
        // LOAD TOLL PLAZAS INTO REPORT COMBOBOX
        // =================================================
        private void LoadReportPlazas()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT
    PlazaID,
    PlazaName
FROM TollPlazas
ORDER BY PlazaName;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
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

                // Add All Plazas option
                DataRow allRow =
                    dataTable.NewRow();

                allRow["PlazaID"] = 0;

                allRow["PlazaName"] =
                    "All Plazas";

                dataTable.Rows.InsertAt(
                    allRow,
                    0
                );

                cmbReportPlaza.DataSource =
                    dataTable;

                cmbReportPlaza.DisplayMember =
                    "PlazaName";

                cmbReportPlaza.ValueMember =
                    "PlazaID";

                cmbReportPlaza.SelectedIndex =
                    0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll plazas could not be loaded "
                    + "for the report.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD VEHICLE CATEGORIES INTO REPORT COMBOBOX
        // =================================================
        private void LoadReportCategories()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT
    CategoryID,
    CategoryName
FROM VehicleCategories
ORDER BY CategoryName;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
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

                // Add All Categories option
                DataRow allRow =
                    dataTable.NewRow();

                allRow["CategoryID"] = 0;

                allRow["CategoryName"] =
                    "All Categories";

                dataTable.Rows.InsertAt(
                    allRow,
                    0
                );

                cmbReportCategory.DataSource =
                    dataTable;

                cmbReportCategory.DisplayMember =
                    "CategoryName";

                cmbReportCategory.ValueMember =
                    "CategoryID";

                cmbReportCategory.SelectedIndex =
                    0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Vehicle categories could not be "
                    + "loaded for the report.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD REPORT SUMMARY
        // =================================================
        private void LoadReportSummary()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                // -----------------------------------------
                // TOTAL TRANSACTIONS
                // -----------------------------------------
                string totalTransactionsQuery = @"
SELECT COUNT(*)
FROM TollTransactions;";

                using SqlCommand totalTransactionsCommand =
                    new SqlCommand(
                        totalTransactionsQuery,
                        connection
                    );

                int totalTransactions =
                    Convert.ToInt32(
                        totalTransactionsCommand.ExecuteScalar()
                    );

                lblTotalTransactions.Text =
                    totalTransactions.ToString();

                // -----------------------------------------
                // TODAY TRANSACTIONS
                // -----------------------------------------
                string todayTransactionsQuery = @"
SELECT COUNT(*)
FROM TollTransactions
WHERE CAST(TransactionDate AS DATE)
    = CAST(GETDATE() AS DATE);";

                using SqlCommand todayTransactionsCommand =
                    new SqlCommand(
                        todayTransactionsQuery,
                        connection
                    );

                int todayTransactions =
                    Convert.ToInt32(
                        todayTransactionsCommand.ExecuteScalar()
                    );

                lblTodayTransactions.Text =
                    todayTransactions.ToString();

                // -----------------------------------------
                // TOTAL COLLECTION
                // -----------------------------------------
                string totalCollectionQuery = @"
SELECT
    ISNULL(SUM(TollAmount), 0)
FROM TollTransactions
WHERE TransactionStatus = 'Completed';";

                using SqlCommand totalCollectionCommand =
                    new SqlCommand(
                        totalCollectionQuery,
                        connection
                    );

                decimal totalCollection =
                    Convert.ToDecimal(
                        totalCollectionCommand.ExecuteScalar()
                    );

                lblTotalCollection.Text =
                    "৳ " +
                    totalCollection.ToString(
                        "N2"
                    );

                // -----------------------------------------
                // TODAY COLLECTION
                // -----------------------------------------
                string todayCollectionQuery = @"
SELECT
    ISNULL(SUM(TollAmount), 0)
FROM TollTransactions
WHERE CAST(TransactionDate AS DATE)
    = CAST(GETDATE() AS DATE)
AND TransactionStatus = 'Completed';";

                using SqlCommand todayCollectionCommand =
                    new SqlCommand(
                        todayCollectionQuery,
                        connection
                    );

                decimal todayCollection =
                    Convert.ToDecimal(
                        todayCollectionCommand.ExecuteScalar()
                    );

                lblTodayCollection.Text =
                    "৳ " +
                    todayCollection.ToString(
                        "N2"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Report summary could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD REPORTS
        // =================================================
        private void LoadReports()
        {
            try
            {
                int plazaId =
                    GetSelectedPlazaId();

                int categoryId =
                    GetSelectedCategoryId();

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
        AS [Booth Number],

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
ON TT.VehicleID = V.VehicleID

INNER JOIN TollPlazas TP
ON TT.PlazaID = TP.PlazaID

INNER JOIN TollBooths TB
ON TT.BoothID = TB.BoothID

INNER JOIN VehicleCategories VC
ON V.CategoryID = VC.CategoryID

WHERE
    TT.TransactionDate >= @FromDate

AND
    TT.TransactionDate < @ToDate

AND
(
    @PlazaID = 0
    OR TT.PlazaID = @PlazaID
)

AND
(
    @CategoryID = 0
    OR V.CategoryID = @CategoryID
)

ORDER BY
    TT.TransactionDate DESC;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
                    );

                DateTime fromDate =
                    dtpFromDate.Value.Date;

                DateTime toDate =
                    dtpToDate.Value.Date.AddDays(1);

                command.Parameters.AddWithValue(
                    "@FromDate",
                    fromDate
                );

                command.Parameters.AddWithValue(
                    "@ToDate",
                    toDate
                );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    plazaId
                );

                command.Parameters.AddWithValue(
                    "@CategoryID",
                    categoryId
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

                dgvReports.DataSource =
                    dataTable;

                dgvReports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvReports.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvReports.ReadOnly =
                    true;

                dgvReports.AllowUserToAddRows =
                    false;

                dgvReports.AllowUserToDeleteRows =
                    false;

                dgvReports.RowHeadersVisible =
                    false;

                dgvReports.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Report records could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // GET SELECTED PLAZA ID
        // =================================================
        private int GetSelectedPlazaId()
        {
            if (cmbReportPlaza.SelectedValue == null ||
                cmbReportPlaza.SelectedValue
                is DataRowView)
            {
                return 0;
            }

            return Convert.ToInt32(
                cmbReportPlaza.SelectedValue
            );
        }

        // =================================================
        // GET SELECTED CATEGORY ID
        // =================================================
        private int GetSelectedCategoryId()
        {
            if (cmbReportCategory.SelectedValue == null ||
                cmbReportCategory.SelectedValue
                is DataRowView)
            {
                return 0;
            }

            return Convert.ToInt32(
                cmbReportCategory.SelectedValue
            );
        }

        // =================================================
        // FILTER REPORT
        // =================================================
        private void btnFilterReport_Click(
            object sender,
            EventArgs e)
        {
            if (dtpFromDate.Value.Date >
                dtpToDate.Value.Date)
            {
                MessageBox.Show(
                    "From Date cannot be later "
                    + "than To Date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            LoadReports();
        }

        // =================================================
        // RESET REPORT
        // =================================================
        private void btnResetReport_Click(
            object sender,
            EventArgs e)
        {
            dtpFromDate.Value =
                DateTime.Today.AddDays(-30);

            dtpToDate.Value =
                DateTime.Today;

            cmbReportPlaza.SelectedIndex =
                0;

            cmbReportCategory.SelectedIndex =
                0;

            LoadReportSummary();

            LoadReports();
        }

        // =================================================
        // EMPTY DESIGNER CLICK EVENT
        // This fixes the existing event connection
        // in ReportsForm.Designer.cs
        // =================================================
        private void lblTodayCollectionTitle_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}