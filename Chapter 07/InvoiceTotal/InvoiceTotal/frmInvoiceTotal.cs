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

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            try
            {
                if(txtSubtotal.Text == "")
                {
                    MessageBox.Show("The Subtotal is required. Please enter a value.", "Entry Error");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);

                    if(subtotal >= 0 && subtotal < 10000)
                    {
                        decimal discountPercent = .25m;
                        decimal discountAmount = subtotal * discountPercent;
                        decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();

                        txtSubtotal.Focus();
                    }
                    else
                    {
                        MessageBox.Show("The Subtotal must be greater or equal than 0 and less than 10000", "Entry Error");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for the Subtotal field.", "Entry Error");
            }
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}