using Microsoft.Data.SqlClient;
using System.Data;

namespace TollPlazaManagementSystem
{
    public partial class TollTransactionForm : Form
    {
        // Stores the UserID of the currently logged-in operator
        private readonly int loggedInOperatorId;

        // Stores the existing Operator Dashboard
        private readonly OperatorDashboardForm operatorDashboard;

        // Receives the Operator ID and Operator Dashboard
        public TollTransactionForm(
            int operatorId,
            OperatorDashboardForm dashboard)
        {
            InitializeComponent();

            loggedInOperatorId = operatorId;

            operatorDashboard = dashboard;
        }

        // Runs automatically when the form opens
        private void TollTransactionForm_Load(
            object sender,
            EventArgs e)
        {
            // Show current date and time
            lblTransactionDate.Text =
                DateTime.Now.ToString(
                    "dddd, dd MMMM yyyy | hh:mm tt"
                );

            // Load data from SQL Server
            LoadTollPlazas();
            LoadVehicleCategories();

            // Add payment methods
            LoadPaymentMethods();

            // Initially clear toll booth
            cmbTollBooth.DataSource = null;
            cmbTollBooth.Items.Clear();

            // Starting toll amount
            txtTollAmount.Text = "0.00";

            // Operator cannot manually edit toll amount
            txtTollAmount.ReadOnly = true;
        }

        // =================================================
        // LOAD TOLL PLAZAS
        // =================================================
        private void LoadTollPlazas()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT PlazaID, PlazaName
FROM TollPlazas
WHERE Status = 'Active'
ORDER BY PlazaName;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
                    );

                using SqlDataReader reader =
                    command.ExecuteReader();

                DataTable dataTable =
                    new DataTable();

                dataTable.Load(reader);

                cmbTollPlaza.DataSource =
                    dataTable;

                cmbTollPlaza.DisplayMember =
                    "PlazaName";

                cmbTollPlaza.ValueMember =
                    "PlazaID";

                cmbTollPlaza.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll plazas could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD TOLL BOOTHS
        // =================================================
        private void LoadTollBooths(
            int plazaId)
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT BoothID, BoothNumber
FROM TollBooths
WHERE PlazaID = @PlazaID
AND BoothStatus = 'Active'
ORDER BY BoothNumber;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    plazaId
                );

                using SqlDataReader reader =
                    command.ExecuteReader();

                DataTable dataTable =
                    new DataTable();

                dataTable.Load(reader);

                cmbTollBooth.DataSource =
                    dataTable;

                cmbTollBooth.DisplayMember =
                    "BoothNumber";

                cmbTollBooth.ValueMember =
                    "BoothID";

                cmbTollBooth.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll booths could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD VEHICLE CATEGORIES
        // =================================================
        private void LoadVehicleCategories()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT CategoryID, CategoryName
