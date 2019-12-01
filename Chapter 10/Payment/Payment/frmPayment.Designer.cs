namespace Payment
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCreditCardType = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.lblCreditNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBillCustomer);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(156, 23);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(84, 17);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.Text = "Bill customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            this.rdoBillCustomer.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(17, 23);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(76, 17);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // lblCreditCardType
            // 
            this.lblCreditCardType.AutoSize = true;
            this.lblCreditCardType.Location = new System.Drawing.Point(12, 77);
            this.lblCreditCardType.Name = "lblCreditCardType";
            this.lblCreditCardType.Size = new System.Drawing.Size(84, 13);
            this.lblCreditCardType.TabIndex = 1;
            this.lblCreditCardType.Text = "Credit card type:";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.Location = new System.Drawing.Point(102, 77);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(178, 69);
            this.lstCreditCardType.TabIndex = 2;
            // 
            // lblCreditNumber
            // 
            this.lblCreditNumber.AutoSize = true;
            this.lblCreditNumber.Location = new System.Drawing.Point(12, 160);
            this.lblCreditNumber.Name = "lblCreditNumber";
            this.lblCreditNumber.Size = new System.Drawing.Size(75, 13);
            this.lblCreditNumber.TabIndex = 3;
            this.lblCreditNumber.Text = "Credit number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(102, 156);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(178, 20);
            this.txtCardNumber.TabIndex = 4;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(12, 190);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(80, 13);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "Expiration date:";
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationYear.FormattingEnabled = true;
            this.cboExpirationYear.Location = new System.Drawing.Point(197, 186);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(83, 21);
            this.cboExpirationYear.TabIndex = 7;
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationMonth.FormattingEnabled = true;
            this.cboExpirationMonth.Location = new System.Drawing.Point(102, 186);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(83, 21);
            this.cboExpirationMonth.TabIndex = 6;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(12, 220);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(158, 17);
            this.chkDefault.TabIndex = 8;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(102, 252);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 22);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 22);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 284);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCreditNumber);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.lblCreditCardType);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label lblCreditCardType;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label lblCreditNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ComboBox cboExpirationYear;
        private System.Windows.Forms.ComboBox cboExpirationMonth;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}