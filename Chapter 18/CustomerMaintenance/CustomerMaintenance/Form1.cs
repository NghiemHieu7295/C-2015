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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch(DBConcurrencyException ex)
            {
                MessageBox.Show("A concurrency error occured. Some rows were not updated.", "Concurrency Exception");
                this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                customersBindingSource.CancelEdit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
        }
    }
}
