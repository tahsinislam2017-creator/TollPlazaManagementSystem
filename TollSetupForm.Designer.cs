namespace TollPlazaManagementSystem
{
    partial class TollSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabTollSetup = new TabControl();
            tabTollPlazas = new TabPage();
            dgvTollPlazas = new DataGridView();
            pnlPlazaInput = new Panel();
            btnClearPlaza = new Button();
            btnUpdatePlaza = new Button();
            btnAddPlaza = new Button();
            cmbPlazaStatus = new ComboBox();
            lblPlazaStatus = new Label();
            txtPlazaLocation = new TextBox();
            lblPlazaLocation = new Label();
            txtPlazaName = new TextBox();
            lblPlazaName = new Label();
            lblPlazaTitle = new Label();
            tabTollBooths = new TabPage();
            dgvTollBooths = new DataGridView();
            pnlBoothInput = new Panel();
            btnClearBooth = new Button();
            btnUpdateBooth = new Button();
            btnAddBooth = new Button();
            cmbBoothStatus = new ComboBox();
            lblBoothStatus = new Label();
            txtBoothNumber = new TextBox();
            lblBoothNumber = new Label();
            cmbBoothPlaza = new ComboBox();
            lblBoothPlaza = new Label();
            lblBoothTitle = new Label();
            tabVehicleCategories = new TabPage();
            dgvVehicleCategories = new DataGridView();
            btnClearCategory = new Button();
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            txtCategoryDescription = new TextBox();
            lblCategoryDescription = new Label();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            lblvehiclecategotymanagement = new Label();
            tabTollRates = new TabPage();
            dgvTollRates = new DataGridView();
            btnClearRate = new Button();
            btnUpdateRate = new Button();
            btnAddRate = new Button();
            cmbRateStatus = new ComboBox();
            lblRateStatus = new Label();
            dtpEffectiveDate = new DateTimePicker();
            lblEffectiveDate = new Label();
            txtTollAmount = new TextBox();
            lblTollAmount = new Label();
            cmbRateCategory = new ComboBox();
            lblVehicleCategory = new Label();
            cmbRatePlaza = new ComboBox();
            lblTollPlaza = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabTollSetup.SuspendLayout();
            tabTollPlazas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTollPlazas).BeginInit();
            pnlPlazaInput.SuspendLayout();
            tabTollBooths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTollBooths).BeginInit();
            pnlBoothInput.SuspendLayout();
            tabVehicleCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleCategories).BeginInit();
            tabTollRates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTollRates).BeginInit();
            SuspendLayout();
            // 
            // tabTollSetup
            // 
            tabTollSetup.Controls.Add(tabTollPlazas);
            tabTollSetup.Controls.Add(tabTollBooths);
            tabTollSetup.Controls.Add(tabVehicleCategories);
            tabTollSetup.Controls.Add(tabTollRates);
            tabTollSetup.Dock = DockStyle.Fill;
            tabTollSetup.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabTollSetup.Location = new Point(0, 0);
            tabTollSetup.Name = "tabTollSetup";
            tabTollSetup.SelectedIndex = 0;
            tabTollSetup.Size = new Size(800, 544);
            tabTollSetup.TabIndex = 0;
            tabTollSetup.Enter += tabTollBooths_Enter;
            // 
            // tabTollPlazas
            // 
            tabTollPlazas.BackColor = Color.LightGray;
            tabTollPlazas.Controls.Add(dgvTollPlazas);
            tabTollPlazas.Controls.Add(pnlPlazaInput);
            tabTollPlazas.Controls.Add(lblPlazaTitle);
            tabTollPlazas.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabTollPlazas.Location = new Point(4, 32);
            tabTollPlazas.Name = "tabTollPlazas";
            tabTollPlazas.Padding = new Padding(3);
            tabTollPlazas.Size = new Size(792, 508);
            tabTollPlazas.TabIndex = 0;
            tabTollPlazas.Text = "Toll Plazas";
            // 
            // dgvTollPlazas
            // 
            dgvTollPlazas.AllowUserToAddRows = false;
            dgvTollPlazas.AllowUserToDeleteRows = false;
            dgvTollPlazas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTollPlazas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTollPlazas.Location = new Point(360, 33);
            dgvTollPlazas.MultiSelect = false;
            dgvTollPlazas.Name = "dgvTollPlazas";
            dgvTollPlazas.ReadOnly = true;
            dgvTollPlazas.RowHeadersWidth = 62;
            dgvTollPlazas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTollPlazas.Size = new Size(432, 472);
            dgvTollPlazas.TabIndex = 2;
            dgvTollPlazas.CellClick += dgvTollPlazas_CellClick;
            // 
            // pnlPlazaInput
            // 
            pnlPlazaInput.BorderStyle = BorderStyle.FixedSingle;
            pnlPlazaInput.Controls.Add(btnClearPlaza);
            pnlPlazaInput.Controls.Add(btnUpdatePlaza);
            pnlPlazaInput.Controls.Add(btnAddPlaza);
            pnlPlazaInput.Controls.Add(cmbPlazaStatus);
            pnlPlazaInput.Controls.Add(lblPlazaStatus);
            pnlPlazaInput.Controls.Add(txtPlazaLocation);
            pnlPlazaInput.Controls.Add(lblPlazaLocation);
            pnlPlazaInput.Controls.Add(txtPlazaName);
            pnlPlazaInput.Controls.Add(lblPlazaName);
            pnlPlazaInput.Location = new Point(8, 29);
            pnlPlazaInput.Name = "pnlPlazaInput";
            pnlPlazaInput.Size = new Size(350, 476);
            pnlPlazaInput.TabIndex = 1;
            // 
            // btnClearPlaza
            // 
            btnClearPlaza.BackColor = Color.MediumPurple;
            btnClearPlaza.Location = new Point(-1, 410);
            btnClearPlaza.Name = "btnClearPlaza";
            btnClearPlaza.Size = new Size(169, 34);
            btnClearPlaza.TabIndex = 8;
            btnClearPlaza.Text = "CLEAR";
            btnClearPlaza.UseVisualStyleBackColor = false;
            btnClearPlaza.Click += btnClearPlaza_Click;
            // 
            // btnUpdatePlaza
            // 
            btnUpdatePlaza.BackColor = Color.Yellow;
            btnUpdatePlaza.Location = new Point(-1, 337);
            btnUpdatePlaza.Name = "btnUpdatePlaza";
            btnUpdatePlaza.Size = new Size(237, 34);
            btnUpdatePlaza.TabIndex = 7;
            btnUpdatePlaza.Text = "UPDATE PLAZA";
            btnUpdatePlaza.UseVisualStyleBackColor = false;
            btnUpdatePlaza.Click += btnUpdatePlaza_Click;
            // 
            // btnAddPlaza
            // 
            btnAddPlaza.BackColor = Color.OrangeRed;
            btnAddPlaza.Location = new Point(3, 260);
            btnAddPlaza.Name = "btnAddPlaza";
            btnAddPlaza.Size = new Size(169, 34);
            btnAddPlaza.TabIndex = 6;
            btnAddPlaza.Text = "ADD PLAZA";
            btnAddPlaza.UseVisualStyleBackColor = false;
            btnAddPlaza.Click += btnAddPlaza_Click;
            // 
            // cmbPlazaStatus
            // 
            cmbPlazaStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlazaStatus.FormattingEnabled = true;
            cmbPlazaStatus.Location = new Point(3, 192);
            cmbPlazaStatus.Name = "cmbPlazaStatus";
            cmbPlazaStatus.Size = new Size(312, 31);
            cmbPlazaStatus.TabIndex = 5;
            // 
            // lblPlazaStatus
            // 
            lblPlazaStatus.AutoSize = true;
            lblPlazaStatus.BackColor = Color.Aqua;
            lblPlazaStatus.Location = new Point(3, 155);
            lblPlazaStatus.Name = "lblPlazaStatus";
            lblPlazaStatus.Size = new Size(78, 23);
            lblPlazaStatus.TabIndex = 4;
            lblPlazaStatus.Text = "Status:";
            // 
            // txtPlazaLocation
            // 
            txtPlazaLocation.Location = new Point(-1, 103);
            txtPlazaLocation.Name = "txtPlazaLocation";
            txtPlazaLocation.Size = new Size(346, 31);
            txtPlazaLocation.TabIndex = 3;
            // 
            // lblPlazaLocation
            // 
            lblPlazaLocation.AutoSize = true;
            lblPlazaLocation.BackColor = Color.Aqua;
            lblPlazaLocation.Location = new Point(3, 77);
            lblPlazaLocation.Name = "lblPlazaLocation";
            lblPlazaLocation.Size = new Size(100, 23);
            lblPlazaLocation.TabIndex = 2;
            lblPlazaLocation.Text = "Location:";
            // 
            // txtPlazaName
            // 
            txtPlazaName.Location = new Point(3, 26);
            txtPlazaName.Name = "txtPlazaName";
            txtPlazaName.Size = new Size(346, 31);
            txtPlazaName.TabIndex = 1;
            // 
            // lblPlazaName
            // 
            lblPlazaName.AutoSize = true;
            lblPlazaName.BackColor = Color.Aqua;
            lblPlazaName.Location = new Point(3, 0);
            lblPlazaName.Name = "lblPlazaName";
            lblPlazaName.Size = new Size(130, 23);
            lblPlazaName.TabIndex = 0;
            lblPlazaName.Text = "Plaza Name:";
            // 
            // lblPlazaTitle
            // 
            lblPlazaTitle.AutoSize = true;
            lblPlazaTitle.BackColor = Color.Red;
            lblPlazaTitle.Location = new Point(246, 3);
            lblPlazaTitle.Name = "lblPlazaTitle";
            lblPlazaTitle.Size = new Size(286, 23);
            lblPlazaTitle.TabIndex = 0;
            lblPlazaTitle.Text = "TOLL PLAZA MANAGEMENT";
            lblPlazaTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabTollBooths
            // 
            tabTollBooths.BackColor = Color.PapayaWhip;
            tabTollBooths.Controls.Add(dgvTollBooths);
            tabTollBooths.Controls.Add(pnlBoothInput);
            tabTollBooths.Controls.Add(lblBoothTitle);
            tabTollBooths.Location = new Point(4, 32);
            tabTollBooths.Name = "tabTollBooths";
            tabTollBooths.Padding = new Padding(3);
            tabTollBooths.Size = new Size(792, 508);
            tabTollBooths.TabIndex = 1;
            tabTollBooths.Text = "Toll Booths";
            // 
            // dgvTollBooths
            // 
            dgvTollBooths.AllowUserToAddRows = false;
            dgvTollBooths.AllowUserToDeleteRows = false;
            dgvTollBooths.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTollBooths.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTollBooths.Location = new Point(373, 29);
            dgvTollBooths.MultiSelect = false;
            dgvTollBooths.Name = "dgvTollBooths";
            dgvTollBooths.ReadOnly = true;
            dgvTollBooths.RowHeadersWidth = 62;
            dgvTollBooths.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTollBooths.Size = new Size(416, 471);
            dgvTollBooths.TabIndex = 2;
            dgvTollBooths.CellClick += dgvTollBooths_CellClick;
            // 
            // pnlBoothInput
            // 
            pnlBoothInput.BackColor = Color.PaleGreen;
            pnlBoothInput.BorderStyle = BorderStyle.FixedSingle;
            pnlBoothInput.Controls.Add(btnClearBooth);
            pnlBoothInput.Controls.Add(btnUpdateBooth);
            pnlBoothInput.Controls.Add(btnAddBooth);
            pnlBoothInput.Controls.Add(cmbBoothStatus);
            pnlBoothInput.Controls.Add(lblBoothStatus);
            pnlBoothInput.Controls.Add(txtBoothNumber);
            pnlBoothInput.Controls.Add(lblBoothNumber);
            pnlBoothInput.Controls.Add(cmbBoothPlaza);
            pnlBoothInput.Controls.Add(lblBoothPlaza);
            pnlBoothInput.Location = new Point(6, 29);
            pnlBoothInput.Name = "pnlBoothInput";
            pnlBoothInput.Size = new Size(361, 471);
            pnlBoothInput.TabIndex = 1;
            // 
            // btnClearBooth
            // 
            btnClearBooth.BackColor = Color.Blue;
            btnClearBooth.Location = new Point(3, 308);
            btnClearBooth.Name = "btnClearBooth";
            btnClearBooth.Size = new Size(193, 34);
            btnClearBooth.TabIndex = 8;
            btnClearBooth.Text = "CLEAR";
            btnClearBooth.UseVisualStyleBackColor = false;
            btnClearBooth.Click += btnClearBooth_Click;
            // 
            // btnUpdateBooth
            // 
            btnUpdateBooth.BackColor = Color.Aqua;
            btnUpdateBooth.Location = new Point(3, 240);
            btnUpdateBooth.Name = "btnUpdateBooth";
            btnUpdateBooth.Size = new Size(193, 34);
            btnUpdateBooth.TabIndex = 7;
            btnUpdateBooth.Text = "UPDATE BOOTH";
            btnUpdateBooth.UseVisualStyleBackColor = false;
            btnUpdateBooth.Click += btnUpdateBooth_Click;
            // 
            // btnAddBooth
            // 
            btnAddBooth.BackColor = Color.Red;
            btnAddBooth.Location = new Point(3, 177);
            btnAddBooth.Name = "btnAddBooth";
            btnAddBooth.Size = new Size(159, 34);
            btnAddBooth.TabIndex = 6;
            btnAddBooth.Text = "ADD BOOTH";
            btnAddBooth.UseVisualStyleBackColor = false;
            btnAddBooth.Click += btnAddBooth_Click;
            // 
            // cmbBoothStatus
            // 
            cmbBoothStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoothStatus.FormattingEnabled = true;
            cmbBoothStatus.Location = new Point(93, 116);
            cmbBoothStatus.Name = "cmbBoothStatus";
            cmbBoothStatus.Size = new Size(231, 31);
            cmbBoothStatus.TabIndex = 5;
            // 
            // lblBoothStatus
            // 
            lblBoothStatus.AutoSize = true;
            lblBoothStatus.BackColor = Color.FromArgb(255, 255, 128);
            lblBoothStatus.Location = new Point(-1, 119);
            lblBoothStatus.Name = "lblBoothStatus";
            lblBoothStatus.Size = new Size(78, 23);
            lblBoothStatus.TabIndex = 4;
            lblBoothStatus.Text = "Status:";
            // 
            // txtBoothNumber
            // 
            txtBoothNumber.Location = new Point(166, 57);
            txtBoothNumber.Name = "txtBoothNumber";
            txtBoothNumber.Size = new Size(190, 31);
            txtBoothNumber.TabIndex = 3;
            // 
            // lblBoothNumber
            // 
            lblBoothNumber.AutoSize = true;
            lblBoothNumber.BackColor = Color.FromArgb(255, 255, 128);
            lblBoothNumber.Location = new Point(3, 65);
            lblBoothNumber.Name = "lblBoothNumber";
            lblBoothNumber.Size = new Size(157, 23);
            lblBoothNumber.TabIndex = 2;
            lblBoothNumber.Text = "Booth Number:";
            // 
            // cmbBoothPlaza
            // 
            cmbBoothPlaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoothPlaza.FormattingEnabled = true;
            cmbBoothPlaza.Location = new Point(113, 11);
            cmbBoothPlaza.Name = "cmbBoothPlaza";
            cmbBoothPlaza.Size = new Size(231, 31);
            cmbBoothPlaza.TabIndex = 1;
            // 
            // lblBoothPlaza
            // 
            lblBoothPlaza.AutoSize = true;
            lblBoothPlaza.BackColor = Color.FromArgb(255, 255, 128);
            lblBoothPlaza.Location = new Point(-1, 11);
            lblBoothPlaza.Name = "lblBoothPlaza";
            lblBoothPlaza.Size = new Size(108, 23);
            lblBoothPlaza.TabIndex = 0;
            lblBoothPlaza.Text = "Toll Plaza:";
            // 
            // lblBoothTitle
            // 
            lblBoothTitle.AutoSize = true;
            lblBoothTitle.BackColor = Color.FromArgb(0, 192, 0);
            lblBoothTitle.Location = new Point(245, 3);
            lblBoothTitle.Name = "lblBoothTitle";
            lblBoothTitle.Size = new Size(294, 23);
            lblBoothTitle.TabIndex = 0;
            lblBoothTitle.Text = "TOLL BOOTH MANAGEMENT";
            // 
            // tabVehicleCategories
            // 
            tabVehicleCategories.BackColor = Color.Khaki;
            tabVehicleCategories.Controls.Add(dgvVehicleCategories);
            tabVehicleCategories.Controls.Add(btnClearCategory);
            tabVehicleCategories.Controls.Add(btnUpdateCategory);
            tabVehicleCategories.Controls.Add(btnAddCategory);
            tabVehicleCategories.Controls.Add(txtCategoryDescription);
            tabVehicleCategories.Controls.Add(lblCategoryDescription);
            tabVehicleCategories.Controls.Add(txtCategoryName);
            tabVehicleCategories.Controls.Add(lblCategoryName);
            tabVehicleCategories.Controls.Add(lblvehiclecategotymanagement);
            tabVehicleCategories.Location = new Point(4, 32);
            tabVehicleCategories.Name = "tabVehicleCategories";
            tabVehicleCategories.Size = new Size(792, 508);
            tabVehicleCategories.TabIndex = 2;
            tabVehicleCategories.Text = "Vehicle Categories";
            tabVehicleCategories.Enter += tabVehicleCategories_Enter;
            // 
            // dgvVehicleCategories
            // 
            dgvVehicleCategories.AllowUserToAddRows = false;
            dgvVehicleCategories.AllowUserToDeleteRows = false;
            dgvVehicleCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicleCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleCategories.Location = new Point(3, 208);
            dgvVehicleCategories.MultiSelect = false;
            dgvVehicleCategories.Name = "dgvVehicleCategories";
            dgvVehicleCategories.ReadOnly = true;
            dgvVehicleCategories.RowHeadersVisible = false;
            dgvVehicleCategories.RowHeadersWidth = 62;
            dgvVehicleCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicleCategories.Size = new Size(781, 292);
            dgvVehicleCategories.TabIndex = 8;
            dgvVehicleCategories.CellClick += dgvVehicleCategories_CellClick;
            // 
            // btnClearCategory
            // 
            btnClearCategory.BackColor = Color.MediumOrchid;
            btnClearCategory.Location = new Point(537, 156);
            btnClearCategory.Name = "btnClearCategory";
            btnClearCategory.Size = new Size(197, 34);
            btnClearCategory.TabIndex = 7;
            btnClearCategory.Text = "Clear";
            btnClearCategory.UseVisualStyleBackColor = false;
            btnClearCategory.Click += btnClearCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.BackColor = Color.MediumOrchid;
            btnUpdateCategory.Location = new Point(272, 156);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(197, 34);
            btnUpdateCategory.TabIndex = 6;
            btnUpdateCategory.Text = "Update Category";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.DeepPink;
            btnAddCategory.Location = new Point(22, 156);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(164, 34);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(195, 105);
            txtCategoryDescription.Multiline = true;
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(539, 31);
            txtCategoryDescription.TabIndex = 4;
            // 
            // lblCategoryDescription
            // 
            lblCategoryDescription.AutoSize = true;
            lblCategoryDescription.BackColor = Color.Orange;
            lblCategoryDescription.Location = new Point(8, 105);
            lblCategoryDescription.Name = "lblCategoryDescription";
            lblCategoryDescription.Size = new Size(129, 23);
            lblCategoryDescription.TabIndex = 3;
            lblCategoryDescription.Text = "Description:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(195, 48);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(539, 31);
            txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.BackColor = Color.Orange;
            lblCategoryName.Location = new Point(8, 51);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(169, 23);
            lblCategoryName.TabIndex = 1;
            lblCategoryName.Text = "Category Name:";
            // 
            // lblvehiclecategotymanagement
            // 
            lblvehiclecategotymanagement.AutoSize = true;
            lblvehiclecategotymanagement.BackColor = Color.DarkCyan;
            lblvehiclecategotymanagement.Location = new Point(219, 9);
            lblvehiclecategotymanagement.Name = "lblvehiclecategotymanagement";
            lblvehiclecategotymanagement.Size = new Size(310, 23);
            lblvehiclecategotymanagement.TabIndex = 0;
            lblvehiclecategotymanagement.Text = "Vehicle Category Management";
            // 
            // tabTollRates
            // 
            tabTollRates.BackColor = Color.YellowGreen;
            tabTollRates.Controls.Add(dgvTollRates);
            tabTollRates.Controls.Add(btnClearRate);
            tabTollRates.Controls.Add(btnUpdateRate);
            tabTollRates.Controls.Add(btnAddRate);
            tabTollRates.Controls.Add(cmbRateStatus);
            tabTollRates.Controls.Add(lblRateStatus);
            tabTollRates.Controls.Add(dtpEffectiveDate);
            tabTollRates.Controls.Add(lblEffectiveDate);
            tabTollRates.Controls.Add(txtTollAmount);
            tabTollRates.Controls.Add(lblTollAmount);
            tabTollRates.Controls.Add(cmbRateCategory);
            tabTollRates.Controls.Add(lblVehicleCategory);
            tabTollRates.Controls.Add(cmbRatePlaza);
            tabTollRates.Controls.Add(lblTollPlaza);
            tabTollRates.Location = new Point(4, 32);
            tabTollRates.Name = "tabTollRates";
            tabTollRates.Size = new Size(792, 508);
            tabTollRates.TabIndex = 3;
            tabTollRates.Text = "Toll Rates";
            tabTollRates.Enter += tabTollRates_Enter;
            // 
            // dgvTollRates
            // 
            dgvTollRates.AllowUserToAddRows = false;
            dgvTollRates.AllowUserToDeleteRows = false;
            dgvTollRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTollRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTollRates.Location = new Point(3, 201);
            dgvTollRates.Name = "dgvTollRates";
            dgvTollRates.ReadOnly = true;
            dgvTollRates.RowHeadersVisible = false;
            dgvTollRates.RowHeadersWidth = 62;
            dgvTollRates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTollRates.Size = new Size(786, 299);
            dgvTollRates.TabIndex = 13;
            dgvTollRates.CellClick += dgvTollRates_CellClick;
            // 
            // btnClearRate
            // 
            btnClearRate.BackColor = Color.Gold;
            btnClearRate.Location = new Point(473, 161);
            btnClearRate.Name = "btnClearRate";
            btnClearRate.Size = new Size(112, 34);
            btnClearRate.TabIndex = 12;
            btnClearRate.Text = "Clear";
            btnClearRate.UseVisualStyleBackColor = false;
            btnClearRate.Click += btnClearRate_Click;
            // 
            // btnUpdateRate
            // 
            btnUpdateRate.BackColor = Color.Orange;
            btnUpdateRate.Location = new Point(254, 161);
            btnUpdateRate.Name = "btnUpdateRate";
            btnUpdateRate.Size = new Size(181, 34);
            btnUpdateRate.TabIndex = 11;
            btnUpdateRate.Text = "Update Rate";
            btnUpdateRate.UseVisualStyleBackColor = false;
            btnUpdateRate.Click += btnUpdateRate_Click;
            // 
            // btnAddRate
            // 
            btnAddRate.BackColor = Color.Orchid;
            btnAddRate.Location = new Point(113, 161);
            btnAddRate.Name = "btnAddRate";
            btnAddRate.Size = new Size(112, 34);
            btnAddRate.TabIndex = 10;
            btnAddRate.Text = "Add Rate";
            btnAddRate.UseVisualStyleBackColor = false;
            btnAddRate.Click += btnAddRate_Click;
            // 
            // cmbRateStatus
            // 
            cmbRateStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRateStatus.FormattingEnabled = true;
            cmbRateStatus.Items.AddRange(new object[] { "Active ", "Inactive" });
            cmbRateStatus.Location = new Point(145, 115);
            cmbRateStatus.Name = "cmbRateStatus";
            cmbRateStatus.Size = new Size(209, 31);
            cmbRateStatus.TabIndex = 9;
            // 
            // lblRateStatus
            // 
            lblRateStatus.AutoSize = true;
            lblRateStatus.BackColor = Color.FromArgb(255, 255, 128);
            lblRateStatus.Location = new Point(8, 118);
            lblRateStatus.Name = "lblRateStatus";
            lblRateStatus.Size = new Size(128, 23);
            lblRateStatus.TabIndex = 8;
            lblRateStatus.Text = "Rate Status:";
            // 
            // dtpEffectiveDate
            // 
            dtpEffectiveDate.Format = DateTimePickerFormat.Short;
            dtpEffectiveDate.Location = new Point(496, 61);
            dtpEffectiveDate.Name = "dtpEffectiveDate";
            dtpEffectiveDate.Size = new Size(300, 31);
            dtpEffectiveDate.TabIndex = 7;
            // 
            // lblEffectiveDate
            // 
            lblEffectiveDate.AutoSize = true;
            lblEffectiveDate.BackColor = Color.FromArgb(255, 255, 128);
            lblEffectiveDate.Location = new Point(337, 64);
            lblEffectiveDate.Name = "lblEffectiveDate";
            lblEffectiveDate.Size = new Size(153, 23);
            lblEffectiveDate.TabIndex = 6;
            lblEffectiveDate.Text = "Effective Date:";
            // 
            // txtTollAmount
            // 
            txtTollAmount.Location = new Point(145, 61);
            txtTollAmount.Name = "txtTollAmount";
            txtTollAmount.Size = new Size(186, 31);
            txtTollAmount.TabIndex = 5;
            txtTollAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTollAmount
            // 
            lblTollAmount.AutoSize = true;
            lblTollAmount.BackColor = Color.FromArgb(255, 255, 128);
            lblTollAmount.Location = new Point(8, 64);
            lblTollAmount.Name = "lblTollAmount";
            lblTollAmount.Size = new Size(131, 23);
            lblTollAmount.TabIndex = 4;
            lblTollAmount.Text = "Toll Amount:";
            // 
            // cmbRateCategory
            // 
            cmbRateCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRateCategory.FormattingEnabled = true;
            cmbRateCategory.Location = new Point(553, 12);
            cmbRateCategory.Name = "cmbRateCategory";
            cmbRateCategory.Size = new Size(209, 31);
            cmbRateCategory.TabIndex = 3;
            // 
            // lblVehicleCategory
            // 
            lblVehicleCategory.AutoSize = true;
            lblVehicleCategory.BackColor = Color.FromArgb(255, 255, 128);
            lblVehicleCategory.Location = new Point(354, 15);
            lblVehicleCategory.Name = "lblVehicleCategory";
            lblVehicleCategory.Size = new Size(184, 23);
            lblVehicleCategory.TabIndex = 2;
            lblVehicleCategory.Text = "Vehicle Category:";
            // 
            // cmbRatePlaza
            // 
            cmbRatePlaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRatePlaza.FormattingEnabled = true;
            cmbRatePlaza.Location = new Point(122, 12);
            cmbRatePlaza.Name = "cmbRatePlaza";
            cmbRatePlaza.Size = new Size(209, 31);
            cmbRatePlaza.TabIndex = 1;
            // 
            // lblTollPlaza
            // 
            lblTollPlaza.AutoSize = true;
            lblTollPlaza.BackColor = Color.FromArgb(255, 255, 128);
            lblTollPlaza.Location = new Point(8, 15);
            lblTollPlaza.Name = "lblTollPlaza";
            lblTollPlaza.Size = new Size(108, 23);
            lblTollPlaza.TabIndex = 0;
            lblTollPlaza.Text = "Toll Plaza:";
            // 
            // TollSetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 544);
            Controls.Add(tabTollSetup);
            Name = "TollSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toll Setup Management";
            WindowState = FormWindowState.Maximized;
            Load += TollSetupForm_Load;
            tabTollSetup.ResumeLayout(false);
            tabTollPlazas.ResumeLayout(false);
            tabTollPlazas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTollPlazas).EndInit();
            pnlPlazaInput.ResumeLayout(false);
            pnlPlazaInput.PerformLayout();
            tabTollBooths.ResumeLayout(false);
            tabTollBooths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTollBooths).EndInit();
            pnlBoothInput.ResumeLayout(false);
            pnlBoothInput.PerformLayout();
            tabVehicleCategories.ResumeLayout(false);
            tabVehicleCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleCategories).EndInit();
            tabTollRates.ResumeLayout(false);
            tabTollRates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTollRates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabTollSetup;
        private TabPage tabTollPlazas;
        private TabPage tabTollBooths;
        private TabPage tabVehicleCategories;
        private TabPage tabTollRates;
        private Panel pnlPlazaInput;
        private Label lblPlazaTitle;
        private Button btnAddPlaza;
        private ComboBox cmbPlazaStatus;
        private Label lblPlazaStatus;
        private TextBox txtPlazaLocation;
        private Label lblPlazaLocation;
        private TextBox txtPlazaName;
        private Label lblPlazaName;
        private Button btnClearPlaza;
        private Button btnUpdatePlaza;
        private DataGridView dgvTollPlazas;
        private Panel pnlBoothInput;
        private Label lblBoothTitle;
        private Label lblBoothStatus;
        private TextBox txtBoothNumber;
        private Label lblBoothNumber;
        private ComboBox cmbBoothPlaza;
        private Label lblBoothPlaza;
        private DataGridView dgvTollBooths;
        private Button btnClearBooth;
        private Button btnUpdateBooth;
        private Button btnAddBooth;
        private ComboBox cmbBoothStatus;
        private Label lblCategoryDescription;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private Label lblvehiclecategotymanagement;
        private DataGridView dgvVehicleCategories;
        private Button btnClearCategory;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private TextBox txtCategoryDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbRateCategory;
        private Label lblVehicleCategory;
        private ComboBox cmbRatePlaza;
        private Label lblTollPlaza;
        private ComboBox cmbRateStatus;
        private Label lblRateStatus;
        private DateTimePicker dtpEffectiveDate;
        private Label lblEffectiveDate;
        private TextBox txtTollAmount;
        private Label lblTollAmount;
        private DataGridView dgvTollRates;
        private Button btnClearRate;
        private Button btnUpdateRate;
        private Button btnAddRate;
    }
}