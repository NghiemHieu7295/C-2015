namespace InvoiceTotal
{
	partial class frmInvoiceTotal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblNumberOfInvoices = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.lblTotalOfInvoices = new System.Windows.Forms.Label();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.lblInvoiceAverage = new System.Windows.Forms.Label();
            this.btnClearTotal = new System.Windows.Forms.Button();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.lblEnterSubTotal = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.lblLargestInvoice = new System.Windows.Forms.Label();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.lblSmallestInvoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Subtotal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Percent:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 5;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 6;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(106, 39);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 19);
            this.txtSubtotal.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(179, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 21);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(387, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 21);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(106, 63);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 19);
            this.txtDiscountPercent.TabIndex = 10;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(106, 88);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 19);
            this.txtDiscountAmount.TabIndex = 11;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(106, 112);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 19);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            // 
            // lblNumberOfInvoices
            // 
            this.lblNumberOfInvoices.AutoSize = true;
            this.lblNumberOfInvoices.Location = new System.Drawing.Point(235, 18);
            this.lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            this.lblNumberOfInvoices.Size = new System.Drawing.Size(106, 12);
            this.lblNumberOfInvoices.TabIndex = 13;
            this.lblNumberOfInvoices.Text = "Number of invoices:";
            this.lblNumberOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(347, 15);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(115, 19);
            this.txtNumberOfInvoices.TabIndex = 14;
            this.txtNumberOfInvoices.TabStop = false;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(347, 39);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(115, 19);
            this.txtTotalOfInvoices.TabIndex = 16;
            this.txtTotalOfInvoices.TabStop = false;
            // 
            // lblTotalOfInvoices
            // 
            this.lblTotalOfInvoices.AutoSize = true;
            this.lblTotalOfInvoices.Location = new System.Drawing.Point(235, 42);
            this.lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            this.lblTotalOfInvoices.Size = new System.Drawing.Size(93, 12);
            this.lblTotalOfInvoices.TabIndex = 15;
            this.lblTotalOfInvoices.Text = "Total of invoices:";
            this.lblTotalOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(347, 63);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(115, 19);
            this.txtInvoiceAverage.TabIndex = 18;
            this.txtInvoiceAverage.TabStop = false;
            // 
            // lblInvoiceAverage
            // 
            this.lblInvoiceAverage.AutoSize = true;
            this.lblInvoiceAverage.Location = new System.Drawing.Point(235, 66);
            this.lblInvoiceAverage.Name = "lblInvoiceAverage";
            this.lblInvoiceAverage.Size = new System.Drawing.Size(87, 12);
            this.lblInvoiceAverage.TabIndex = 17;
            this.lblInvoiceAverage.Text = "Invoice average:";
            this.lblInvoiceAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearTotal
            // 
            this.btnClearTotal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearTotal.Location = new System.Drawing.Point(271, 144);
            this.btnClearTotal.Name = "btnClearTotal";
            this.btnClearTotal.Size = new System.Drawing.Size(97, 21);
            this.btnClearTotal.TabIndex = 19;
            this.btnClearTotal.Text = "Clear Totals";
            this.btnClearTotal.Click += new System.EventHandler(this.btnClearTotal_Click);
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Location = new System.Drawing.Point(106, 15);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 19);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // lblEnterSubTotal
            // 
            this.lblEnterSubTotal.AutoSize = true;
            this.lblEnterSubTotal.Location = new System.Drawing.Point(11, 18);
            this.lblEnterSubTotal.Name = "lblEnterSubTotal";
            this.lblEnterSubTotal.Size = new System.Drawing.Size(80, 12);
            this.lblEnterSubTotal.TabIndex = 20;
            this.lblEnterSubTotal.Text = "Enter Subtotal:";
            this.lblEnterSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(347, 88);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(115, 19);
            this.txtLargestInvoice.TabIndex = 22;
            this.txtLargestInvoice.TabStop = false;
            // 
            // lblLargestInvoice
            // 
            this.lblLargestInvoice.AutoSize = true;
            this.lblLargestInvoice.Location = new System.Drawing.Point(235, 91);
            this.lblLargestInvoice.Name = "lblLargestInvoice";
            this.lblLargestInvoice.Size = new System.Drawing.Size(85, 12);
            this.lblLargestInvoice.TabIndex = 21;
            this.lblLargestInvoice.Text = "Largest invoice:";
            this.lblLargestInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Location = new System.Drawing.Point(347, 112);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(115, 19);
            this.txtSmallestInvoice.TabIndex = 24;
            this.txtSmallestInvoice.TabStop = false;
            // 
            // lblSmallestInvoice
            // 
            this.lblSmallestInvoice.AutoSize = true;
            this.lblSmallestInvoice.Location = new System.Drawing.Point(235, 115);
            this.lblSmallestInvoice.Name = "lblSmallestInvoice";
            this.lblSmallestInvoice.Size = new System.Drawing.Size(91, 12);
            this.lblSmallestInvoice.TabIndex = 23;
            this.lblSmallestInvoice.Text = "Smallest invoice:";
            this.lblSmallestInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(474, 176);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.lblSmallestInvoice);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.lblLargestInvoice);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.lblEnterSubTotal);
            this.Controls.Add(this.btnClearTotal);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.lblInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.lblTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.lblNumberOfInvoices);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtDiscountPercent;
		private System.Windows.Forms.TextBox txtDiscountAmount;
		private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblNumberOfInvoices;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.Label lblTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.Button btnClearTotal;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label lblEnterSubTotal;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.Label lblLargestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.Label lblSmallestInvoice;
    }
}

