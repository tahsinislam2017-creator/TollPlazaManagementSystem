namespace TollPlazaManagementSystem
{
    partial class UsersManagementForm
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagementForm));
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            btnRefresh = new Button();
            dgvUsers = new DataGridView();
            pnlHeader = new Panel();
            lbpicture3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbpicture3).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(375, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(443, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "USERS MANAGEMENT";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSearch.Location = new Point(31, 138);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(155, 32);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search User:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(212, 132);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(562, 37);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Goldenrod;
            btnAddUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddUser.Location = new Point(31, 204);
            btnAddUser.Margin = new Padding(4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(175, 59);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.HotPink;
            btnUpdateUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdateUser.Location = new Point(225, 204);
            btnUpdateUser.Margin = new Padding(4);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(188, 59);
            btnUpdateUser.TabIndex = 4;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Aquamarine;
            btnDeleteUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteUser.Location = new Point(431, 204);
            btnDeleteUser.Margin = new Padding(4);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(188, 59);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.Location = new Point(638, 204);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(175, 59);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(31, 296);
            dgvUsers.Margin = new Padding(4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1162, 500);
            dgvUsers.TabIndex = 7;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Olive;
            pnlHeader.Controls.Add(lbpicture3);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1225, 108);
            pnlHeader.TabIndex = 8;
            // 
            // lbpicture3
            // 
            lbpicture3.BackColor = Color.Transparent;
            lbpicture3.Image = (Image)resources.GetObject("lbpicture3.Image");
            lbpicture3.Location = new Point(12, 12);
            lbpicture3.Name = "lbpicture3";
            lbpicture3.Size = new Size(194, 75);
            lbpicture3.SizeMode = PictureBoxSizeMode.StretchImage;
            lbpicture3.TabIndex = 0;
            lbpicture3.TabStop = false;
            // 
            // UsersManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1225, 829);
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAddUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnRefresh);
            Controls.Add(dgvUsers);
            Controls.Add(pnlHeader);
            Margin = new Padding(4);
            Name = "UsersManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users Management";
            Load += UsersManagementForm_Load;
            Click += btnRefresh_Click;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lbpicture3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private Button btnRefresh;
        private DataGridView dgvUsers;
        private Panel pnlHeader;
        private PictureBox lbpicture3;
    }
}