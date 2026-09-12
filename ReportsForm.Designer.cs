namespace TollPlazaManagementSystem
{
    partial class ReportsForm
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
            pnlReportsHeader = new Panel();
            lblReportsTitle = new Label();
            pnlReportSummary = new Panel();
            lblTotalTransactionsTitle = new Label();
            lblTotalTransactions = new Label();
            lblTodayTransactionsTitle = new Label();
            lblTodayTransactions = new Label();
            lblTotalCollectionTitle = new Label();
            lblTotalCollection = new Label();
            lblTodayCollectionTitle = new Label();
            lblTodayCollection = new Label();
            pnlReportFilters = new Panel();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblReportPlaza = new Label();
            cmbReportPlaza = new ComboBox();
            lblReportCategory = new Label();
            cmbReportCategory = new ComboBox();
            btnFilterReport = new Button();
            btnResetReport = new Button();
            pnlReportGrid = new Panel();
            dgvReports = new DataGridView();
            pnlReportsHeader.SuspendLayout();
            pnlReportSummary.SuspendLayout();
            pnlReportFilters.SuspendLayout();
            pnlReportGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pnlReportsHeader
            // 
            pnlReportsHeader.BackColor = Color.OrangeRed;
            pnlReportsHeader.Controls.Add(lblReportsTitle);
            pnlReportsHeader.Dock = DockStyle.Top;
            pnlReportsHeader.Location = new Point(0, 0);
            pnlReportsHeader.Name = "pnlReportsHeader";
            pnlReportsHeader.Size = new Size(978, 56);
            pnlReportsHeader.TabIndex = 0;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.AutoSize = true;
            lblReportsTitle.BackColor = Color.Orange;
            lblReportsTitle.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportsTitle.Location = new Point(402, 9);
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(140, 37);
            lblReportsTitle.TabIndex = 0;
            lblReportsTitle.Text = "Reports";
            // 
            // pnlReportSummary
            // 
            pnlReportSummary.BackColor = Color.Beige;
            pnlReportSummary.Controls.Add(lblTodayCollection);
            pnlReportSummary.Controls.Add(lblTodayCollectionTitle);
            pnlReportSummary.Controls.Add(lblTotalCollection);
            pnlReportSummary.Controls.Add(lblTotalCollectionTitle);
            pnlReportSummary.Controls.Add(lblTodayTransactions);
            pnlReportSummary.Controls.Add(lblTodayTransactionsTitle);
            pnlReportSummary.Controls.Add(lblTotalTransactions);
            pnlReportSummary.Controls.Add(lblTotalTransactionsTitle);
            pnlReportSummary.Dock = DockStyle.Top;
            pnlReportSummary.Location = new Point(0, 56);
            pnlReportSummary.Name = "pnlReportSummary";
            pnlReportSummary.Size = new Size(978, 135);
            pnlReportSummary.TabIndex = 1;
            // 
            // lblTotalTransactionsTitle
            // 
            lblTotalTransactionsTitle.AutoSize = true;
            lblTotalTransactionsTitle.BackColor = Color.Aquamarine;
            lblTotalTransactionsTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTransactionsTitle.Location = new Point(12, 16);
            lblTotalTransactionsTitle.Name = "lblTotalTransactionsTitle";
            lblTotalTransactionsTitle.Size = new Size(227, 28);
            lblTotalTransactionsTitle.TabIndex = 0;
            lblTotalTransactionsTitle.Text = "Total Transactions";
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.BackColor = Color.Aquamarine;
            lblTotalTransactions.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTransactions.Location = new Point(90, 58);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(25, 26);
            lblTotalTransactions.TabIndex = 1;
            lblTotalTransactions.Text = "0";
            // 
            // lblTodayTransactionsTitle
            // 
            lblTodayTransactionsTitle.AutoSize = true;
            lblTodayTransactionsTitle.BackColor = Color.LightGreen;
            lblTodayTransactionsTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayTransactionsTitle.Location = new Point(257, 16);
            lblTodayTransactionsTitle.Name = "lblTodayTransactionsTitle";
            lblTodayTransactionsTitle.Size = new Size(259, 28);
            lblTodayTransactionsTitle.TabIndex = 2;
            lblTodayTransactionsTitle.Text = "Today's Transactions";
            // 
            // lblTodayTransactions
            // 
            lblTodayTransactions.AutoSize = true;
            lblTodayTransactions.BackColor = Color.LightGreen;
            lblTodayTransactions.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayTransactions.Location = new Point(363, 58);
            lblTodayTransactions.Name = "lblTodayTransactions";
            lblTodayTransactions.Size = new Size(25, 26);
            lblTodayTransactions.TabIndex = 3;
            lblTodayTransactions.Text = "0";
            // 
            // lblTotalCollectionTitle
            // 
            lblTotalCollectionTitle.AutoSize = true;
            lblTotalCollectionTitle.BackColor = Color.Yellow;
            lblTotalCollectionTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCollectionTitle.Location = new Point(537, 16);
            lblTotalCollectionTitle.Name = "lblTotalCollectionTitle";
            lblTotalCollectionTitle.Size = new Size(193, 28);
            lblTotalCollectionTitle.TabIndex = 4;
            lblTotalCollectionTitle.Text = "Total Collection";
            // 
            // lblTotalCollection
            // 
            lblTotalCollection.AutoSize = true;
            lblTotalCollection.BackColor = Color.Yellow;
            lblTotalCollection.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCollection.Location = new Point(590, 58);
            lblTotalCollection.Name = "lblTotalCollection";
            lblTotalCollection.Size = new Size(65, 26);
            lblTotalCollection.TabIndex = 5;
            lblTotalCollection.Text = "৳ 0.00";
            // 
            // lblTodayCollectionTitle
            // 
            lblTodayCollectionTitle.AutoSize = true;
            lblTodayCollectionTitle.BackColor = Color.DarkGoldenrod;
            lblTodayCollectionTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayCollectionTitle.Location = new Point(741, 16);
            lblTodayCollectionTitle.Name = "lblTodayCollectionTitle";
            lblTodayCollectionTitle.Size = new Size(225, 28);
            lblTodayCollectionTitle.TabIndex = 6;
            lblTodayCollectionTitle.Text = "Today's Collection";
            lblTodayCollectionTitle.Click += lblTodayCollectionTitle_Click;
            // 
            // lblTodayCollection
            // 
            lblTodayCollection.AutoSize = true;
            lblTodayCollection.BackColor = Color.DarkGoldenrod;
            lblTodayCollection.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayCollection.Location = new Point(809, 58);
            lblTodayCollection.Name = "lblTodayCollection";
            lblTodayCollection.Size = new Size(65, 26);
            lblTodayCollection.TabIndex = 7;
            lblTodayCollection.Text = "৳ 0.00";
            // 
            // pnlReportFilters
            // 
            pnlReportFilters.BackColor = Color.CadetBlue;
            pnlReportFilters.Controls.Add(btnResetReport);
            pnlReportFilters.Controls.Add(btnFilterReport);
            pnlReportFilters.Controls.Add(cmbReportCategory);
            pnlReportFilters.Controls.Add(lblReportCategory);
            pnlReportFilters.Controls.Add(cmbReportPlaza);
            pnlReportFilters.Controls.Add(lblReportPlaza);
            pnlReportFilters.Controls.Add(dtpToDate);
            pnlReportFilters.Controls.Add(lblToDate);
            pnlReportFilters.Controls.Add(dtpFromDate);
            pnlReportFilters.Controls.Add(lblFromDate);
            pnlReportFilters.Dock = DockStyle.Top;
            pnlReportFilters.Location = new Point(0, 191);
            pnlReportFilters.Name = "pnlReportFilters";
            pnlReportFilters.Size = new Size(978, 90);
            pnlReportFilters.TabIndex = 2;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.BackColor = Color.Lime;
            lblFromDate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFromDate.Location = new Point(13, 3);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(102, 21);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(0, 27);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(149, 31);
            dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.BackColor = Color.Lime;
            lblToDate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToDate.Location = new Point(185, 3);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(78, 21);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "To Date";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(155, 27);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(149, 31);
            dtpToDate.TabIndex = 3;
            // 
            // lblReportPlaza
            // 
            lblReportPlaza.AutoSize = true;
            lblReportPlaza.BackColor = Color.Lime;
            lblReportPlaza.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportPlaza.Location = new Point(326, 3);
            lblReportPlaza.Name = "lblReportPlaza";
            lblReportPlaza.Size = new Size(95, 21);
            lblReportPlaza.TabIndex = 4;
            lblReportPlaza.Text = "Toll Plaza";
            // 
            // cmbReportPlaza
            // 
            cmbReportPlaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportPlaza.FormattingEnabled = true;
            cmbReportPlaza.Location = new Point(310, 27);
            cmbReportPlaza.Name = "cmbReportPlaza";
            cmbReportPlaza.Size = new Size(119, 33);
            cmbReportPlaza.TabIndex = 5;
            // 
            // lblReportCategory
            // 
            lblReportCategory.AutoSize = true;
            lblReportCategory.BackColor = Color.Lime;
            lblReportCategory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportCategory.Location = new Point(447, 3);
            lblReportCategory.Name = "lblReportCategory";
            lblReportCategory.Size = new Size(162, 21);
            lblReportCategory.TabIndex = 6;
            lblReportCategory.Text = "Vehicle Category";
            // 
            // cmbReportCategory
            // 
            cmbReportCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportCategory.FormattingEnabled = true;
            cmbReportCategory.Location = new Point(447, 27);
            cmbReportCategory.Name = "cmbReportCategory";
            cmbReportCategory.Size = new Size(162, 33);
            cmbReportCategory.TabIndex = 7;
            // 
            // btnFilterReport
            // 
            btnFilterReport.BackColor = Color.IndianRed;
            btnFilterReport.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilterReport.Location = new Point(661, 24);
            btnFilterReport.Name = "btnFilterReport";
            btnFilterReport.Size = new Size(112, 34);
            btnFilterReport.TabIndex = 8;
            btnFilterReport.Text = "Filter";
            btnFilterReport.UseVisualStyleBackColor = false;
            btnFilterReport.Click += btnFilterReport_Click;
            // 
            // btnResetReport
            // 
            btnResetReport.BackColor = Color.Gray;
            btnResetReport.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetReport.Location = new Point(798, 24);
            btnResetReport.Name = "btnResetReport";
            btnResetReport.Size = new Size(112, 34);
            btnResetReport.TabIndex = 9;
            btnResetReport.Text = "Reset";
            btnResetReport.UseVisualStyleBackColor = false;
            btnResetReport.Click += btnResetReport_Click;
            // 
            // pnlReportGrid
            // 
            pnlReportGrid.BackColor = Color.Gainsboro;
            pnlReportGrid.Controls.Add(dgvReports);
            pnlReportGrid.Dock = DockStyle.Fill;
            pnlReportGrid.Location = new Point(0, 281);
            pnlReportGrid.Name = "pnlReportGrid";
            pnlReportGrid.Size = new Size(978, 463);
            pnlReportGrid.TabIndex = 3;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(0, 0);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersVisible = false;
            dgvReports.RowHeadersWidth = 62;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(978, 463);
            dgvReports.TabIndex = 0;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(pnlReportGrid);
            Controls.Add(pnlReportFilters);
            Controls.Add(pnlReportSummary);
            Controls.Add(pnlReportsHeader);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            WindowState = FormWindowState.Maximized;
            Load += ReportsForm_Load;
            pnlReportsHeader.ResumeLayout(false);
            pnlReportsHeader.PerformLayout();
            pnlReportSummary.ResumeLayout(false);
            pnlReportSummary.PerformLayout();
            pnlReportFilters.ResumeLayout(false);
            pnlReportFilters.PerformLayout();
            pnlReportGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReportsHeader;
        private Label lblReportsTitle;
        private Panel pnlReportSummary;
        private Label lblTotalCollectionTitle;
        private Label lblTodayTransactions;
        private Label lblTodayTransactionsTitle;
        private Label lblTotalTransactions;
        private Label lblTotalTransactionsTitle;
        private Label lblTodayCollectionTitle;
        private Label lblTotalCollection;
        private Label lblTodayCollection;
        private Panel pnlReportFilters;
        private Label lblToDate;
        private DateTimePicker dtpFromDate;
        private Label lblFromDate;
        private Label lblReportCategory;
        private ComboBox cmbReportPlaza;
        private Label lblReportPlaza;
        private DateTimePicker dtpToDate;
        private ComboBox cmbReportCategory;
        private Button btnFilterReport;
        private Button btnResetReport;
        private Panel pnlReportGrid;
        private DataGridView dgvReports;
    }
}