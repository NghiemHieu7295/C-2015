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
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

        // TODO: declare class variables for array and list here
        decimal[] invoiceTotalsArray = new decimal[5];
        List<decimal> invoiceTotalsList = new List<decimal>();
        int i = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
		{
            try
            {

                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show(
                        "Subtotal is a required field.", "Entry Error");
                }
                else
                {
			        decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPercent = 0m;
                        if (subtotal >= 500)
                            discountPercent = .2m;
                        else if (subtotal >= 250 & subtotal < 500)
                            discountPercent = .15m;
                        else if (subtotal >= 100 & subtotal < 250)
                            discountPercent = .1m;
                        decimal discountAmount = subtotal * discountPercent;
			            decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();
                        invoiceTotalsArray[i] = invoiceTotal;
                        i++;
                        invoiceTotalsList.Add(invoiceTotal);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Subtotal must be greater than 0 and less than 10,000.", 
                            "Entry Error");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.", 
                    "Entry Error");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("The index is out of range. Please exit the application.", "Out of Range");
            }
            txtSubtotal.Text = "";
            txtSubtotal.Focus();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
            // TODO: add code that displays dialog boxes here
            Array.Sort(invoiceTotalsArray);
            string message = "";
            foreach (decimal invoiceTotal in invoiceTotalsArray)
            {
                if (invoiceTotal == .0m)
                    continue;

                message += invoiceTotal.ToString("c2") + "\n";
            }

            if (!String.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "Order Totals - Array");
            }

            message = "";
            invoiceTotalsList.Sort();
            for(i = 0; i < invoiceTotalsList.Count; i++)
            {
                if (invoiceTotalsList[i] == .0m)
                    continue;

                message += invoiceTotalsList[i].ToString("c2") + "\n";
            }

            if (!message.Equals(""))
            {
                MessageBox.Show(message, "Order Totals - List");
            }

            this.Close();
		}

	}
}