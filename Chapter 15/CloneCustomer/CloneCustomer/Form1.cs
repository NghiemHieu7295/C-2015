using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer;
        //private List<Customer> customers;
        private CustomerList customerLst;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            customer = new Customer("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            ResetListBoxCustomers();
            this.Close();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtCopies) && Validator.IsInt32(txtCopies))
            {
                customerLst = new CustomerList();

                int copies = Convert.ToInt32(txtCopies.Text);

                for (int i = 0; i < copies; i++)
                {
                    //customers.Add((Customer)customer.Clone());
                    customerLst.Add((Customer)customer.Clone());
                }

                ResetListBoxCustomers();
                foreach (Customer c in customerLst)
                {
                    lstCustomers.Items.Add(c.GetDisplayText());
                }
            }
        }

        private void ResetListBoxCustomers()
        {
            if (lstCustomers.Items.Count > 0)
                lstCustomers.Items.Clear();
        }
    }
}