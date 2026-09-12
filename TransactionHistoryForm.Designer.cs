namespace TollPlazaManagementSystem
{
    partial class TransactionHistoryForm
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
            components = new System.ComponentModel.Container();
            pnlHistoryHeader = new Panel();
            lblHistoryTitle = new Label();
            lblHistoryDate = new Label();
            pnlHistoryFilter = new Panel();
            lblSearchVehicle = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtSearchVehicle = new TextBox();
            btnSearchHistory = new Button();
            btnRefreshHistory = new Button();
            btnBackHistory = new Button();
            dgvTransactionHistory = new DataGridView();
            pnlHistorySummary = new Panel();
            lblTotalHistoryText = new Label();
            lblTotalHistoryCount = new Label();
            lblTotalCollectionText = new Label();
            lblTotalHistoryCollection = new Label();
            pnlHistoryHeader.SuspendLayout();
            pnlHistoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).BeginInit();
            pnlHistorySummary.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHistoryHeader
            // 
            pnlHistoryHeader.BackColor = Color.DarkSlateBlue;
            pnlHistoryHeader.Controls.Add(lblHistoryDate);
            pnlHistoryHeader.Controls.Add(lblHistoryTitle);
            pnlHistoryHeader.Dock = DockStyle.Top;
            pnlHistoryHeader.Location = new Point(0, 0);
            pnlHistoryHeader.Name = "pnlHistoryHeader";
            pnlHistoryHeader.Size = new Size(800, 95);
            pnlHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.BackColor = Color.Orange;
            lblHistoryTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistoryTitle.Location = new Point(12, 34);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(240, 28);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "Transaction History";
            // 
            // lblHistoryDate
            // 
            lblHistoryDate.AutoSize = true;
            lblHistoryDate.BackColor = Color.Aqua;
            lblHistoryDate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistoryDate.Location = new Point(603, 34);
            lblHistoryDate.Name = "lblHistoryDate";
            lblHistoryDate.Size = new Size(66, 28);
            lblHistoryDate.TabIndex = 1;
            lblHistoryDate.Text = "Date";
            // 
            // pnlHistoryFilter
            // 
            pnlHistoryFilter.BackColor = Color.NavajoWhite;
            pnlHistoryFilter.Controls.Add(btnBackHistory);
            pnlHistoryFilter.Controls.Add(btnRefreshHistory);
            pnlHistoryFilter.Controls.Add(btnSearchHistory);
            pnlHistoryFilter.Controls.Add(txtSearchVehicle);
            pnlHistoryFilter.Controls.Add(lblSearchVehicle);
            pnlHistoryFilter.Dock = DockStyle.Top;
            pnlHistoryFilter.Location = new Point(0, 95);
            pnlHistoryFilter.Name = "pnlHistoryFilter";
            pnlHistoryFilter.Size = new Size(800, 85);
            pnlHistoryFilter.TabIndex = 1;
            // 
            // lblSearchVehicle
            // 
            lblSearchVehicle.AutoSize = true;
            lblSearchVehicle.BackColor = Color.Gold;
            lblSearchVehicle.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchVehicle.Location = new Point(3, 30);
            lblSearchVehicle.Name = "lblSearchVehicle";
            lblSearchVehicle.Size = new Size(158, 21);
            lblSearchVehicle.TabIndex = 0;
            lblSearchVehicle.Text = "Vehicle Number:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtSearchVehicle
            // 
            txtSearchVehicle.Location = new Point(167, 24);
            txtSearchVehicle.Name = "txtSearchVehicle";
            txtSearchVehicle.Size = new Size(394, 31);
            txtSearchVehicle.TabIndex = 1;
            // 
            // btnSearchHistory
            // 
            btnSearchHistory.BackColor = Color.Lime;
            btnSearchHistory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchHistory.Location = new Point(567, 0);
            btnSearchHistory.Name = "btnSearchHistory";
            btnSearchHistory.Size = new Size(112, 34);
            btnSearchHistory.TabIndex = 2;
            btnSearchHistory.Text = "Search";
            btnSearchHistory.UseVisualStyleBackColor = false;
            btnSearchHistory.Click += btnSearchHistory_Click;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.BackColor = Color.FromArgb(192, 0, 192);
            btnRefreshHistory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshHistory.Location = new Point(685, 0);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(112, 34);
            btnRefreshHistory.TabIndex = 3;
            btnRefreshHistory.Text = "Refresh";
            btnRefreshHistory.UseVisualStyleBackColor = false;
            btnRefreshHistory.Click += btnRefreshHistory_Click;
            // 
            // btnBackHistory
            // 
            btnBackHistory.BackColor = Color.Yellow;
            btnBackHistory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackHistory.Location = new Point(615, 40);
            btnBackHistory.Name = "btnBackHistory";
            btnBackHistory.Size = new Size(112, 34);
            btnBackHistory.TabIndex = 4;
            btnBackHistory.Text = "Back";
            btnBackHistory.UseVisualStyleBackColor = false;
            btnBackHistory.Click += btnBackHistory_Click;
            // 
            // dgvTransactionHistory
            // 
            dgvTransactionHistory.AllowUserToAddRows = false;
            dgvTransactionHistory.AllowUserToDeleteRows = false;
            dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionHistory.Dock = DockStyle.Top;
            dgvTransactionHistory.Location = new Point(0, 180);
            dgvTransactionHistory.MultiSelect = false;
            dgvTransactionHistory.Name = "dgvTransactionHistory";
            dgvTransactionHistory.ReadOnly = true;
            dgvTransactionHistory.RowHeadersVisible = false;
            dgvTransactionHistory.RowHeadersWidth = 62;
            dgvTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionHistory.Size = new Size(800, 204);
            dgvTransactionHistory.TabIndex = 3;
            // 
            // pnlHistorySummary
            // 
            pnlHistorySummary.BackColor = Color.YellowGreen;
            pnlHistorySummary.Controls.Add(lblTotalHistoryCollection);
            pnlHistorySummary.Controls.Add(lblTotalCollectionText);
            pnlHistorySummary.Controls.Add(lblTotalHistoryCount);
            pnlHistorySummary.Controls.Add(lblTotalHistoryText);
            pnlHistorySummary.Dock = DockStyle.Bottom;
            pnlHistorySummary.Location = new Point(0, 390);
            pnlHistorySummary.Name = "pnlHistorySummary";
            pnlHistorySummary.Size = new Size(800, 60);
            pnlHistorySummary.TabIndex = 4;
            // 
            // lblTotalHistoryText
            // 
            lblTotalHistoryText.AutoSize = true;
            lblTotalHistoryText.BackColor = Color.Yellow;
            lblTotalHistoryText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHistoryText.Location = new Point(3, 28);
            lblTotalHistoryText.Name = "lblTotalHistoryText";
            lblTotalHistoryText.Size = new Size(198, 23);
            lblTotalHistoryText.TabIndex = 0;
            lblTotalHistoryText.Text = "Total Transactions:";
            // 
            // lblTotalHistoryCount
            // 
            lblTotalHistoryCount.AutoSize = true;
            lblTotalHistoryCount.BackColor = Color.Goldenrod;
            lblTotalHistoryCount.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHistoryCount.Location = new Point(207, 28);
            lblTotalHistoryCount.Name = "lblTotalHistoryCount";
            lblTotalHistoryCount.Size = new Size(22, 23);
            lblTotalHistoryCount.TabIndex = 1;
            lblTotalHistoryCount.Text = "0";
            // 
            // lblTotalCollectionText
            // 
            lblTotalCollectionText.AutoSize = true;
            lblTotalCollectionText.BackColor = Color.MediumAquamarine;
            lblTotalCollectionText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCollectionText.Location = new Point(315, 28);
            lblTotalCollectionText.Name = "lblTotalCollectionText";
            lblTotalCollectionText.Size = new Size(167, 23);
            lblTotalCollectionText.TabIndex = 2;
            lblTotalCollectionText.Text = "Total Collection:";
            // 
            // lblTotalHistoryCollection
            // 
            lblTotalHistoryCollection.AutoSize = true;
            lblTotalHistoryCollection.BackColor = Color.Goldenrod;
            lblTotalHistoryCollection.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHistoryCollection.Location = new Point(488, 28);
            lblTotalHistoryCollection.Name = "lblTotalHistoryCollection";
            lblTotalHistoryCollection.Size = new Size(65, 26);
            lblTotalHistoryCollection.TabIndex = 3;
            lblTotalHistoryCollection.Text = "৳ 0.00";
            lblTotalHistoryCollection.Click += label1_Click;
            // 
            // TransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlHistorySummary);
            Controls.Add(dgvTransactionHistory);
            Controls.Add(pnlHistoryFilter);
            Controls.Add(pnlHistoryHeader);
            Name = "TransactionHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction History";
            WindowState = FormWindowState.Maximized;
            Load += TransactionHistoryForm_Load;
            pnlHistoryHeader.ResumeLayout(false);
            pnlHistoryHeader.PerformLayout();
            pnlHistoryFilter.ResumeLayout(false);
            pnlHistoryFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).EndInit();
            pnlHistorySummary.ResumeLayout(false);
            pnlHistorySummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHistoryHeader;
        private Label lblHistoryDate;
        private Label lblHistoryTitle;
        private Panel pnlHistoryFilter;
        private Button btnBackHistory;
        private Button btnRefreshHistory;
        private Button btnSearchHistory;
        private TextBox txtSearchVehicle;
        private Label lblSearchVehicle;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvTransactionHistory;
        private Panel pnlHistorySummary;
        private Label lblTotalHistoryCollection;
        private Label lblTotalCollectionText;
        private Label lblTotalHistoryCount;
        private Label lblTotalHistoryText;
    }
}