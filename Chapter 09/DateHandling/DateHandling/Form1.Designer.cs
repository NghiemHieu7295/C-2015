namespace DateHandling
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateAge = new System.Windows.Forms.Button();
            this.btnCalculateDueDays = new System.Windows.Forms.Button();
            this.txtFutureDate = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(234, 72);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 18);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateAge
            // 
            this.btnCalculateAge.Location = new System.Drawing.Point(234, 40);
            this.btnCalculateAge.Name = "btnCalculateAge";
            this.btnCalculateAge.Size = new System.Drawing.Size(153, 18);
            this.btnCalculateAge.TabIndex = 10;
            this.btnCalculateAge.Text = "Calculate &Age";
            this.btnCalculateAge.Click += new System.EventHandler(this.btnCalculateAge_Click);
            // 
            // btnCalculateDueDays
            // 
            this.btnCalculateDueDays.Location = new System.Drawing.Point(234, 8);
            this.btnCalculateDueDays.Name = "btnCalculateDueDays";
            this.btnCalculateDueDays.Size = new System.Drawing.Size(153, 19);
            this.btnCalculateDueDays.TabIndex = 8;
            this.btnCalculateDueDays.Text = "Calculate &Due Days";
            this.btnCalculateDueDays.Click += new System.EventHandler(this.btnCalculateDueDays_Click);
            // 
            // txtFutureDate
            // 
            this.txtFutureDate.Location = new System.Drawing.Point(136, 8);
            this.txtFutureDate.Name = "txtFutureDate";
            this.txtFutureDate.Size = new System.Drawing.Size(83, 19);
            this.txtFutureDate.TabIndex = 9;
            this.txtFutureDate.TextChanged += new System.EventHandler(this.txtFutureDate_TextChanged);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(136, 40);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(83, 19);
            this.txtBirthDate.TabIndex = 5;
            this.txtBirthDate.TextChanged += new System.EventHandler(this.txtBirthDate_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter a future date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a birth date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculateDueDays;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(402, 102);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateAge);
            this.Controls.Add(this.btnCalculateDueDays);
            this.Controls.Add(this.txtFutureDate);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateAge;
        private System.Windows.Forms.Button btnCalculateDueDays;
        private System.Windows.Forms.TextBox txtFutureDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

