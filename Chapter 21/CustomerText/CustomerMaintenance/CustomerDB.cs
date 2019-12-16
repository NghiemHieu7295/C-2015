using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    /// <summary>
    /// CustomerDB class
    /// </summary>
    public static class CustomerDB
	{
        // TODO: Add the directory and path here
        private static string directory = @"C:\Users\Ominext\Documents\Hieu\Books\C# 2015\Exercise starts\Files\";
        private static string path = directory + "Customers.txt";

        public static void SaveCustomers(List<Customer> customers)
		{
            // TODO: Add code that writes the List<> of Customer objects 
            // to a text file
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(path))
                File.Create(path);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            foreach(Customer c in customers)
            {
                textOut.Write(c.FirstName + "|");
                textOut.Write(c.LastName + "|");
                textOut.WriteLine(c.Email);
            }

            textOut.Close();
            fs.Close();
		}

        public static List<Customer> GetCustomers()
		{
            List<Customer> customers = new List<Customer>();

            // TODO: Add code that reads a List<> of Customer objects 
            // from a text file
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(path))
                File.Create(path);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            while(textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.FirstName = columns[0];
                customer.LastName = columns[1];
                customer.Email = columns[2];
                customers.Add(customer);
            }

            textIn.Close();
            fs.Close();

			return customers;
		}
	}
}
