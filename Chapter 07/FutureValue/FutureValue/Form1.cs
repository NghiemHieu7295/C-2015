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
            try
            {
                if(IsValidData())
                {
                    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = this.CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            //catch(FormatException)
            //{
            //    MessageBox.Show("Invalid numeric format. Please check all entries.", "Entry Error");
            //}
            //catch(OverflowException)
            //{
            //    MessageBox.Show("Overflow error. Please enter smaller value.", "Entry Error");
            //}
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, ex.GetType().ToString());
            }
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, 
            decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            //throw new Exception("Test the exception");
            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsPresent(TextBox textBox, string entryName)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show(entryName + " is required. Please enter a value.", "Entry Error");
                textBox.Focus();

                return false;
            }

            return true;
        }

        private bool IsDecimal(TextBox textBox, string entryName)
        {
            decimal value;
            if(!Decimal.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(entryName + " must be decimal value. Please enter again.", "Entry Error");
                textBox.Focus();

                return false;
            }

            return true;
        }

        private bool IsInt32(TextBox textBox, string entryName)
        {
            int value;
            if(!Int32.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(entryName + " must be integer value. Please enter again.", "Entry Error");
                textBox.Focus();

                return false;
            }

            return true;
        }

        private bool IsWithinRange(TextBox textBox, string entryName, decimal min, decimal max)
        {
            decimal value = Decimal.Parse(textBox.Text);
            if(value < min || value > max)
            {
                MessageBox.Show(entryName + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();

                return false;
            }
            
            return true;
        }

        private bool IsValidData()
        {
            return IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                   IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                   IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

                   IsPresent(txtInterestRate, "Yearly Interest Rate") &&
                   IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
                   IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 20) &&

                   IsPresent(txtYears, "Number of Years") &&
                   IsInt32(txtYears, "Number of Years") &&
                   IsWithinRange(txtYears, "Number of Years", 1, 40);
        }
    }
}