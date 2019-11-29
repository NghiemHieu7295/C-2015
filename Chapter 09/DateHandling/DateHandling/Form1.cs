using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the days until due date
            DateTime futureDate;
            if(!DateTime.TryParse(txtFutureDate.Text, out futureDate))
            {
                MessageBox.Show("Future date is not valid format. Please enter valid format.", "Entry Error");
                txtFutureDate.Clear();
                txtFutureDate.Focus();
            }
            else
            {
                DateTime currentDate = DateTime.Today;

                TimeSpan timeUntilDue = futureDate.Subtract(currentDate);
                int daysUntilDue = timeUntilDue.Days;

                MessageBox.Show("Current date:\t" +
                    currentDate.ToShortDateString() +
                    "\nFuture date:\t" +
                    futureDate.ToShortDateString() +
                    "\nDays until due:\t" + daysUntilDue, "Due Days Calculation");
            }
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
            DateTime birthDate;
            if(!DateTime.TryParse(txtBirthDate.Text, out birthDate))
            {
                MessageBox.Show("Birth date is not valid format. Please enter valid format.", "Entry Error");
                txtBirthDate.Clear();
                txtBirthDate.Focus();
            }
            else
            {
                DateTime currentDate = DateTime.Today;

                int age = currentDate.Year - birthDate.Year;

                if (currentDate.DayOfYear < birthDate.DayOfYear)
                    age--;

                MessageBox.Show("Current date:\t" +
                    currentDate.ToLongDateString() + "\n" +
                    "Birth date:\t" +
                    birthDate.ToLongDateString() + "\n" +
                    "Age:\t\t" + age, "Age Calculation");
            }
        }

        private bool IsValid()
        {
            DateTime birthDate, futureDate;
            if(!DateTime.TryParse(txtBirthDate.Text, out birthDate))
            {
                MessageBox.Show("Birth date is not valid format. Please enter valid format.", "Entry Error");
                txtFutureDate.Focus();

                return false;
            }
            else if(!DateTime.TryParse(txtFutureDate.Text, out futureDate))
            {
                MessageBox.Show("Future date is not valid format. Please enter valid format.", "Entry Error");
                txtBirthDate.Focus();

                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtFutureDate_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtFutureDate.Text))
            {
                txtBirthDate.Enabled = false;
                btnCalculateAge.Enabled = false;
            }
            else
            {
                txtBirthDate.Enabled = true;
                btnCalculateAge.Enabled = true;
            }
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtBirthDate.Text))
            {
                txtFutureDate.Enabled = false;
                btnCalculateDueDays.Enabled = false;
            }
            else
            {
                txtFutureDate.Enabled = true;
                btnCalculateDueDays.Enabled = true;
            }
        }
    }
}