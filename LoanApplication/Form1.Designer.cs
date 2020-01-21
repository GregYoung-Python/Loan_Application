namespace LoanApplication
{
    partial class FrmLoanProcess
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.cmbLoan = new System.Windows.Forms.ComboBox();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.lblHomeDetails = new System.Windows.Forms.Label();
            this.lblSquareFeet = new System.Windows.Forms.Label();
            this.lblNumberOfRooms = new System.Windows.Forms.Label();
            this.txtSquareFeet = new System.Windows.Forms.TextBox();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblLoanNumber = new System.Windows.Forms.Label();
            this.txtLoanNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 26);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 63);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(9, 98);
            this.lblLoanAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(70, 13);
            this.lblLoanAmount.TabIndex = 2;
            this.lblLoanAmount.Text = "Loan Amount";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(9, 138);
            this.lblInterestRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(68, 13);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate";
            this.lblInterestRate.Visible = false;
            // 
            // cmbLoan
            // 
            this.cmbLoan.FormattingEnabled = true;
            this.cmbLoan.Items.AddRange(new object[] {
            "Home",
            "Auto"});
            this.cmbLoan.Location = new System.Drawing.Point(366, 27);
            this.cmbLoan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoan.Name = "cmbLoan";
            this.cmbLoan.Size = new System.Drawing.Size(127, 21);
            this.cmbLoan.TabIndex = 4;
            this.cmbLoan.SelectedIndexChanged += new System.EventHandler(this.cmbLoan_SelectedIndexChanged);
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(296, 101);
            this.lblNumberOfYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(86, 13);
            this.lblNumberOfYears.TabIndex = 5;
            this.lblNumberOfYears.Text = "Number of Years";
            this.lblNumberOfYears.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(320, 327);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(115, 56);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(112, 27);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(122, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 58);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(122, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(112, 98);
            this.txtLoanAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(122, 20);
            this.txtLoanAmount.TabIndex = 9;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(112, 136);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(122, 20);
            this.txtInterestRate.TabIndex = 10;
            this.txtInterestRate.Visible = false;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(417, 91);
            this.txtNumberOfYears.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(76, 20);
            this.txtNumberOfYears.TabIndex = 11;
            this.txtNumberOfYears.Visible = false;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Location = new System.Drawing.Point(365, 9);
            this.lblLoanType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(70, 13);
            this.lblLoanType.TabIndex = 12;
            this.lblLoanType.Text = "Type of Loan";
            // 
            // lblHomeDetails
            // 
            this.lblHomeDetails.AutoSize = true;
            this.lblHomeDetails.Location = new System.Drawing.Point(377, 200);
            this.lblHomeDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeDetails.Name = "lblHomeDetails";
            this.lblHomeDetails.Size = new System.Drawing.Size(70, 13);
            this.lblHomeDetails.TabIndex = 13;
            this.lblHomeDetails.Text = "Home Details";
            this.lblHomeDetails.Visible = false;
            // 
            // lblSquareFeet
            // 
            this.lblSquareFeet.AutoSize = true;
            this.lblSquareFeet.Location = new System.Drawing.Point(340, 263);
            this.lblSquareFeet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSquareFeet.Name = "lblSquareFeet";
            this.lblSquareFeet.Size = new System.Drawing.Size(65, 13);
            this.lblSquareFeet.TabIndex = 14;
            this.lblSquareFeet.Text = "Square Feet";
            this.lblSquareFeet.Visible = false;
            // 
            // lblNumberOfRooms
            // 
            this.lblNumberOfRooms.AutoSize = true;
            this.lblNumberOfRooms.Location = new System.Drawing.Point(343, 295);
            this.lblNumberOfRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfRooms.Name = "lblNumberOfRooms";
            this.lblNumberOfRooms.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfRooms.TabIndex = 15;
            this.lblNumberOfRooms.Text = "Number of Rooms";
            this.lblNumberOfRooms.Visible = false;
            // 
            // txtSquareFeet
            // 
            this.txtSquareFeet.Location = new System.Drawing.Point(453, 259);
            this.txtSquareFeet.Margin = new System.Windows.Forms.Padding(2);
            this.txtSquareFeet.Name = "txtSquareFeet";
            this.txtSquareFeet.Size = new System.Drawing.Size(125, 20);
            this.txtSquareFeet.TabIndex = 17;
            this.txtSquareFeet.Visible = false;
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Location = new System.Drawing.Point(453, 291);
            this.txtNumberOfRooms.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(125, 20);
            this.txtNumberOfRooms.TabIndex = 18;
            this.txtNumberOfRooms.Visible = false;
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Location = new System.Drawing.Point(83, 215);
            this.lblCarDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(58, 13);
            this.lblCarDetails.TabIndex = 19;
            this.lblCarDetails.Text = "Car Details";
            this.lblCarDetails.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 255);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(26, 285);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 21;
            this.lblMake.Text = "Make";
            this.lblMake.Visible = false;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(26, 349);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 22;
            this.lblModel.Text = "Model";
            this.lblModel.Visible = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(86, 255);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(148, 20);
            this.txtYear.TabIndex = 24;
            this.txtYear.Visible = false;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(86, 285);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(148, 20);
            this.txtMake.TabIndex = 25;
            this.txtMake.Visible = false;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(86, 349);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(148, 20);
            this.txtModel.TabIndex = 26;
            this.txtModel.Visible = false;
            // 
            // lblLoanNumber
            // 
            this.lblLoanNumber.AutoSize = true;
            this.lblLoanNumber.Location = new System.Drawing.Point(11, 167);
            this.lblLoanNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanNumber.Name = "lblLoanNumber";
            this.lblLoanNumber.Size = new System.Drawing.Size(71, 13);
            this.lblLoanNumber.TabIndex = 27;
            this.lblLoanNumber.Text = "Loan Number";
            this.lblLoanNumber.Visible = false;
            // 
            // txtLoanNumber
            // 
            this.txtLoanNumber.Location = new System.Drawing.Point(112, 167);
            this.txtLoanNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanNumber.Name = "txtLoanNumber";
            this.txtLoanNumber.Size = new System.Drawing.Size(122, 20);
            this.txtLoanNumber.TabIndex = 28;
            this.txtLoanNumber.Visible = false;
            // 
            // FrmLoanProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 466);
            this.Controls.Add(this.txtLoanNumber);
            this.Controls.Add(this.lblLoanNumber);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCarDetails);
            this.Controls.Add(this.txtNumberOfRooms);
            this.Controls.Add(this.txtSquareFeet);
            this.Controls.Add(this.lblNumberOfRooms);
            this.Controls.Add(this.lblSquareFeet);
            this.Controls.Add(this.lblHomeDetails);
            this.Controls.Add(this.lblLoanType);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.cmbLoan);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLoanProcess";
            this.Text = "Customer Kiosh";
            this.Load += new System.EventHandler(this.FrmLoanProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.ComboBox cmbLoan;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Label lblHomeDetails;
        private System.Windows.Forms.Label lblSquareFeet;
        private System.Windows.Forms.Label lblNumberOfRooms;
        private System.Windows.Forms.TextBox txtSquareFeet;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblLoanNumber;
        private System.Windows.Forms.TextBox txtLoanNumber;
    }
}

