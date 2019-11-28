using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal futureValue = 0m;

            decimal monthlyInvestment = Decimal.Parse(txtMonthlyInvestment.Text);
            decimal yearlyRate = Decimal.Parse(txtYearlyRate.Text);
            int numOfYears = Int32.Parse(txtNumOfYears.Text);

            decimal monthlyRate = yearlyRate / 12 / 100;
            int numOfMonths = numOfYears * 12;

            for(int i =  0; i < numOfMonths; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyRate);
            }

            txtFutureValue.Text = futureValue.ToString("c2");
            txtMonthlyInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
