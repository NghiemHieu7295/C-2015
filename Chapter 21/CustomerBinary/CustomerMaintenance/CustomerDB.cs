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
        private static string path = directory + "Customers.dat";

        public static void SaveCustomers(List<Customer> customers)
		{
            // TODO: Add code that writes the List<> of Customer objects 
            // to a text file
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(path))
                File.Create(path);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            BinaryWriter textOut = new BinaryWriter(fs);
            foreach(Customer c in customers)
            {
                textOut.Write(c.FirstName);
                textOut.Write(c.LastName);
                textOut.Write(c.Email);
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
            BinaryReader textIn = new BinaryReader(fs);
            while(textIn.PeekChar() != -1)
            {
                Customer customer = new Customer();
                customer.FirstName = textIn.ReadString();
                customer.LastName = textIn.ReadString();
                customer.Email = textIn.ReadString();
                customers.Add(customer);
            }

            textIn.Close();
            fs.Close();

			return customers;
		}
	}
}
