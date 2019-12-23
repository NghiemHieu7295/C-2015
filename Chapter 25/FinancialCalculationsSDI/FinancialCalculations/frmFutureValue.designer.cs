namespace FinancialCalculations
{
    partial class frmFutureValue
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
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(130, 90);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(86, 19);
            this.txtFutureValue.TabIndex = 30;
            this.txtFutureValue.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(139, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 21);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(52, 122);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 21);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(132, 64);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(84, 19);
            this.txtYears.TabIndex = 27;
            this.txtYears.Tag = "Number of Years";
            this.txtYears.Text = "3";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(132, 39);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(84, 19);
            this.txtInterestRate.TabIndex = 26;
            this.txtInterestRate.Tag = "Yearly Interest Rate";
            this.txtInterestRate.Text = "3";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(132, 13);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(84, 19);
            this.txtMonthlyInvestment.TabIndex = 25;
            this.txtMonthlyInvestment.Tag = "Monthly Investment";
            this.txtMonthlyInvestment.Text = "100";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Future Value:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Number of Years:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yearly Interest Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Monthly Investment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFutureValue
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(231, 156);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFutureValue";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}