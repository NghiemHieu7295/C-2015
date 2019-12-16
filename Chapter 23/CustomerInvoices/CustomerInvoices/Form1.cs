using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInvoices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Invoice> invoicesLst;
        List<Customer> customersLst;

        private void Form1_Load(object sender, EventArgs e)
        {
            invoicesLst = InvoiceDB.GetInvoices();
            customersLst = CustomerDB.GetCustomers();

            var invoices = from invoice in invoicesLst
                           join customer in customersLst
                           on invoice.CustomerID equals customer.CustomerID
                           orderby customer.Name, invoice.InvoiceTotal descending
                           select new { customer.Name, invoice.InvoiceID, invoice.InvoiceDate, invoice.InvoiceTotal };

            int i = 0;
            
            foreach(var invoice in invoices)
            {
                lvInvoices.Items.Add(invoice.Name);
                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceID.ToString());
                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToString());
                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString());
                i += 1;
            }
        }
    }
}
