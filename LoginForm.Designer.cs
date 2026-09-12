namespace TollPlazaManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLeft = new Panel();
            lblUsername = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            picWatermark = new PictureBox();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWatermark).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.CornflowerBlue;
            pnlLeft.Controls.Add(picWatermark);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(430, 594);
            pnlLeft.TabIndex = 0;
            pnlLeft.Paint += panel1_Paint;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(470, 236);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(455, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 158);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Toll Plaza Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label2_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Lime;
            lblSubtitle.Location = new Point(547, 167);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(310, 30);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to continue";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(470, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(485, 31);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(470, 342);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(470, 387);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(485, 31);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Magenta;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Yellow;
            btnLogin.Location = new Point(617, 456);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkKhaki;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(617, 530);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 35);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // picWatermark
            // 
            picWatermark.BackColor = Color.Transparent;
            picWatermark.Image = (Image)resources.GetObject("picWatermark.Image");
            picWatermark.Location = new Point(3, 12);
            picWatermark.Name = "picWatermark";
            picWatermark.Size = new Size(427, 565);
            picWatermark.SizeMode = PictureBoxSizeMode.Zoom;
            picWatermark.TabIndex = 0;
            picWatermark.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(978, 594);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlLeft);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 650);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toll Plaza Management System - Login";
            Load += LoginForm_Load;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWatermark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLeft;
        private Label lblUsername;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox picWatermark;
    }
}
