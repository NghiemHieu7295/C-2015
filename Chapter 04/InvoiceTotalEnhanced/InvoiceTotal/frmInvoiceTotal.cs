using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
	{

        private int numberOfInvoices = 0;
        private decimal totalOfInvoices = 0m;
        private decimal invoiceAverage = 0m;
        private decimal largestInvoice = 0m;
        private decimal smallestInvoice = Decimal.MaxValue;

		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            decimal enterSubtotal = Decimal.Parse(txtEnterSubtotal.Text);
            decimal discountPercent = .25m;
            decimal discountAmount = enterSubtotal * discountPercent;
            decimal total = enterSubtotal - discountAmount;

            txtSubtotal.Text = enterSubtotal.ToString("c2");
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c2");
            txtTotal.Text = total.ToString("c2");

            numberOfInvoices++;
            totalOfInvoices += total;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c2");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c2");

            largestInvoice = Math.Max(total, largestInvoice);
            smallestInvoice = Math.Min(total, smallestInvoice);

            txtLargestInvoice.Text = largestInvoice.ToString("c2");
            txtSmallestInvoice.Text = smallestInvoice.ToString("c2");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void btnClearTotal_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;
            largestInvoice = 0m;
            smallestInvoice = Decimal.MaxValue;

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";
            txtLargestInvoice.Text = "";
            txtSmallestInvoice.Text = "";

            txtEnterSubtotal.Focus();
        }
    }
}