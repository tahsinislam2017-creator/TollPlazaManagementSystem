namespace TollPlazaManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            pnlHeader = new Panel();
            lbpicture2 = new PictureBox();
            lblAdminDashboard = new Label();
            lblHeaderTitle = new Label();
            pnlSidebar = new Panel();
            btnTollSetup = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnTransactions = new Button();
            btnUsers = new Button();
            btnDashboard = new Button();
            lblMenuTitle = new Label();
            pnlContent = new Panel();
            pnlTodayTransactions = new Panel();
            lblTodayTransactions = new Label();
            lblTransactionsText = new Label();
            pnlTotalVehicles = new Panel();
            lblTotalVehicles = new Label();
            lblVehiclesText = new Label();
            pnlTotalPlazas = new Panel();
            lblTotalPlazas = new Label();
            lblPlazasText = new Label();
            pnlTotalUsers = new Panel();
            lblTotalUsers = new Label();
            lblUsersText = new Label();
            lblDashboardTitle = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbpicture2).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlTodayTransactions.SuspendLayout();
            pnlTotalVehicles.SuspendLayout();
            pnlTotalPlazas.SuspendLayout();
            pnlTotalUsers.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lbpicture2);
            pnlHeader.Controls.Add(lblAdminDashboard);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Location = new Point(3, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(976, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lbpicture2
            // 
            lbpicture2.ErrorImage = (Image)resources.GetObject("lbpicture2.ErrorImage");
            lbpicture2.Image = (Image)resources.GetObject("lbpicture2.Image");
            lbpicture2.Location = new Point(644, 3);
            lbpicture2.Name = "lbpicture2";
            lbpicture2.Size = new Size(87, 74);
            lbpicture2.SizeMode = PictureBoxSizeMode.Zoom;
            lbpicture2.TabIndex = 2;
            lbpicture2.TabStop = false;
            // 
            // lblAdminDashboard
            // 
            lblAdminDashboard.AutoSize = true;
            lblAdminDashboard.BackColor = Color.Gray;
            lblAdminDashboard.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminDashboard.ForeColor = Color.Yellow;
            lblAdminDashboard.Location = new Point(737, 30);
            lblAdminDashboard.Name = "lblAdminDashboard";
            lblAdminDashboard.Size = new Size(214, 28);
            lblAdminDashboard.TabIndex = 1;
            lblAdminDashboard.Text = "AdminDashboard";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.BackColor = Color.Transparent;
            lblHeaderTitle.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(28, 26);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(559, 32);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "TOLL PLAZA MANAGEMENT SYSTEM";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Blue;
            pnlSidebar.Controls.Add(btnTollSetup);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnTransactions);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(227, 594);
            pnlSidebar.TabIndex = 1;
            // 
            // btnTollSetup
            // 
            btnTollSetup.BackColor = Color.Navy;
            btnTollSetup.FlatAppearance.BorderSize = 0;
            btnTollSetup.FlatStyle = FlatStyle.Flat;
            btnTollSetup.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTollSetup.ForeColor = Color.DeepSkyBlue;
            btnTollSetup.Location = new Point(45, 292);
            btnTollSetup.Name = "btnTollSetup";
            btnTollSetup.Size = new Size(136, 34);
            btnTollSetup.TabIndex = 11;
            btnTollSetup.Text = "Toll Setup";
            btnTollSetup.UseVisualStyleBackColor = false;
            btnTollSetup.Click += btnTollSetup_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(0, 557);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(227, 34);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Navy;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.DeepSkyBlue;
            btnReports.Location = new Point(45, 386);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(136, 34);
            btnReports.TabIndex = 9;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.Navy;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = Color.DeepSkyBlue;
            btnTransactions.Location = new Point(45, 474);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(136, 34);
            btnTransactions.TabIndex = 8;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Navy;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.DeepSkyBlue;
            btnUsers.Location = new Point(45, 205);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(136, 34);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Navy;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.DeepSkyBlue;
            btnDashboard.Location = new Point(0, 122);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(227, 34);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.BackColor = Color.Lime;
            lblMenuTitle.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenuTitle.ForeColor = Color.Crimson;
            lblMenuTitle.Location = new Point(31, 84);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(150, 24);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "ADMIN MENU";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.Info;
            pnlContent.Controls.Add(pnlTodayTransactions);
            pnlContent.Controls.Add(pnlTotalVehicles);
            pnlContent.Controls.Add(pnlTotalPlazas);
            pnlContent.Controls.Add(pnlTotalUsers);
            pnlContent.Controls.Add(lblDashboardTitle);
            pnlContent.Dock = DockStyle.Bottom;
            pnlContent.Location = new Point(227, 84);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(751, 510);
            pnlContent.TabIndex = 2;
            // 
            // pnlTodayTransactions
            // 
            pnlTodayTransactions.BackColor = Color.SkyBlue;
            pnlTodayTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayTransactions.Controls.Add(lblTodayTransactions);
            pnlTodayTransactions.Controls.Add(lblTransactionsText);
            pnlTodayTransactions.Location = new Point(233, 177);
            pnlTodayTransactions.Name = "pnlTodayTransactions";
            pnlTodayTransactions.Size = new Size(191, 103);
            pnlTodayTransactions.TabIndex = 4;
            // 
            // lblTodayTransactions
            // 
            lblTodayTransactions.AutoSize = true;
            lblTodayTransactions.BackColor = Color.Coral;
            lblTodayTransactions.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayTransactions.Location = new Point(75, 61);
            lblTodayTransactions.Name = "lblTodayTransactions";
            lblTodayTransactions.Size = new Size(22, 23);
            lblTodayTransactions.TabIndex = 1;
            lblTodayTransactions.Text = "0";
            // 
            // lblTransactionsText
            // 
            lblTransactionsText.AutoSize = true;
            lblTransactionsText.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionsText.ForeColor = Color.DarkBlue;
            lblTransactionsText.Location = new Point(-1, 10);
            lblTransactionsText.Name = "lblTransactionsText";
            lblTransactionsText.Size = new Size(189, 21);
            lblTransactionsText.TabIndex = 0;
            lblTransactionsText.Text = "Today's Transaction";
            // 
            // pnlTotalVehicles
            // 
            pnlTotalVehicles.BackColor = Color.PowderBlue;
            pnlTotalVehicles.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalVehicles.Controls.Add(lblTotalVehicles);
            pnlTotalVehicles.Controls.Add(lblVehiclesText);
            pnlTotalVehicles.Location = new Point(6, 177);
            pnlTotalVehicles.Name = "pnlTotalVehicles";
            pnlTotalVehicles.Size = new Size(191, 103);
            pnlTotalVehicles.TabIndex = 3;
            // 
            // lblTotalVehicles
            // 
            lblTotalVehicles.AutoSize = true;
            lblTotalVehicles.BackColor = Color.Coral;
            lblTotalVehicles.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVehicles.Location = new Point(75, 61);
            lblTotalVehicles.Name = "lblTotalVehicles";
            lblTotalVehicles.Size = new Size(22, 23);
            lblTotalVehicles.TabIndex = 1;
            lblTotalVehicles.Text = "0";
            // 
            // lblVehiclesText
            // 
            lblVehiclesText.AutoSize = true;
            lblVehiclesText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehiclesText.ForeColor = Color.DarkBlue;
            lblVehiclesText.Location = new Point(19, 15);
            lblVehiclesText.Name = "lblVehiclesText";
            lblVehiclesText.Size = new Size(147, 23);
            lblVehiclesText.TabIndex = 0;
            lblVehiclesText.Text = "Total Vehicles";
            // 
            // pnlTotalPlazas
            // 
            pnlTotalPlazas.BackColor = Color.LightCyan;
            pnlTotalPlazas.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalPlazas.Controls.Add(lblTotalPlazas);
            pnlTotalPlazas.Controls.Add(lblPlazasText);
            pnlTotalPlazas.Location = new Point(233, 52);
            pnlTotalPlazas.Name = "pnlTotalPlazas";
            pnlTotalPlazas.Size = new Size(191, 103);
            pnlTotalPlazas.TabIndex = 2;
            // 
            // lblTotalPlazas
            // 
            lblTotalPlazas.AutoSize = true;
            lblTotalPlazas.BackColor = Color.Coral;
            lblTotalPlazas.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPlazas.Location = new Point(75, 61);
            lblTotalPlazas.Name = "lblTotalPlazas";
            lblTotalPlazas.Size = new Size(22, 23);
            lblTotalPlazas.TabIndex = 1;
            lblTotalPlazas.Text = "0";
            // 
            // lblPlazasText
            // 
            lblPlazasText.AutoSize = true;
            lblPlazasText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlazasText.ForeColor = Color.DarkBlue;
            lblPlazasText.Location = new Point(19, 15);
            lblPlazasText.Name = "lblPlazasText";
            lblPlazasText.Size = new Size(167, 23);
            lblPlazasText.TabIndex = 0;
            lblPlazasText.Text = "Total Toll Plazas";
            // 
            // pnlTotalUsers
            // 
            pnlTotalUsers.BackColor = Color.AliceBlue;
            pnlTotalUsers.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalUsers.Controls.Add(lblTotalUsers);
            pnlTotalUsers.Controls.Add(lblUsersText);
            pnlTotalUsers.Location = new Point(6, 52);
            pnlTotalUsers.Name = "pnlTotalUsers";
            pnlTotalUsers.Size = new Size(191, 103);
            pnlTotalUsers.TabIndex = 1;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.BackColor = Color.Coral;
            lblTotalUsers.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalUsers.Location = new Point(75, 61);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(22, 23);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "0";
            // 
            // lblUsersText
            // 
            lblUsersText.AutoSize = true;
            lblUsersText.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsersText.ForeColor = Color.DarkBlue;
            lblUsersText.Location = new Point(37, 15);
            lblUsersText.Name = "lblUsersText";
            lblUsersText.Size = new Size(122, 23);
            lblUsersText.TabIndex = 0;
            lblUsersText.Text = "Total Users";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.Lime;
            lblDashboardTitle.Location = new Point(211, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(358, 36);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard Overview";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(978, 594);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard - Toll Plaza Management System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbpicture2).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlTodayTransactions.ResumeLayout(false);
            pnlTodayTransactions.PerformLayout();
            pnlTotalVehicles.ResumeLayout(false);
            pnlTotalVehicles.PerformLayout();
            pnlTotalPlazas.ResumeLayout(false);
            pnlTotalPlazas.PerformLayout();
            pnlTotalUsers.ResumeLayout(false);
            pnlTotalUsers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Label lblAdminDashboard;
        private PictureBox lbpicture2;
        private Panel pnlSidebar;
        private Label lblMenuTitle;
        private Button btnDashboard;
        private Button btnUsers;
        private Button btnTransactions;
        private Button btnLogout;
        private Button btnReports;
        private Panel pnlContent;
        private Panel pnlTotalUsers;
        private Label lblDashboardTitle;
        private Label lblUsersText;
        private Label lblTotalUsers;
        private Panel pnlTotalPlazas;
        private Label lblTotalPlazas;
        private Label lblPlazasText;
        private Panel pnlTodayTransactions;
        private Label lblTodayTransactions;
        private Label lblTransactionsText;
        private Panel pnlTotalVehicles;
        private Label lblTotalVehicles;
        private Label lblVehiclesText;
        private Button btnTollSetup;
    }
}