namespace TollPlazaManagementSystem
{
    partial class AdminTransactionForm
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
            pnlAdminTransactionHeader = new Panel();
            lblAdminTransactionTitle = new Label();
            lblAdminTransactionDate = new Label();
            pnlAdminTransactionSearch = new Panel();
            lblAdminVehicleNumber = new Label();
            txtAdminVehicleSearch = new TextBox();
            btnAdminSearch = new Button();
            btnAdminRefresh = new Button();
            btnAdminBack = new Button();
            dgvAdminTransactions = new DataGridView();
            pnlAdminTransactionSummary = new Panel();
            lblAdminTotalTransactionsTitle = new Label();
            lblAdminTotalTransactions = new Label();
            lblAdminTotalCollectionTitle = new Label();
            lblAdminTotalCollection = new Label();
            pnlAdminTransactionHeader.SuspendLayout();
            pnlAdminTransactionSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminTransactions).BeginInit();
            pnlAdminTransactionSummary.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminTransactionHeader
            // 
            pnlAdminTransactionHeader.BackColor = Color.GreenYellow;
            pnlAdminTransactionHeader.Controls.Add(lblAdminTransactionDate);
            pnlAdminTransactionHeader.Controls.Add(lblAdminTransactionTitle);
            pnlAdminTransactionHeader.Dock = DockStyle.Top;
            pnlAdminTransactionHeader.Location = new Point(0, 0);
            pnlAdminTransactionHeader.Name = "pnlAdminTransactionHeader";
            pnlAdminTransactionHeader.Size = new Size(800, 71);
            pnlAdminTransactionHeader.TabIndex = 0;
            // 
            // lblAdminTransactionTitle
            // 
            lblAdminTransactionTitle.AutoSize = true;
            lblAdminTransactionTitle.BackColor = Color.PaleGoldenrod;
            lblAdminTransactionTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminTransactionTitle.Location = new Point(3, 9);
            lblAdminTransactionTitle.Name = "lblAdminTransactionTitle";
            lblAdminTransactionTitle.Size = new Size(459, 28);
            lblAdminTransactionTitle.TabIndex = 0;
            lblAdminTransactionTitle.Text = "ADMIN TRANSACTION MANAGEMENT";
            // 
            // lblAdminTransactionDate
            // 
            lblAdminTransactionDate.AutoSize = true;
            lblAdminTransactionDate.BackColor = Color.Orange;
            lblAdminTransactionDate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminTransactionDate.Location = new Point(509, 16);
            lblAdminTransactionDate.Name = "lblAdminTransactionDate";
            lblAdminTransactionDate.Size = new Size(51, 21);
            lblAdminTransactionDate.TabIndex = 1;
            lblAdminTransactionDate.Text = "Date";
            // 
            // pnlAdminTransactionSearch
            // 
            pnlAdminTransactionSearch.BackColor = Color.Lavender;
            pnlAdminTransactionSearch.Controls.Add(btnAdminBack);
            pnlAdminTransactionSearch.Controls.Add(btnAdminRefresh);
            pnlAdminTransactionSearch.Controls.Add(btnAdminSearch);
            pnlAdminTransactionSearch.Controls.Add(txtAdminVehicleSearch);
            pnlAdminTransactionSearch.Controls.Add(lblAdminVehicleNumber);
            pnlAdminTransactionSearch.Dock = DockStyle.Top;
            pnlAdminTransactionSearch.Location = new Point(0, 71);
            pnlAdminTransactionSearch.Name = "pnlAdminTransactionSearch";
            pnlAdminTransactionSearch.Size = new Size(800, 90);
            pnlAdminTransactionSearch.TabIndex = 1;
            // 
            // lblAdminVehicleNumber
            // 
            lblAdminVehicleNumber.AutoSize = true;
            lblAdminVehicleNumber.BackColor = Color.FromArgb(255, 255, 128);
            lblAdminVehicleNumber.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminVehicleNumber.ForeColor = SystemColors.ActiveCaptionText;
            lblAdminVehicleNumber.Location = new Point(3, 12);
            lblAdminVehicleNumber.Name = "lblAdminVehicleNumber";
            lblAdminVehicleNumber.Size = new Size(172, 23);
            lblAdminVehicleNumber.TabIndex = 0;
            lblAdminVehicleNumber.Text = "Vehicle Number:";
            // 
            // txtAdminVehicleSearch
            // 
            txtAdminVehicleSearch.Location = new Point(181, 12);
            txtAdminVehicleSearch.Name = "txtAdminVehicleSearch";
            txtAdminVehicleSearch.Size = new Size(555, 31);
            txtAdminVehicleSearch.TabIndex = 1;
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.BackColor = Color.Lime;
            btnAdminSearch.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminSearch.Location = new Point(194, 53);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(112, 34);
            btnAdminSearch.TabIndex = 2;
            btnAdminSearch.Text = "SEARCH";
            btnAdminSearch.UseVisualStyleBackColor = false;
            btnAdminSearch.Click += btnAdminSearch_Click;
            // 
            // btnAdminRefresh
            // 
            btnAdminRefresh.BackColor = Color.Yellow;
            btnAdminRefresh.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminRefresh.Location = new Point(383, 53);
            btnAdminRefresh.Name = "btnAdminRefresh";
            btnAdminRefresh.Size = new Size(112, 34);
            btnAdminRefresh.TabIndex = 3;
            btnAdminRefresh.Text = "REFRESH";
            btnAdminRefresh.UseVisualStyleBackColor = false;
            btnAdminRefresh.Click += btnAdminRefresh_Click;
            // 
            // btnAdminBack
            // 
            btnAdminBack.BackColor = Color.Aqua;
            btnAdminBack.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminBack.Location = new Point(577, 53);
            btnAdminBack.Name = "btnAdminBack";
            btnAdminBack.Size = new Size(112, 34);
            btnAdminBack.TabIndex = 4;
            btnAdminBack.Text = "BACK";
            btnAdminBack.UseVisualStyleBackColor = false;
            btnAdminBack.Click += btnAdminBack_Click;
            // 
            // dgvAdminTransactions
            // 
            dgvAdminTransactions.AllowUserToAddRows = false;
            dgvAdminTransactions.AllowUserToDeleteRows = false;
            dgvAdminTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminTransactions.Dock = DockStyle.Top;
            dgvAdminTransactions.Location = new Point(0, 161);
            dgvAdminTransactions.MultiSelect = false;
            dgvAdminTransactions.Name = "dgvAdminTransactions";
            dgvAdminTransactions.ReadOnly = true;
            dgvAdminTransactions.RowHeadersWidth = 62;
            dgvAdminTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminTransactions.Size = new Size(800, 233);
            dgvAdminTransactions.TabIndex = 2;
            // 
            // pnlAdminTransactionSummary
            // 
            pnlAdminTransactionSummary.BackColor = Color.DarkOrange;
            pnlAdminTransactionSummary.Controls.Add(lblAdminTotalCollection);
            pnlAdminTransactionSummary.Controls.Add(lblAdminTotalCollectionTitle);
            pnlAdminTransactionSummary.Controls.Add(lblAdminTotalTransactions);
            pnlAdminTransactionSummary.Controls.Add(lblAdminTotalTransactionsTitle);
            pnlAdminTransactionSummary.Dock = DockStyle.Bottom;
            pnlAdminTransactionSummary.Location = new Point(0, 393);
            pnlAdminTransactionSummary.Name = "pnlAdminTransactionSummary";
            pnlAdminTransactionSummary.Size = new Size(800, 57);
            pnlAdminTransactionSummary.TabIndex = 3;
            // 
            // lblAdminTotalTransactionsTitle
            // 
            lblAdminTotalTransactionsTitle.AutoSize = true;
            lblAdminTotalTransactionsTitle.BackColor = Color.WhiteSmoke;
            lblAdminTotalTransactionsTitle.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminTotalTransactionsTitle.Location = new Point(3, 22);
            lblAdminTotalTransactionsTitle.Name = "lblAdminTotalTransactionsTitle";
            lblAdminTotalTransactionsTitle.Size = new Size(219, 26);
            lblAdminTotalTransactionsTitle.TabIndex = 0;
            lblAdminTotalTransactionsTitle.Text = "Total Transactions:";
            // 
            // lblAdminTotalTransactions
            // 
            lblAdminTotalTransactions.AutoSize = true;
            lblAdminTotalTransactions.BackColor = Color.WhiteSmoke;
            lblAdminTotalTransactions.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminTotalTransactions.Location = new Point(228, 22);
            lblAdminTotalTransactions.Name = "lblAdminTotalTransactions";
            lblAdminTotalTransactions.Size = new Size(25, 26);
            lblAdminTotalTransactions.TabIndex = 1;
            lblAdminTotalTransactions.Text = "0";
            // 
            // lblAdminTotalCollectionTitle
            // 
            lblAdminTotalCollectionTitle.AutoSize = true;
            lblAdminTotalCollectionTitle.BackColor = Color.WhiteSmoke;
            lblAdminTotalCollectionTitle.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminTotalCollectionTitle.Location = new Point(472, 22);
            lblAdminTotalCollectionTitle.Name = "lblAdminTotalCollectionTitle";
            lblAdminTotalCollectionTitle.Size = new Size(186, 26);
            lblAdminTotalCollectionTitle.TabIndex = 2;
            lblAdminTotalCollectionTitle.Text = "Total Collection:";
            // 
            // lblAdminTotalCollection
            // 
            lblAdminTotalCollection.AutoSize = true;
            lblAdminTotalCollection.BackColor = Color.WhiteSmoke;
            lblAdminTotalCollection.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminTotalCollection.Location = new Point(664, 22);
            lblAdminTotalCollection.Name = "lblAdminTotalCollection";
            lblAdminTotalCollection.Size = new Size(65, 26);
            lblAdminTotalCollection.TabIndex = 3;
            lblAdminTotalCollection.Text = "৳ 0.00";
            // 
            // AdminTransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAdminTransactionSummary);
            Controls.Add(dgvAdminTransactions);
            Controls.Add(pnlAdminTransactionSearch);
            Controls.Add(pnlAdminTransactionHeader);
            Name = "AdminTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Transaction Management";
            WindowState = FormWindowState.Maximized;
            Load += AdminTransactionForm_Load;
            pnlAdminTransactionHeader.ResumeLayout(false);
            pnlAdminTransactionHeader.PerformLayout();
            pnlAdminTransactionSearch.ResumeLayout(false);
            pnlAdminTransactionSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminTransactions).EndInit();
            pnlAdminTransactionSummary.ResumeLayout(false);
            pnlAdminTransactionSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminTransactionHeader;
        private Label lblAdminTransactionDate;
        private Label lblAdminTransactionTitle;
        private Panel pnlAdminTransactionSearch;
        private Button btnAdminSearch;
        private TextBox txtAdminVehicleSearch;
        private Label lblAdminVehicleNumber;
        private Button btnAdminBack;
        private Button btnAdminRefresh;
        private DataGridView dgvAdminTransactions;
        private Panel pnlAdminTransactionSummary;
        private Label lblAdminTotalCollection;
        private Label lblAdminTotalCollectionTitle;
        private Label lblAdminTotalTransactions;
        private Label lblAdminTotalTransactionsTitle;
    }
}