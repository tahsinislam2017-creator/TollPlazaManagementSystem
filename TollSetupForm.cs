using Microsoft.Data.SqlClient;
using System.Data;

namespace TollPlazaManagementSystem
{
    public partial class TollSetupForm : Form
    {
        // =================================================
        // SELECTED IDs
        // =================================================

        // Stores the PlazaID of the selected plaza row
        private int selectedPlazaId = 0;

        // Stores the BoothID of the selected booth row
        private int selectedBoothId = 0;

        // Stores the CategoryID of the selected category row
        private int selectedCategoryId = 0;

        // Stores the TollRateID of the selected toll rate row
        private int selectedRateId = 0;

        public TollSetupForm()
        {
            InitializeComponent();
        }

        // =================================================
        // FORM LOAD
        // =================================================
        private void TollSetupForm_Load(
            object sender,
            EventArgs e)
        {
            //new code
            LoadVehicleCategories();
            // ---------------------------------------------
            // LOAD TOLL RATE DATA
            // ---------------------------------------------
            LoadRatePlazas();

            LoadRateCategories();

            LoadTollRates();

            // Set default values
            dtpEffectiveDate.Value = DateTime.Today;

            cmbRateStatus.SelectedIndex = 0;

            btnUpdateRate.Enabled = false;

            // ---------------------------------------------
            // TOLL PLAZA STATUS
            // ---------------------------------------------
            cmbPlazaStatus.Items.Clear();

            cmbPlazaStatus.Items.Add(
                "Active"
            );

            cmbPlazaStatus.Items.Add(
                "Inactive"
            );

            cmbPlazaStatus.SelectedIndex = 0;

            // ---------------------------------------------
            // TOLL BOOTH STATUS
            // ---------------------------------------------
            cmbBoothStatus.Items.Clear();

            cmbBoothStatus.Items.Add(
                "Active"
            );

            cmbBoothStatus.Items.Add(
                "Inactive"
            );

            cmbBoothStatus.SelectedIndex = 0;

            // ---------------------------------------------
            // LOAD TOLL PLAZA DATA
            // ---------------------------------------------
            LoadTollPlazas();

            // ---------------------------------------------
            // LOAD TOLL BOOTH DATA
            // ---------------------------------------------
            LoadBoothPlazas();

            LoadTollBooths();

            // ---------------------------------------------
            // LOAD VEHICLE CATEGORY DATA
            // ---------------------------------------------
            LoadVehicleCategories();

            // ---------------------------------------------
            // LOAD TOLL RATE DATA
            // ---------------------------------------------
            LoadRatePlazas();

            LoadRateCategories();

            LoadTollRates();

            // ---------------------------------------------
            // DISABLE UPDATE BUTTONS
            // ---------------------------------------------
            btnUpdatePlaza.Enabled = false;

            btnUpdateBooth.Enabled = false;

            btnUpdateCategory.Enabled = false;

            btnUpdateRate.Enabled = false;
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
SELECT
    PlazaID AS [Plaza ID],
    PlazaName AS [Plaza Name],
    Location,
    Status
FROM TollPlazas
ORDER BY PlazaID DESC;";

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

                dgvTollPlazas.DataSource =
                    dataTable;

                dgvTollPlazas
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode
                    .Fill;

                dgvTollPlazas
                    .SelectionMode =
                    DataGridViewSelectionMode
                    .FullRowSelect;

                dgvTollPlazas
                    .ReadOnly = true;

                dgvTollPlazas
                    .AllowUserToAddRows =
                    false;

                dgvTollPlazas
                    .AllowUserToDeleteRows =
                    false;

                dgvTollPlazas
                    .RowHeadersVisible =
                    false;

                dgvTollPlazas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll plaza records could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // ADD TOLL PLAZA
        // =================================================
        private void btnAddPlaza_Click(
            object sender,
            EventArgs e)
        {
            string plazaName =
                txtPlazaName.Text.Trim();

            string location =
                txtPlazaLocation.Text.Trim();

            string status =
                cmbPlazaStatus
                .SelectedItem
                ?.ToString()
                ?? "";

            if (string.IsNullOrWhiteSpace(
                plazaName))
            {
                MessageBox.Show(
                    "Please enter the toll plaza name.",
                    "Plaza Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPlazaName.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                location))
            {
                MessageBox.Show(
                    "Please enter the plaza location.",
                    "Location Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPlazaLocation.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                status))
            {
                MessageBox.Show(
                    "Please select the plaza status.",
                    "Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string checkQuery = @"
SELECT COUNT(*)
FROM TollPlazas
WHERE PlazaName = @PlazaName;";

                using (
                    SqlCommand checkCommand =
                    new SqlCommand(
                        checkQuery,
                        connection
                    )
                )
                {
                    checkCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaName",
                            plazaName
                        );

                    int existingCount =
                        Convert.ToInt32(
                            checkCommand
                            .ExecuteScalar()
                        );

                    if (existingCount > 0)
                    {
                        MessageBox.Show(
                            "A toll plaza with this name "
                            + "already exists.",
                            "Duplicate Plaza",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string insertQuery = @"
INSERT INTO TollPlazas
(
    PlazaName,
    Location,
    District,
    Status
)
VALUES
(
    @PlazaName,
    @Location,
    @District,
    @Status
);";

                using SqlCommand command =
                    new SqlCommand(
                        insertQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@PlazaName",
                    plazaName
                );

                command.Parameters.AddWithValue(
                    "@Location",
                    location
                );

                command.Parameters.AddWithValue(
                    "@District",
                    location
                );

                command.Parameters.AddWithValue(
                    "@Status",
                    status
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll plaza added successfully.",
                    "Plaza Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTollPlazas();

                LoadBoothPlazas();

                LoadRatePlazas();

                ClearPlazaInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll plaza could not be added.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // SELECT TOLL PLAZA
        // =================================================
        private void dgvTollPlazas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvTollPlazas.Rows[
                    e.RowIndex
                ];

            selectedPlazaId =
                Convert.ToInt32(
                    row.Cells[
                        "Plaza ID"
                    ].Value
                );

            txtPlazaName.Text =
                row.Cells[
                    "Plaza Name"
                ].Value
                ?.ToString()
                ?? "";

            txtPlazaLocation.Text =
                row.Cells[
                    "Location"
                ].Value
                ?.ToString()
                ?? "";

            string status =
                row.Cells[
                    "Status"
                ].Value
                ?.ToString()
                ?? "";

            cmbPlazaStatus.SelectedItem =
                status;

            btnUpdatePlaza.Enabled =
                true;
        }

        // =================================================
        // UPDATE TOLL PLAZA
        // =================================================
        private void btnUpdatePlaza_Click(
            object sender,
            EventArgs e)
        {
            if (selectedPlazaId == 0)
            {
                MessageBox.Show(
                    "Please select a toll plaza "
                    + "from the table first.",
                    "No Plaza Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string plazaName =
                txtPlazaName.Text.Trim();

            string location =
                txtPlazaLocation.Text.Trim();

            string status =
                cmbPlazaStatus
                .SelectedItem
                ?.ToString()
                ?? "";

            if (string.IsNullOrWhiteSpace(
                plazaName))
            {
                MessageBox.Show(
                    "Please enter the toll plaza name.",
                    "Plaza Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPlazaName.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                location))
            {
                MessageBox.Show(
                    "Please enter the plaza location.",
                    "Location Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPlazaLocation.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                status))
            {
                MessageBox.Show(
                    "Please select the plaza status.",
                    "Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string duplicateQuery = @"
SELECT COUNT(*)
FROM TollPlazas
WHERE PlazaName = @PlazaName
AND PlazaID <> @PlazaID;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaName",
                            plazaName
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaID",
                            selectedPlazaId
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "Another toll plaza already "
                            + "uses this name.",
                            "Duplicate Plaza",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string updateQuery = @"
UPDATE TollPlazas
SET
    PlazaName = @PlazaName,
    Location = @Location,
    District = @District,
    Status = @Status
WHERE PlazaID = @PlazaID;";

                using SqlCommand command =
                    new SqlCommand(
                        updateQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@PlazaName",
                    plazaName
                );

                command.Parameters.AddWithValue(
                    "@Location",
                    location
                );

                command.Parameters.AddWithValue(
                    "@District",
                    location
                );

                command.Parameters.AddWithValue(
                    "@Status",
                    status
                );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    selectedPlazaId
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll plaza updated successfully.",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTollPlazas();

                LoadBoothPlazas();

                LoadRatePlazas();

                ClearPlazaInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll plaza could not be updated.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // CLEAR PLAZA BUTTON
        // =================================================
        private void btnClearPlaza_Click(
            object sender,
            EventArgs e)
        {
            ClearPlazaInputs();
        }

        // =================================================
        // CLEAR PLAZA INPUTS
        // =================================================
        private void ClearPlazaInputs()
        {
            selectedPlazaId = 0;

            txtPlazaName.Clear();

            txtPlazaLocation.Clear();

            cmbPlazaStatus.SelectedIndex =
                0;

            btnUpdatePlaza.Enabled =
                false;

            dgvTollPlazas.ClearSelection();

            txtPlazaName.Focus();
        }

        // =================================================
        // LOAD ACTIVE PLAZAS INTO BOOTH COMBOBOX
        // =================================================
        private void LoadBoothPlazas()
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
WHERE Status = 'Active'
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

                cmbBoothPlaza.DataSource =
                    dataTable;

                cmbBoothPlaza.DisplayMember =
                    "PlazaName";

                cmbBoothPlaza.ValueMember =
                    "PlazaID";

                cmbBoothPlaza.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll plazas could not be loaded "
                    + "for the Toll Booth tab.\n\n"
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
        private void LoadTollBooths()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT
    TB.BoothID AS [Booth ID],
    TP.PlazaName AS [Toll Plaza],
    TB.BoothNumber AS [Booth Number],
    TB.BoothStatus AS [Status]
FROM TollBooths TB
INNER JOIN TollPlazas TP
ON TB.PlazaID = TP.PlazaID
ORDER BY
    TB.BoothID DESC;";

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

                dgvTollBooths.DataSource =
                    dataTable;

                dgvTollBooths
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode
                    .Fill;

                dgvTollBooths
                    .SelectionMode =
                    DataGridViewSelectionMode
                    .FullRowSelect;

                dgvTollBooths
                    .ReadOnly = true;

                dgvTollBooths
                    .AllowUserToAddRows =
                    false;

                dgvTollBooths
                    .AllowUserToDeleteRows =
                    false;

                dgvTollBooths
                    .RowHeadersVisible =
                    false;

                dgvTollBooths.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll booth records could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // ADD TOLL BOOTH
        // =================================================
        private void btnAddBooth_Click(
            object sender,
            EventArgs e)
        {
            if (cmbBoothPlaza.SelectedValue == null ||
                cmbBoothPlaza.SelectedValue
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

            string boothNumber =
                txtBoothNumber.Text.Trim();

            string boothStatus =
                cmbBoothStatus
                .SelectedItem
                ?.ToString()
                ?? "";

            if (string.IsNullOrWhiteSpace(
                boothNumber))
            {
                MessageBox.Show(
                    "Please enter the booth number.",
                    "Booth Number Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBoothNumber.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                boothStatus))
            {
                MessageBox.Show(
                    "Please select the booth status.",
                    "Booth Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                int plazaId =
                    Convert.ToInt32(
                        cmbBoothPlaza
                        .SelectedValue
                    );

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string duplicateQuery = @"
SELECT COUNT(*)
FROM TollBooths
WHERE PlazaID = @PlazaID
AND BoothNumber = @BoothNumber;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaID",
                            plazaId
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@BoothNumber",
                            boothNumber
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "This booth number already "
                            + "exists in the selected toll plaza.",
                            "Duplicate Toll Booth",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string insertQuery = @"
INSERT INTO TollBooths
(
    PlazaID,
    BoothNumber,
    BoothStatus
)
VALUES
(
    @PlazaID,
    @BoothNumber,
    @BoothStatus
);";

                using SqlCommand command =
                    new SqlCommand(
                        insertQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    plazaId
                );

                command.Parameters.AddWithValue(
                    "@BoothNumber",
                    boothNumber
                );

                command.Parameters.AddWithValue(
                    "@BoothStatus",
                    boothStatus
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll booth added successfully.",
                    "Booth Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTollBooths();

                ClearBoothInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll booth could not be added.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // SELECT TOLL BOOTH
        // =================================================
        private void dgvTollBooths_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvTollBooths.Rows[
                    e.RowIndex
                ];

            selectedBoothId =
                Convert.ToInt32(
                    row.Cells[
                        "Booth ID"
                    ].Value
                );

            string plazaName =
                row.Cells[
                    "Toll Plaza"
                ].Value
                ?.ToString()
                ?? "";

            cmbBoothPlaza.Text =
                plazaName;

            txtBoothNumber.Text =
                row.Cells[
                    "Booth Number"
                ].Value
                ?.ToString()
                ?? "";

            string boothStatus =
                row.Cells[
                    "Status"
                ].Value
                ?.ToString()
                ?? "";

            cmbBoothStatus.SelectedItem =
                boothStatus;

            btnUpdateBooth.Enabled =
                true;
        }

        // =================================================
        // UPDATE TOLL BOOTH
        // =================================================
        private void btnUpdateBooth_Click(
            object sender,
            EventArgs e)
        {
            if (selectedBoothId == 0)
            {
                MessageBox.Show(
                    "Please select a toll booth "
                    + "from the table first.",
                    "No Booth Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbBoothPlaza.SelectedValue == null ||
                cmbBoothPlaza.SelectedValue
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

            string boothNumber =
                txtBoothNumber.Text.Trim();

            string boothStatus =
                cmbBoothStatus
                .SelectedItem
                ?.ToString()
                ?? "";

            if (string.IsNullOrWhiteSpace(
                boothNumber))
            {
                MessageBox.Show(
                    "Please enter the booth number.",
                    "Booth Number Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBoothNumber.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                boothStatus))
            {
                MessageBox.Show(
                    "Please select the booth status.",
                    "Booth Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                int plazaId =
                    Convert.ToInt32(
                        cmbBoothPlaza
                        .SelectedValue
                    );

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string duplicateQuery = @"
SELECT COUNT(*)
FROM TollBooths
WHERE PlazaID = @PlazaID
AND BoothNumber = @BoothNumber
AND BoothID <> @BoothID;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaID",
                            plazaId
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@BoothNumber",
                            boothNumber
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@BoothID",
                            selectedBoothId
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "Another booth already uses "
                            + "this booth number in the "
                            + "selected toll plaza.",
                            "Duplicate Toll Booth",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string updateQuery = @"
UPDATE TollBooths
SET
    PlazaID = @PlazaID,
    BoothNumber = @BoothNumber,
    BoothStatus = @BoothStatus
WHERE BoothID = @BoothID;";

                using SqlCommand command =
                    new SqlCommand(
                        updateQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@PlazaID",
                    plazaId
                );

                command.Parameters.AddWithValue(
                    "@BoothNumber",
                    boothNumber
                );

                command.Parameters.AddWithValue(
                    "@BoothStatus",
                    boothStatus
                );

                command.Parameters.AddWithValue(
                    "@BoothID",
                    selectedBoothId
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll booth updated successfully.",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTollBooths();

                ClearBoothInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll booth could not be updated.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // CLEAR BOOTH BUTTON
        // =================================================
        private void btnClearBooth_Click(
            object sender,
            EventArgs e)
        {
            ClearBoothInputs();
        }

        // =================================================
        // CLEAR BOOTH INPUTS
        // =================================================
        private void ClearBoothInputs()
        {
            selectedBoothId = 0;

            cmbBoothPlaza.SelectedIndex =
                -1;

            txtBoothNumber.Clear();

            cmbBoothStatus.SelectedIndex =
                0;

            btnUpdateBooth.Enabled =
                false;

            dgvTollBooths.ClearSelection();

            cmbBoothPlaza.Focus();
        }

        // =================================================
        // TOLL BOOTHS TAB ENTER
        // =================================================
        private void tabTollBooths_Enter(
            object sender,
            EventArgs e)
        {
            LoadBoothPlazas();

            LoadTollBooths();

            ClearBoothInputs();
        }

        // =================================================
        // VEHICLE CATEGORIES TAB ENTER
        // =================================================
        private void tabVehicleCategories_Enter(
            object sender,
            EventArgs e)
        {
            LoadVehicleCategories();

            ClearCategoryInputs();
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
SELECT
    CategoryID AS [Category ID],
    CategoryName AS [Category Name]
FROM VehicleCategories
ORDER BY CategoryID DESC;";

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

                dgvVehicleCategories.DataSource =
                    dataTable;

                dgvVehicleCategories
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode
                    .Fill;

                dgvVehicleCategories
                    .SelectionMode =
                    DataGridViewSelectionMode
                    .FullRowSelect;

                dgvVehicleCategories
                    .ReadOnly = true;

                dgvVehicleCategories
                    .AllowUserToAddRows =
                    false;

                dgvVehicleCategories
                    .AllowUserToDeleteRows =
                    false;

                dgvVehicleCategories
                    .RowHeadersVisible =
                    false;

                dgvVehicleCategories.ClearSelection();
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
        // ADD VEHICLE CATEGORY
        // =================================================
        private void btnAddCategory_Click(
            object sender,
            EventArgs e)
        {
            string categoryName =
                txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(
                categoryName))
            {
                MessageBox.Show(
                    "Please enter the vehicle category name.",
                    "Category Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCategoryName.Focus();

                return;
            }

            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string duplicateQuery = @"
SELECT COUNT(*)
FROM VehicleCategories
WHERE CategoryName = @CategoryName;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@CategoryName",
                            categoryName
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "This vehicle category already exists.",
                            "Duplicate Category",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string insertQuery = @"
INSERT INTO VehicleCategories
(
    CategoryName
)
VALUES
(
    @CategoryName
);";

                using SqlCommand command =
                    new SqlCommand(
                        insertQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@CategoryName",
                    categoryName
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Vehicle category added successfully.",
                    "Category Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadVehicleCategories();

                LoadRateCategories();

                ClearCategoryInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The vehicle category could not be added.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // SELECT VEHICLE CATEGORY
        // =================================================
        private void dgvVehicleCategories_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvVehicleCategories.Rows[
                    e.RowIndex
                ];

            selectedCategoryId =
                Convert.ToInt32(
                    row.Cells[
                        "Category ID"
                    ].Value
                );

            txtCategoryName.Text =
                row.Cells[
                    "Category Name"
                ].Value
                ?.ToString()
                ?? "";

            btnUpdateCategory.Enabled =
                true;
        }

        // =================================================
        // UPDATE VEHICLE CATEGORY
        // =================================================
        private void btnUpdateCategory_Click(
            object sender,
            EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show(
                    "Please select a vehicle category "
                    + "from the table first.",
                    "No Category Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string categoryName =
                txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(
                categoryName))
            {
                MessageBox.Show(
                    "Please enter the vehicle category name.",
                    "Category Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCategoryName.Focus();

                return;
            }

            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string duplicateQuery = @"
SELECT COUNT(*)
FROM VehicleCategories
WHERE CategoryName = @CategoryName
AND CategoryID <> @CategoryID;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@CategoryName",
                            categoryName
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@CategoryID",
                            selectedCategoryId
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "Another vehicle category "
                            + "already uses this name.",
                            "Duplicate Category",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string updateQuery = @"
UPDATE VehicleCategories
SET
    CategoryName = @CategoryName
WHERE CategoryID = @CategoryID;";

                using SqlCommand command =
                    new SqlCommand(
                        updateQuery,
                        connection
                    );

                command.Parameters.AddWithValue(
                    "@CategoryName",
                    categoryName
                );

                command.Parameters.AddWithValue(
                    "@CategoryID",
                    selectedCategoryId
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Vehicle category updated successfully.",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadVehicleCategories();

                LoadRateCategories();

                ClearCategoryInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The vehicle category could not be updated.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // CLEAR CATEGORY BUTTON
        // =================================================
        private void btnClearCategory_Click(
            object sender,
            EventArgs e)
        {
            ClearCategoryInputs();
        }

        // =================================================
        // CLEAR CATEGORY INPUTS
        // =================================================
        private void ClearCategoryInputs()
        {
            selectedCategoryId = 0;

            txtCategoryName.Clear();

            btnUpdateCategory.Enabled =
                false;

            dgvVehicleCategories.ClearSelection();

            txtCategoryName.Focus();
        }

        // =================================================
        // TOLL RATES TAB ENTER
        // =================================================
        private void tabTollRates_Enter(
            object sender,
            EventArgs e)
        {
            LoadRatePlazas();

            LoadRateCategories();

            LoadTollRates();

            ClearRateInputs();
        }

        // =================================================
        // LOAD ACTIVE PLAZAS INTO RATE COMBOBOX
        // =================================================
        private void LoadRatePlazas()
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
WHERE Status = 'Active'
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

                cmbRatePlaza.DataSource =
                    dataTable;

                cmbRatePlaza.DisplayMember =
                    "PlazaName";

                cmbRatePlaza.ValueMember =
                    "PlazaID";

                cmbRatePlaza.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll plazas could not be loaded "
                    + "for the Toll Rates tab.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD VEHICLE CATEGORIES INTO RATE COMBOBOX
        // =================================================
        private void LoadRateCategories()
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

                cmbRateCategory.DataSource =
                    dataTable;

                cmbRateCategory.DisplayMember =
                    "CategoryName";

                cmbRateCategory.ValueMember =
                    "CategoryID";

                cmbRateCategory.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Vehicle categories could not be "
                    + "loaded for the Toll Rates tab.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // LOAD TOLL RATES
        // =================================================
        private void LoadTollRates()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                string query = @"
SELECT
    TR.TollRateID AS [Rate ID],
    TP.PlazaName AS [Toll Plaza],
    VC.CategoryName AS [Vehicle Category],
    TR.TollAmount AS [Toll Amount],
    TR.EffectiveDate AS [Effective Date],
    TR.RateStatus AS [Status]
FROM TollRates TR
INNER JOIN TollPlazas TP
ON TR.PlazaID = TP.PlazaID
INNER JOIN VehicleCategories VC
ON TR.CategoryID = VC.CategoryID
ORDER BY
    TR.TollRateID DESC;";

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

                dgvTollRates.DataSource =
                    dataTable;

                dgvTollRates
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode
                    .Fill;

                dgvTollRates
                    .SelectionMode =
                    DataGridViewSelectionMode
                    .FullRowSelect;

                dgvTollRates
                    .ReadOnly = true;

                dgvTollRates
                    .AllowUserToAddRows =
                    false;

                dgvTollRates
                    .AllowUserToDeleteRows =
                    false;

                dgvTollRates
                    .RowHeadersVisible =
                    false;

                dgvTollRates.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Toll rate records could not be loaded.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // ADD TOLL RATE
        // =================================================
        private void btnAddRate_Click(
            object sender,
            EventArgs e)
        {
            // Validate toll plaza
            if (cmbRatePlaza.SelectedValue == null ||
                cmbRatePlaza.SelectedValue
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

            // Validate vehicle category
            if (cmbRateCategory.SelectedValue == null ||
                cmbRateCategory.SelectedValue
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

            // Validate toll amount
            if (!decimal.TryParse(
                txtTollAmount.Text.Trim(),
                out decimal tollAmount))
            {
                MessageBox.Show(
                    "Please enter a valid toll amount.",
                    "Invalid Toll Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTollAmount.Focus();

                return;
            }

            if (tollAmount < 0)
            {
                MessageBox.Show(
                    "Toll amount cannot be negative.",
                    "Invalid Toll Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTollAmount.Focus();

                return;
            }

            try
            {
                int plazaId =
                    Convert.ToInt32(
                        cmbRatePlaza
                        .SelectedValue
                    );

                int categoryId =
                    Convert.ToInt32(
                        cmbRateCategory
                        .SelectedValue
                    );

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                // One rate per plaza and category
                string duplicateQuery = @"
SELECT COUNT(*)
FROM TollRates
WHERE PlazaID = @PlazaID
AND CategoryID = @CategoryID;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaID",
                            plazaId
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@CategoryID",
                            categoryId
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "A toll rate already exists "
                            + "for this toll plaza and "
                            + "vehicle category.",
                            "Duplicate Toll Rate",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string insertQuery = @"
INSERT INTO TollRates
(
    PlazaID,
    CategoryID,
    TollAmount,
    EffectiveDate,
    RateStatus
)
VALUES
(
    @PlazaID,
    @CategoryID,
    @TollAmount,
    @EffectiveDate,
    @RateStatus
);";

                using SqlCommand command =
                    new SqlCommand(
                        insertQuery,
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

                command.Parameters.AddWithValue(
                    "@TollAmount",
                    tollAmount
                );

                // Current date is used automatically
                command.Parameters.AddWithValue(
                    "@EffectiveDate",
                    DateTime.Now
                );

                // New rates are active by default
               command.Parameters.AddWithValue(
    "@RateStatus",
    cmbRateStatus.SelectedItem?.ToString() ?? "Active"
);

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll rate added successfully.",
                    "Rate Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTollRates();

                ClearRateInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll rate could not be added.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // SELECT TOLL RATE
        // =================================================
        private void dgvTollRates_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvTollRates.Rows[
                    e.RowIndex
                ];

            selectedRateId =
                Convert.ToInt32(
                    row.Cells[
                        "Rate ID"
                    ].Value
                );

            string plazaName =
                row.Cells[
                    "Toll Plaza"
                ].Value
                ?.ToString()
                ?? "";

            string categoryName =
                row.Cells[
                    "Vehicle Category"
                ].Value
                ?.ToString()
                ?? "";

            cmbRatePlaza.Text =
                plazaName;

            cmbRateCategory.Text =
                categoryName;

            txtTollAmount.Text =
                Convert.ToDecimal(
                    row.Cells[
                        "Toll Amount"
                    ].Value
                ).ToString(
                    "0.00"
                );

            string rateStatus =
    row.Cells[
        "Status"
    ].Value
    ?.ToString()
    ?? "";

            cmbRateStatus.SelectedItem =
                rateStatus;

            btnUpdateRate.Enabled =
                true;
        }

        // =================================================
        // UPDATE TOLL RATE
        // =================================================
        private void btnUpdateRate_Click(
            object sender,
            EventArgs e)
        {
            if (selectedRateId == 0)
            {
                MessageBox.Show(
                    "Please select a toll rate "
                    + "from the table first.",
                    "No Toll Rate Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validate toll plaza
            if (cmbRatePlaza.SelectedValue == null ||
                cmbRatePlaza.SelectedValue
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

            // Validate vehicle category
            if (cmbRateCategory.SelectedValue == null ||
                cmbRateCategory.SelectedValue
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

            // Validate toll amount
            if (!decimal.TryParse(
                txtTollAmount.Text.Trim(),
                out decimal tollAmount))
            {
                MessageBox.Show(
                    "Please enter a valid toll amount.",
                    "Invalid Toll Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTollAmount.Focus();

                return;
            }

            if (tollAmount < 0)
            {
                MessageBox.Show(
                    "Toll amount cannot be negative.",
                    "Invalid Toll Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTollAmount.Focus();

                return;
            }

            try
            {
                int plazaId =
                    Convert.ToInt32(
                        cmbRatePlaza
                        .SelectedValue
                    );

                int categoryId =
                    Convert.ToInt32(
                        cmbRateCategory
                        .SelectedValue
                    );

                using SqlConnection connection =
                    DatabaseHelper.GetConnection();

                connection.Open();

                // Check duplicate combination
                // excluding the selected rate
                string duplicateQuery = @"
SELECT COUNT(*)
FROM TollRates
WHERE PlazaID = @PlazaID
AND CategoryID = @CategoryID
AND TollRateID <> @TollRateID;";

                using (
                    SqlCommand duplicateCommand =
                    new SqlCommand(
                        duplicateQuery,
                        connection
                    )
                )
                {
                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@PlazaID",
                            plazaId
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@CategoryID",
                            categoryId
                        );

                    duplicateCommand
                        .Parameters
                        .AddWithValue(
                            "@TollRateID",
                            selectedRateId
                        );

                    int duplicateCount =
                        Convert.ToInt32(
                            duplicateCommand
                            .ExecuteScalar()
                        );

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show(
                            "Another toll rate already exists "
                            + "for this toll plaza and "
                            + "vehicle category.",
                            "Duplicate Toll Rate",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string updateQuery = @"
UPDATE TollRates
SET
    PlazaID = @PlazaID,
    CategoryID = @CategoryID,
    TollAmount = @TollAmount,
    EffectiveDate = @EffectiveDate,
    RateStatus = @RateStatus
WHERE TollRateID = @TollRateID;";

                using SqlCommand command =
                    new SqlCommand(
                        updateQuery,
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

                command.Parameters.AddWithValue(
                    "@TollAmount",
                    tollAmount
                );

                command.Parameters.AddWithValue(
                    "@EffectiveDate",
                    DateTime.Now
                );

                command.Parameters.AddWithValue(
      "@RateStatus",
      cmbRateStatus.SelectedItem?.ToString() ?? "Active"
  );

                command.Parameters.AddWithValue(
                    "@TollRateID",
                    selectedRateId
                );

                command.ExecuteNonQuery();

                MessageBox.Show(
                    "Toll rate updated successfully.",
                    "Update Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTollRates();

                ClearRateInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The toll rate could not be updated.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // CLEAR RATE BUTTON
        // =================================================
        private void btnClearRate_Click(
            object sender,
            EventArgs e)
        {
            ClearRateInputs();
        }

        // =================================================
        // CLEAR RATE INPUTS
        // =================================================
        private void ClearRateInputs()
        {
            selectedRateId = 0;

            cmbRatePlaza.SelectedIndex =
                -1;

            cmbRateCategory.SelectedIndex =
                -1;

            txtTollAmount.Clear();

            cmbRateStatus.SelectedIndex =
                0;

            btnUpdateRate.Enabled =
                false;

            dgvTollRates.ClearSelection();

            cmbRatePlaza.Focus();
        }
    }
}