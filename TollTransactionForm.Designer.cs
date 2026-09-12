namespace TollPlazaManagementSystem
{
    partial class TollTransactionForm
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
            pnlTransactionHeader = new FlowLayoutPanel();
            lblTransactionTitle = new Label();
            lblTransactionDate = new Label();
            pnlTransactionDetails = new Panel();
            btnBackToOperator = new Button();
            btnClearTransaction = new Button();
            btnSaveTransaction = new Button();
            cmbPaymentMethod = new ComboBox();
            lblPaymentMethod = new TextBox();
            lblTollAmount = new TextBox();
            lblVehicleCategory = new TextBox();
            lblVehicleNumber = new TextBox();
            lblTollBooth = new TextBox();
            lblTollPlaza = new TextBox();
            txtTollAmount = new TextBox();
            cmbVehicleCategory = new ComboBox();
            txtVehicleNumber = new TextBox();
            cmbTollBooth = new ComboBox();
            cmbTollPlaza = new ComboBox();
            pnlTransactionHeader.SuspendLayout();
            pnlTransactionDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTransactionHeader
            // 
            pnlTransactionHeader.BackColor = Color.Cyan;
            pnlTransactionHeader.Controls.Add(lblTransactionTitle);
            pnlTransactionHeader.Controls.Add(lblTransactionDate);
            pnlTransactionHeader.Dock = DockStyle.Top;
            pnlTransactionHeader.Location = new Point(0, 0);
            pnlTransactionHeader.Name = "pnlTransactionHeader";
            pnlTransactionHeader.Size = new Size(878, 85);
            pnlTransactionHeader.TabIndex = 0;
            // 
            // lblTransactionTitle
            // 
            lblTransactionTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTransactionTitle.AutoSize = true;
            lblTransactionTitle.BackColor = Color.Plum;
            lblTransactionTitle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionTitle.Location = new Point(3, 0);
            lblTransactionTitle.Name = "lblTransactionTitle";
            lblTransactionTitle.Size = new Size(321, 28);
            lblTransactionTitle.TabIndex = 0;
            lblTransactionTitle.Text = "NEW TOLL TRANSACTION";
            lblTransactionTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.BackColor = Color.Aquamarine;
            lblTransactionDate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionDate.Location = new Point(330, 0);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(137, 21);
            lblTransactionDate.TabIndex = 1;
            lblTransactionDate.Text = "Date and Time";
            lblTransactionDate.Click += lblTransactionDate_Click;
            // 
            // pnlTransactionDetails
            // 
            pnlTransactionDetails.BackColor = Color.Bisque;
            pnlTransactionDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactionDetails.Controls.Add(btnBackToOperator);
            pnlTransactionDetails.Controls.Add(btnClearTransaction);
            pnlTransactionDetails.Controls.Add(btnSaveTransaction);
            pnlTransactionDetails.Controls.Add(cmbPaymentMethod);
            pnlTransactionDetails.Controls.Add(lblPaymentMethod);
            pnlTransactionDetails.Controls.Add(lblTollAmount);
            pnlTransactionDetails.Controls.Add(lblVehicleCategory);
            pnlTransactionDetails.Controls.Add(lblVehicleNumber);
            pnlTransactionDetails.Controls.Add(lblTollBooth);
            pnlTransactionDetails.Controls.Add(lblTollPlaza);
            pnlTransactionDetails.Controls.Add(txtTollAmount);
            pnlTransactionDetails.Controls.Add(cmbVehicleCategory);
            pnlTransactionDetails.Controls.Add(txtVehicleNumber);
            pnlTransactionDetails.Controls.Add(cmbTollBooth);
            pnlTransactionDetails.Controls.Add(cmbTollPlaza);
            pnlTransactionDetails.Dock = DockStyle.Fill;
            pnlTransactionDetails.Location = new Point(0, 85);
            pnlTransactionDetails.Name = "pnlTransactionDetails";
            pnlTransactionDetails.Size = new Size(878, 459);
            pnlTransactionDetails.TabIndex = 1;
            // 
            // btnBackToOperator
            // 
            btnBackToOperator.BackColor = Color.LightPink;
            btnBackToOperator.FlatAppearance.BorderSize = 0;
            btnBackToOperator.FlatStyle = FlatStyle.Flat;
            btnBackToOperator.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackToOperator.ForeColor = Color.Magenta;
            btnBackToOperator.Location = new Point(550, 412);
            btnBackToOperator.Name = "btnBackToOperator";
            btnBackToOperator.Size = new Size(236, 34);
            btnBackToOperator.TabIndex = 14;
            btnBackToOperator.Text = "BACK";
            btnBackToOperator.UseVisualStyleBackColor = false;
            btnBackToOperator.Click += btnBackToOperator_Click;
            // 
            // btnClearTransaction
            // 
            btnClearTransaction.BackColor = Color.Navy;
            btnClearTransaction.FlatAppearance.BorderSize = 0;
            btnClearTransaction.FlatStyle = FlatStyle.Flat;
            btnClearTransaction.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearTransaction.ForeColor = Color.Yellow;
            btnClearTransaction.Location = new Point(281, 412);
            btnClearTransaction.Name = "btnClearTransaction";
            btnClearTransaction.Size = new Size(236, 34);
            btnClearTransaction.TabIndex = 13;
            btnClearTransaction.Text = "CLEAR";
            btnClearTransaction.UseVisualStyleBackColor = false;
            btnClearTransaction.Click += btnClearTransaction_Click;
            // 
            // btnSaveTransaction
            // 
            btnSaveTransaction.BackColor = Color.OrangeRed;
            btnSaveTransaction.FlatAppearance.BorderSize = 0;
            btnSaveTransaction.FlatStyle = FlatStyle.Flat;
            btnSaveTransaction.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveTransaction.Location = new Point(11, 412);
            btnSaveTransaction.Name = "btnSaveTransaction";
            btnSaveTransaction.Size = new Size(236, 34);
            btnSaveTransaction.TabIndex = 12;
            btnSaveTransaction.Text = "Save Transaction";
            btnSaveTransaction.UseVisualStyleBackColor = false;
            btnSaveTransaction.Click += btnSaveTransaction_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.BackColor = Color.GreenYellow;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "Mobile Banking", "Electronic Toll" });
            cmbPaymentMethod.Location = new Point(194, 337);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(323, 34);
            cmbPaymentMethod.TabIndex = 11;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.BackColor = Color.GreenYellow;
            lblPaymentMethod.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(3, 340);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(185, 31);
            lblPaymentMethod.TabIndex = 10;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblTollAmount
            // 
            lblTollAmount.BackColor = Color.GreenYellow;
            lblTollAmount.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTollAmount.Location = new Point(3, 275);
            lblTollAmount.Name = "lblTollAmount";
            lblTollAmount.Size = new Size(134, 31);
            lblTollAmount.TabIndex = 9;
            lblTollAmount.Text = "Toll Amount:";
            // 
            // lblVehicleCategory
            // 
            lblVehicleCategory.BackColor = Color.GreenYellow;
            lblVehicleCategory.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleCategory.Location = new Point(2, 201);
            lblVehicleCategory.Name = "lblVehicleCategory";
            lblVehicleCategory.Size = new Size(186, 31);
            lblVehicleCategory.TabIndex = 8;
            lblVehicleCategory.Text = "Vehicle Category:";
            // 
            // lblVehicleNumber
            // 
            lblVehicleNumber.BackColor = Color.GreenYellow;
            lblVehicleNumber.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleNumber.Location = new Point(3, 129);
            lblVehicleNumber.Name = "lblVehicleNumber";
            lblVehicleNumber.Size = new Size(171, 31);
            lblVehicleNumber.TabIndex = 7;
            lblVehicleNumber.Text = "Vehicle Number:";
            // 
            // lblTollBooth
            // 
            lblTollBooth.BackColor = Color.GreenYellow;
            lblTollBooth.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTollBooth.Location = new Point(2, 63);
            lblTollBooth.Name = "lblTollBooth";
            lblTollBooth.Size = new Size(108, 31);
            lblTollBooth.TabIndex = 6;
            lblTollBooth.Text = "Toll Booth:";
            // 
            // lblTollPlaza
            // 
            lblTollPlaza.BackColor = Color.GreenYellow;
            lblTollPlaza.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTollPlaza.Location = new Point(3, 8);
            lblTollPlaza.Name = "lblTollPlaza";
            lblTollPlaza.Size = new Size(108, 31);
            lblTollPlaza.TabIndex = 5;
            lblTollPlaza.Text = "Toll Plaza:";
            // 
            // txtTollAmount
            // 
            txtTollAmount.BackColor = SystemColors.Control;
            txtTollAmount.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTollAmount.ForeColor = SystemColors.WindowText;
            txtTollAmount.Location = new Point(143, 275);
            txtTollAmount.Name = "txtTollAmount";
            txtTollAmount.ReadOnly = true;
            txtTollAmount.Size = new Size(701, 33);
            txtTollAmount.TabIndex = 2;
            txtTollAmount.Text = "0.00";
            txtTollAmount.TextChanged += txtTollAmount_TextChanged;
            // 
            // cmbVehicleCategory
            // 
            cmbVehicleCategory.BackColor = Color.White;
            cmbVehicleCategory.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVehicleCategory.FormattingEnabled = true;
            cmbVehicleCategory.Location = new Point(194, 201);
            cmbVehicleCategory.Name = "cmbVehicleCategory";
            cmbVehicleCategory.Size = new Size(323, 34);
            cmbVehicleCategory.TabIndex = 3;
            cmbVehicleCategory.SelectedIndexChanged += cmbVehicleCategory_SelectedIndexChanged_1;
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.BackColor = SystemColors.Control;
            txtVehicleNumber.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleNumber.ForeColor = SystemColors.WindowText;
            txtVehicleNumber.Location = new Point(175, 129);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(669, 33);
            txtVehicleNumber.TabIndex = 0;
            // 
            // cmbTollBooth
            // 
            cmbTollBooth.BackColor = Color.GreenYellow;
            cmbTollBooth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTollBooth.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTollBooth.FormattingEnabled = true;
            cmbTollBooth.Location = new Point(117, 63);
            cmbTollBooth.Name = "cmbTollBooth";
            cmbTollBooth.Size = new Size(323, 34);
            cmbTollBooth.TabIndex = 1;
            // 
            // cmbTollPlaza
            // 
            cmbTollPlaza.BackColor = Color.YellowGreen;
            cmbTollPlaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTollPlaza.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTollPlaza.FormattingEnabled = true;
            cmbTollPlaza.Location = new Point(117, 8);
            cmbTollPlaza.Name = "cmbTollPlaza";
            cmbTollPlaza.Size = new Size(323, 34);
            cmbTollPlaza.TabIndex = 0;
            cmbTollPlaza.SelectedIndexChanged += cmbTollPlaza_SelectedIndexChanged;
            // 
            // TollTransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(878, 544);
            Controls.Add(pnlTransactionDetails);
            Controls.Add(pnlTransactionHeader);
            Name = "TollTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Toll Transaction";
            WindowState = FormWindowState.Maximized;
            Load += TollTransactionForm_Load;
            pnlTransactionHeader.ResumeLayout(false);
            pnlTransactionHeader.PerformLayout();
            pnlTransactionDetails.ResumeLayout(false);
            pnlTransactionDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlTransactionHeader;
        private Label lblTransactionTitle;
        private Label lblTransactionDate;
        private Panel pnlTransactionDetails;
        private ComboBox cmbVehicleCategory;
        private TextBox txtVehicleNumber;
        private ComboBox cmbTollBooth;
        private ComboBox cmbTollPlaza;
        private TextBox txtTollAmount;
        private TextBox lblTollBooth;
        private TextBox lblTollPlaza;
        private TextBox lblTollAmount;
        private TextBox lblVehicleCategory;
        private TextBox lblVehicleNumber;
        private TextBox lblPaymentMethod;
        private Button btnClearTransaction;
        private Button btnSaveTransaction;
        private ComboBox cmbPaymentMethod;
        private Button btnBackToOperator;
    }
}