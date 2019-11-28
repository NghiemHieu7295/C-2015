namespace FutureValue
{
    partial class Form1
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
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyRate = new System.Windows.Forms.TextBox();
            this.lblYearlyRate = new System.Windows.Forms.Label();
            this.txtNumOfYears = new System.Windows.Forms.TextBox();
            this.lblNumOfYears = new System.Windows.Forms.Label();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.AutoSize = true;
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(12, 12);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(107, 12);
            this.lblMonthlyInvestment.TabIndex = 0;
            this.lblMonthlyInvestment.Text = "Monthly Investment:";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(125, 9);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 19);
            this.txtMonthlyInvestment.TabIndex = 1;
            // 
            // txtYearlyRate
            // 
            this.txtYearlyRate.Location = new System.Drawing.Point(125, 34);
            this.txtYearlyRate.Name = "txtYearlyRate";
            this.txtYearlyRate.Size = new System.Drawing.Size(100, 19);
            this.txtYearlyRate.TabIndex = 3;
            // 
            // lblYearlyRate
            // 
            this.lblYearlyRate.AutoSize = true;
            this.lblYearlyRate.Location = new System.Drawing.Point(12, 37);
            this.lblYearlyRate.Name = "lblYearlyRate";
            this.lblYearlyRate.Size = new System.Drawing.Size(110, 12);
            this.lblYearlyRate.TabIndex = 2;
            this.lblYearlyRate.Text = "Yearly Interest Rate:";
            // 
            // txtNumOfYears
            // 
            this.txtNumOfYears.Location = new System.Drawing.Point(125, 59);
            this.txtNumOfYears.Name = "txtNumOfYears";
            this.txtNumOfYears.Size = new System.Drawing.Size(100, 19);
            this.txtNumOfYears.TabIndex = 5;
            // 
            // lblNumOfYears
            // 
            this.lblNumOfYears.AutoSize = true;
            this.lblNumOfYears.Location = new System.Drawing.Point(12, 62);
            this.lblNumOfYears.Name = "lblNumOfYears";
            this.lblNumOfYears.Size = new System.Drawing.Size(93, 12);
            this.lblNumOfYears.TabIndex = 4;
            this.lblNumOfYears.Text = "Number of Years:";
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(125, 84);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 19);
            this.txtFutureValue.TabIndex = 7;
            this.txtFutureValue.TabStop = false;
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.AutoSize = true;
            this.lblFutureValue.Location = new System.Drawing.Point(12, 87);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(73, 12);
            this.lblFutureValue.TabIndex = 6;
            this.lblFutureValue.Text = "Future Value:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(92, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(66, 21);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(164, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 21);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(239, 151);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.txtNumOfYears);
            this.Controls.Add(this.lblNumOfYears);
            this.Controls.Add(this.txtYearlyRate);
            this.Controls.Add(this.lblYearlyRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlyInvestment;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyRate;
        private System.Windows.Forms.Label lblYearlyRate;
        private System.Windows.Forms.TextBox txtNumOfYears;
        private System.Windows.Forms.Label lblNumOfYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

