namespace TollPlazaManagementSystem
{
    partial class UpdateUserForm
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
            lblTitle = new Label();
            pnlHeader = new Panel();
            lblFullName = new Label();
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
            btnUpdateUser = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.SpringGreen;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(295, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "UPDATE USER";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Salmon;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 66);
            pnlHeader.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(0, 69);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(125, 26);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(131, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(550, 31);
            txtFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(0, 118);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 26);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "UserName:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(131, 116);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(550, 31);
            txtUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(0, 166);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 26);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(550, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(26, 221);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(86, 26);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(131, 221);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(550, 31);
            txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(26, 282);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 26);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(550, 31);
            txtEmail.TabIndex = 11;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(26, 348);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(67, 26);
            lblRole.TabIndex = 12;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(125, 341);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(550, 33);
            cmbRole.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(0, 406);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(133, 26);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Acc status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(131, 404);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(550, 33);
            cmbStatus.TabIndex = 15;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.Orchid;
            btnUpdateUser.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateUser.Location = new Point(26, 484);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(194, 34);
            btnUpdateUser.TabIndex = 16;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Pink;
            btnCancel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(405, 484);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 34);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateUser);
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
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            Load += UpdateUserForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel pnlHeader;
        private Label lblFullName;
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
        private Button btnUpdateUser;
        private Button btnCancel;
    }
}