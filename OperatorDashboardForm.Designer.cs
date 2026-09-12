namespace TollPlazaManagementSystem
{
    partial class OperatorDashboardForm
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
            pnlSidebar = new Panel();
            btnOperatorLogout = new Button();
            btnTransactionHistory = new Button();
            btnNewTransaction = new Button();
            btnOperatorDashboard = new Button();
            lblOperatorSubtitle = new Label();
            lblOperatorTitle = new Label();
            pnlMainContent = new Panel();
            pnlTotalTransactions = new Panel();
            lblOperatorTotalTransactions = new Label();
            lblTotalTransactionTitle = new Label();
            pnlTodayCollection = new Panel();
            lblOperatorTodayCollection = new Label();
            lblTodayCollectionTitle = new Label();
            pnlTodayTransactions = new Panel();
            lblOperatorTodayTransactions = new Label();
            lblTodayTransactionTitle = new Label();
            pnlTopHeader = new Panel();
            lblOperatorDate = new Label();
            lblWelcomeOperator = new Label();
            pnlSidebar.SuspendLayout();
            pnlMainContent.SuspendLayout();
            pnlTotalTransactions.SuspendLayout();
            pnlTodayCollection.SuspendLayout();
            pnlTodayTransactions.SuspendLayout();
            pnlTopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.LemonChiffon;
            pnlSidebar.Controls.Add(btnOperatorLogout);
            pnlSidebar.Controls.Add(btnTransactionHistory);
            pnlSidebar.Controls.Add(btnNewTransaction);
            pnlSidebar.Controls.Add(btnOperatorDashboard);
            pnlSidebar.Controls.Add(lblOperatorSubtitle);
            pnlSidebar.Controls.Add(lblOperatorTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 544);
            pnlSidebar.TabIndex = 0;
            // 
            // btnOperatorLogout
            // 
            btnOperatorLogout.BackColor = Color.Red;
            btnOperatorLogout.FlatAppearance.BorderSize = 0;
            btnOperatorLogout.FlatStyle = FlatStyle.Flat;
            btnOperatorLogout.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOperatorLogout.Location = new Point(0, 445);
            btnOperatorLogout.Name = "btnOperatorLogout";
            btnOperatorLogout.Padding = new Padding(20, 0, 0, 0);
            btnOperatorLogout.Size = new Size(250, 55);
            btnOperatorLogout.TabIndex = 5;
            btnOperatorLogout.Text = "Logout";
            btnOperatorLogout.UseVisualStyleBackColor = false;
            btnOperatorLogout.Click += btnOperatorLogout_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.BackColor = Color.Coral;
            btnTransactionHistory.FlatAppearance.BorderSize = 0;
            btnTransactionHistory.FlatStyle = FlatStyle.Flat;
            btnTransactionHistory.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransactionHistory.Location = new Point(0, 346);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Padding = new Padding(20, 0, 0, 0);
            btnTransactionHistory.Size = new Size(250, 55);
            btnTransactionHistory.TabIndex = 4;
            btnTransactionHistory.Text = "Transaction History";
            btnTransactionHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnTransactionHistory.UseVisualStyleBackColor = false;
            btnTransactionHistory.Click += btnTransactionHistory_Click;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.BackColor = Color.GreenYellow;
            btnNewTransaction.FlatAppearance.BorderSize = 0;
            btnNewTransaction.FlatStyle = FlatStyle.Flat;
            btnNewTransaction.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewTransaction.Location = new Point(0, 242);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Padding = new Padding(20, 0, 0, 0);
            btnNewTransaction.Size = new Size(250, 55);
            btnNewTransaction.TabIndex = 3;
            btnNewTransaction.Text = "New Toll Transaction";
            btnNewTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnNewTransaction.UseVisualStyleBackColor = false;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // btnOperatorDashboard
            // 
            btnOperatorDashboard.BackColor = SystemColors.MenuHighlight;
            btnOperatorDashboard.FlatAppearance.BorderSize = 0;
            btnOperatorDashboard.FlatStyle = FlatStyle.Flat;
            btnOperatorDashboard.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOperatorDashboard.Location = new Point(0, 145);
            btnOperatorDashboard.Name = "btnOperatorDashboard";
            btnOperatorDashboard.Padding = new Padding(20, 0, 0, 0);
            btnOperatorDashboard.Size = new Size(250, 55);
            btnOperatorDashboard.TabIndex = 2;
            btnOperatorDashboard.Text = "Dashboard";
            btnOperatorDashboard.UseVisualStyleBackColor = false;
            btnOperatorDashboard.Click += btnOperatorDashboard_Click;
            // 
            // lblOperatorSubtitle
            // 
            lblOperatorSubtitle.BackColor = Color.Transparent;
            lblOperatorSubtitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperatorSubtitle.ForeColor = Color.Black;
            lblOperatorSubtitle.Location = new Point(36, 74);
            lblOperatorSubtitle.Name = "lblOperatorSubtitle";
            lblOperatorSubtitle.Size = new Size(171, 50);
            lblOperatorSubtitle.TabIndex = 1;
            lblOperatorSubtitle.Text = "OPERATOR PANEL";
            lblOperatorSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOperatorTitle
            // 
            lblOperatorTitle.BackColor = Color.Transparent;
            lblOperatorTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperatorTitle.ForeColor = Color.DarkMagenta;
            lblOperatorTitle.Location = new Point(36, 9);
            lblOperatorTitle.Name = "lblOperatorTitle";
            lblOperatorTitle.Size = new Size(171, 50);
            lblOperatorTitle.TabIndex = 0;
            lblOperatorTitle.Text = "TOLL PLAZA";
            lblOperatorTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.WhiteSmoke;
            pnlMainContent.Controls.Add(pnlTotalTransactions);
            pnlMainContent.Controls.Add(pnlTodayCollection);
            pnlMainContent.Controls.Add(pnlTodayTransactions);
            pnlMainContent.Controls.Add(pnlTopHeader);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(250, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(678, 544);
            pnlMainContent.TabIndex = 1;
            // 
            // pnlTotalTransactions
            // 
            pnlTotalTransactions.BackColor = Color.DarkCyan;
            pnlTotalTransactions.Controls.Add(lblOperatorTotalTransactions);
            pnlTotalTransactions.Controls.Add(lblTotalTransactionTitle);
            pnlTotalTransactions.Location = new Point(192, 328);
            pnlTotalTransactions.Name = "pnlTotalTransactions";
            pnlTotalTransactions.Size = new Size(250, 140);
            pnlTotalTransactions.TabIndex = 2;
            // 
            // lblOperatorTotalTransactions
            // 
            lblOperatorTotalTransactions.AutoSize = true;
            lblOperatorTotalTransactions.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperatorTotalTransactions.Location = new Point(107, 72);
            lblOperatorTotalTransactions.Name = "lblOperatorTotalTransactions";
            lblOperatorTotalTransactions.Size = new Size(21, 21);
            lblOperatorTotalTransactions.TabIndex = 1;
            lblOperatorTotalTransactions.Text = "0";
            // 
            // lblTotalTransactionTitle
            // 
            lblTotalTransactionTitle.AutoSize = true;
            lblTotalTransactionTitle.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTransactionTitle.Location = new Point(15, 18);
            lblTotalTransactionTitle.Name = "lblTotalTransactionTitle";
            lblTotalTransactionTitle.Size = new Size(221, 21);
            lblTotalTransactionTitle.TabIndex = 0;
            lblTotalTransactionTitle.Text = "TOTAL TRANSACTIONS";
            // 
            // pnlTodayCollection
            // 
            pnlTodayCollection.BackColor = Color.MediumSlateBlue;
            pnlTodayCollection.Controls.Add(lblOperatorTodayCollection);
            pnlTodayCollection.Controls.Add(lblTodayCollectionTitle);
            pnlTodayCollection.Location = new Point(366, 140);
            pnlTodayCollection.Name = "pnlTodayCollection";
            pnlTodayCollection.Size = new Size(250, 140);
            pnlTodayCollection.TabIndex = 2;
            // 
            // lblOperatorTodayCollection
            // 
            lblOperatorTodayCollection.AutoSize = true;
            lblOperatorTodayCollection.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperatorTodayCollection.Location = new Point(106, 72);
            lblOperatorTodayCollection.Name = "lblOperatorTodayCollection";
            lblOperatorTodayCollection.Size = new Size(49, 21);
            lblOperatorTodayCollection.TabIndex = 1;
            lblOperatorTodayCollection.Text = "0.00";
            // 
            // lblTodayCollectionTitle
            // 
            lblTodayCollectionTitle.AutoSize = true;
            lblTodayCollectionTitle.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayCollectionTitle.Location = new Point(23, 23);
            lblTodayCollectionTitle.Name = "lblTodayCollectionTitle";
            lblTodayCollectionTitle.Size = new Size(212, 21);
            lblTodayCollectionTitle.TabIndex = 0;
            lblTodayCollectionTitle.Text = "TODAY'S COLLECTION";
            // 
            // pnlTodayTransactions
            // 
            pnlTodayTransactions.BackColor = Color.Thistle;
            pnlTodayTransactions.Controls.Add(lblOperatorTodayTransactions);
            pnlTodayTransactions.Controls.Add(lblTodayTransactionTitle);
            pnlTodayTransactions.Location = new Point(50, 140);
            pnlTodayTransactions.Name = "pnlTodayTransactions";
            pnlTodayTransactions.Size = new Size(250, 140);
            pnlTodayTransactions.TabIndex = 1;
            // 
            // lblOperatorTodayTransactions
            // 
            lblOperatorTodayTransactions.AutoSize = true;
            lblOperatorTodayTransactions.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperatorTodayTransactions.Location = new Point(93, 72);
            lblOperatorTodayTransactions.Name = "lblOperatorTodayTransactions";
            lblOperatorTodayTransactions.Size = new Size(21, 21);
            lblOperatorTodayTransactions.TabIndex = 1;
            lblOperatorTodayTransactions.Text = "0";
            // 
            // lblTodayTransactionTitle
            // 
            lblTodayTransactionTitle.AutoSize = true;
            lblTodayTransactionTitle.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayTransactionTitle.Location = new Point(5, 23);
            lblTodayTransactionTitle.Name = "lblTodayTransactionTitle";
            lblTodayTransactionTitle.Size = new Size(239, 21);
            lblTodayTransactionTitle.TabIndex = 0;
            lblTodayTransactionTitle.Text = "TODAY'S TRANSACTIONS";
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.PaleGreen;
            pnlTopHeader.Controls.Add(lblOperatorDate);
            pnlTopHeader.Controls.Add(lblWelcomeOperator);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(678, 105);
            pnlTopHeader.TabIndex = 0;
            // 
            // lblOperatorDate
            // 
            lblOperatorDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOperatorDate.AutoSize = true;
            lblOperatorDate.BackColor = Color.Teal;
            lblOperatorDate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperatorDate.Location = new Point(507, 47);
            lblOperatorDate.Name = "lblOperatorDate";
            lblOperatorDate.Size = new Size(66, 28);
            lblOperatorDate.TabIndex = 1;
            lblOperatorDate.Text = "Date";
            // 
            // lblWelcomeOperator
            // 
            lblWelcomeOperator.AutoSize = true;
            lblWelcomeOperator.BackColor = Color.LightSkyBlue;
            lblWelcomeOperator.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeOperator.Location = new Point(6, 47);
            lblWelcomeOperator.Name = "lblWelcomeOperator";
            lblWelcomeOperator.Size = new Size(288, 28);
            lblWelcomeOperator.TabIndex = 0;
            lblWelcomeOperator.Text = "WELCOME, OPERATOR";
            // 
            // OperatorDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(928, 544);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Name = "OperatorDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operator Dashboard - Toll Plaza Management System";
            WindowState = FormWindowState.Maximized;
            Load += OperatorDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMainContent.ResumeLayout(false);
            pnlTotalTransactions.ResumeLayout(false);
            pnlTotalTransactions.PerformLayout();
            pnlTodayCollection.ResumeLayout(false);
            pnlTodayCollection.PerformLayout();
            pnlTodayTransactions.ResumeLayout(false);
            pnlTodayTransactions.PerformLayout();
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblOperatorTitle;
        private Label lblOperatorSubtitle;
        private Button btnNewTransaction;
        private Button btnOperatorDashboard;
        private Button btnOperatorLogout;
        private Button btnTransactionHistory;
        private Panel pnlMainContent;
        private Panel pnlTopHeader;
        private Panel pnlTodayTransactions;
        private Label lblOperatorDate;
        private Label lblWelcomeOperator;
        private Label lblTodayTransactionTitle;
        private Panel pnlTotalTransactions;
        private Label lblOperatorTotalTransactions;
        private Label lblTotalTransactionTitle;
        private Panel pnlTodayCollection;
        private Label lblOperatorTodayCollection;
        private Label lblTodayCollectionTitle;
        private Label lblOperatorTodayTransactions;
    }
}