FROM VehicleCategories
ORDER BY CategoryName;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
                    );

                using SqlDataReader reader =
                    command.ExecuteReader();

                DataTable dataTable =
                    new DataTable();

                dataTable.Load(reader);

                cmbVehicleCategory.DataSource =
                    dataTable;

                cmbVehicleCategory.DisplayMember =
                    "CategoryName";

                cmbVehicleCategory.ValueMember =
                    "CategoryID";

                cmbVehicleCategory.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Vehicle categories could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD PAYMENT METHODS
        // =================================================
        private void LoadPaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();

            cmbPaymentMethod.Items.Add(
                "Cash"
            );

            cmbPaymentMethod.Items.Add(
                "Card"
            );

            cmbPaymentMethod.Items.Add(
                "Mobile Banking"
            );

            cmbPaymentMethod.SelectedIndex =
                -1;
        }

        // =================================================
        // TOLL PLAZA CHANGED
        // =================================================
        private void cmbTollPlaza_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbTollPlaza.SelectedValue == null)
            {
                return;
            }

            if (cmbTollPlaza.SelectedValue
                is DataRowView)
            {
                return;
            }

            if (int.TryParse(
                cmbTollPlaza.SelectedValue
                    .ToString(),
                out int plazaId))
            {
                LoadTollBooths(
                    plazaId
                );

                txtTollAmount.Text =
                    "0.00";

                CalculateTollAmount();
            }
        }

        // =================================================
        // VEHICLE CATEGORY CHANGED
        // =================================================
        private void cmbVehicleCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            CalculateTollAmount();
        }

        // =================================================
        // SECOND DESIGNER EVENT
        // =================================================
        private void cmbVehicleCategory_SelectedIndexChanged_1(
            object sender,
            EventArgs e)
        {
            CalculateTollAmount();
        }

        // =================================================
        // CALCULATE TOLL AMOUNT
        // =================================================
        private void CalculateTollAmount()
        {
            if (cmbTollPlaza.SelectedValue == null ||
                cmbVehicleCategory.SelectedValue == null)
            {
                return;
            }

            if (cmbTollPlaza.SelectedValue
                is DataRowView)
            {
                return;
            }

            if (cmbVehicleCategory.SelectedValue
                is DataRowView)
            {
                return;
            }

            if (!int.TryParse(
                cmbTollPlaza.SelectedValue
                    .ToString(),
                out int plazaId))
            {
                return;
            }

            if (!int.TryParse(
                cmbVehicleCategory.SelectedValue
                    .ToString(),
                out int categoryId))
            {
                return;
            }

            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT TOP 1 TollAmount
FROM TollRates
WHERE PlazaID = @PlazaID
AND CategoryID = @CategoryID
AND RateStatus = 'Active'
AND EffectiveDate <= CAST(
    GETDATE() AS DATE
)
ORDER BY EffectiveDate DESC;";

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    plazaId
                );

                command.Parameters.AddWithValue(
                    "@CategoryID",
                    categoryId
                );

                object? result =
                    command.ExecuteScalar();

                if (result != null &&
                    result != DBNull.Value)
                {
                    decimal tollAmount =
                        Convert.ToDecimal(
                            result
                        );

                    txtTollAmount.Text =
                        tollAmount.ToString(
                            "0.00"
                        );
                }
                else
                {
                    txtTollAmount.Text =
                        "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll amount could not be calculated.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // SAVE TRANSACTION
        // =================================================
        private void btnSaveTransaction_Click(
            object sender,
            EventArgs e)
        {
            string vehicleNumber =
                txtVehicleNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(
                vehicleNumber))
            {
                MessageBox.Show(
                    "Please enter the vehicle number.",
                    "Vehicle Number Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtVehicleNumber.Focus();

                return;
            }

            if (cmbTollPlaza.SelectedValue == null ||
                cmbTollPlaza.SelectedValue
                    is DataRowView)
            {
                MessageBox.Show(
                    "Please select a toll plaza.",
                    "Toll Plaza Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbTollBooth.SelectedValue == null ||
                cmbTollBooth.SelectedValue
                    is DataRowView)
            {
                MessageBox.Show(
                    "Please select a toll booth.",
                    "Toll Booth Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbVehicleCategory
                    .SelectedValue == null ||
                cmbVehicleCategory
                    .SelectedValue
                    is DataRowView)
            {
                MessageBox.Show(
                    "Please select a vehicle category.",
                    "Vehicle Category Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbPaymentMethod
                .SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Payment Method Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(
                txtTollAmount.Text,
                out decimal tollAmount)
                || tollAmount <= 0)
            {
                MessageBox.Show(
                    "No valid toll rate was found.\n\n" +
                    "Please select a valid toll plaza " +
                    "and vehicle category.",
                    "Invalid Toll Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                int plazaId =
                    Convert.ToInt32(
                        cmbTollPlaza
                            .SelectedValue
                    );

                int boothId =
                    Convert.ToInt32(
                        cmbTollBooth
                            .SelectedValue
                    );

                int categoryId =
                    Convert.ToInt32(
                        cmbVehicleCategory
                            .SelectedValue
                    );

                string paymentMethod =
                    cmbPaymentMethod
                        .SelectedItem
                        ?.ToString()
                    ?? "";

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                int vehicleId =
                    GetOrCreateVehicle(
                        connection,
                        vehicleNumber,
                        categoryId
                    );

                string insertQuery = @"
INSERT INTO TollTransactions
(
    VehicleID,
    PlazaID,
    BoothID,
    OperatorID,
    TollAmount,
    PaymentMethod,
    TransactionDate,
    TransactionStatus
)
VALUES
(
    @VehicleID,
    @PlazaID,
    @BoothID,
    @OperatorID,
    @TollAmount,
    @PaymentMethod,
    GETDATE(),
    'Completed'
);";

                using SqlCommand command =
                    new SqlCommand(
                        insertQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@VehicleID",
                    vehicleId
                );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    plazaId
                );

                command.Parameters.AddWithValue(
                    "@BoothID",
                    boothId
                );

                command.Parameters.AddWithValue(
                    "@OperatorID",
                    loggedInOperatorId
                );

                command.Parameters.AddWithValue(
                    "@TollAmount",
                    tollAmount
                );

                command.Parameters.AddWithValue(
                    "@PaymentMethod",
                    paymentMethod
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll transaction saved successfully.",
                    "Transaction Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearTransactionForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll transaction could not be saved.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // GET EXISTING VEHICLE OR CREATE NEW VEHICLE
        // =================================================
        private int GetOrCreateVehicle(
            SqlConnection connection,
            string vehicleNumber,
            int categoryId)
        {
            string findVehicleQuery = @"
SELECT VehicleID
FROM Vehicles
WHERE RegistrationNumber =
      @RegistrationNumber;";

            using (
                SqlCommand command =
                new SqlCommand(
                    findVehicleQuery,
                    connection
                )
            )
            {
                command.Parameters.AddWithValue(
                    "@RegistrationNumber",
                    vehicleNumber
                );

                object? result =
                    command.ExecuteScalar();

                if (result != null &&
                    result != DBNull.Value)
                {
                    return Convert.ToInt32(
                        result
                    );
                }
            }

            string insertVehicleQuery = @"
INSERT INTO Vehicles
(
    RegistrationNumber,
    CategoryID,
    OwnerName,
    OwnerPhone,
    CreatedAt
)
VALUES
(
    @RegistrationNumber,
    @CategoryID,
    'Unknown',
    'Unknown',
    GETDATE()
);

SELECT CAST(
    SCOPE_IDENTITY()
    AS INT
);";

            using SqlCommand insertCommand =
                new SqlCommand(
                    insertVehicleQuery,
                    connection
                );

            insertCommand.Parameters.AddWithValue(
                "@RegistrationNumber",
                vehicleNumber
            );

            insertCommand.Parameters.AddWithValue(
                "@CategoryID",
                categoryId
            );

            return Convert.ToInt32(
                insertCommand.ExecuteScalar()
            );
        }

        // =================================================
        // CLEAR BUTTON
        // =================================================
        private void btnClearTransaction_Click(
            object sender,
            EventArgs e)
        {
            ClearTransactionForm();
        }

        // =================================================
        // CLEAR FORM
        // =================================================
        private void ClearTransactionForm()
        {
            txtVehicleNumber.Clear();

            cmbTollPlaza.SelectedIndex =
                -1;

            cmbTollBooth.DataSource =
                null;

            cmbTollBooth.Items.Clear();

            cmbVehicleCategory
                .SelectedIndex = -1;

            cmbPaymentMethod
                .SelectedIndex = -1;

            txtTollAmount.Text =
                "0.00";

            lblTransactionDate.Text =
                DateTime.Now.ToString(
                    "dddd, dd MMMM yyyy | hh:mm tt"
                );

            txtVehicleNumber.Focus();
        }

        // =================================================
        // BACK TO OPERATOR DASHBOARD
        // =================================================
        private void btnBackToOperator_Click(
            object sender,
            EventArgs e)
        {
            // Show the existing hidden Operator Dashboard
            operatorDashboard.Show();

            // Close the Toll Transaction form
            this.Close();
        }

        // =================================================
        // DESIGNER EVENTS
        // =================================================
        private void txtTollAmount_TextChanged(
            object sender,
            EventArgs e)
        {
            // Kept because the Designer is connected.
        }

        private void lblTransactionDate_Click(
            object sender,
            EventArgs e)
        {
            // No action is required.
        }
    }
}