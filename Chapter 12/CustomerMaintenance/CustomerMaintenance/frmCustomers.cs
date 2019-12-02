using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        List<Customer> customers = null;

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomersToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer newCustomer = addCustomerForm.GetNewCustomer();

            if(null != newCustomer.FirstName)
            {
                customers.Add(newCustomer);
                CustomerDB.SaveCustomers(customers);
                FillCustomersToList();
            }
        }

        private void FillCustomersToList()
        {
            lstCustomers.Items.Clear();
            foreach(Customer customer in customers)
            {
                lstCustomers.Items.Add(customer.GetDisplayText());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if(i != -1)
            {
                Customer customer = customers[i];
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete");
                if(confirmDelete == DialogResult.OK)
                {
                    customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomersToList();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}