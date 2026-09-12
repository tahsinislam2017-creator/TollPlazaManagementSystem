namespace TollPlazaManagementSystem
{
    partial class AddUserForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblFullName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtFullName = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSaveUser = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.BlueViolet;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(628, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Lavender;
            lblTitle.Enabled = false;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(187, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ADD NEW USER";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(0, 99);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(125, 26);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.WhiteSmoke;
            txtFullName.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(124, 99);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(470, 31);
            txtFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(0, 157);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 26);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "UserName:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(124, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(470, 31);
            txtUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(0, 211);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 26);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(124, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(470, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(-1, 273);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(86, 26);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(124, 273);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(470, 31);
            txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(0, 328);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 26);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(124, 327);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(470, 31);
            txtEmail.TabIndex = 11;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(0, 383);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(67, 26);
            lblRole.TabIndex = 12;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.Gray;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(124, 381);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(470, 33);
            cmbRole.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(0, 433);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(114, 21);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "ACC status:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.Gray;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.ForeColor = SystemColors.Info;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(124, 433);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(470, 33);
            cmbStatus.TabIndex = 15;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.OrangeRed;
            btnSaveUser.FlatAppearance.BorderSize = 0;
            btnSaveUser.FlatStyle = FlatStyle.Flat;
            btnSaveUser.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveUser.Location = new Point(72, 498);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(156, 34);
            btnSaveUser.TabIndex = 16;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = false;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Turquoise;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(336, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 34);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(628, 544);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveUser);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New User";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblFullName;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSaveUser;
        private Button btnCancel;
    }
}