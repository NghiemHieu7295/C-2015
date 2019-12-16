using System;
using System.Collections.Generic;
using System.Xml;

namespace CustomerMaintenance
{
    /// <summary>
    /// CustomerDB class
    /// </summary>
    public static class CustomerDB
	{
        // TODO: Add code that defines the path for the Customers.xml file
        private const string path = @"C:\Users\Ominext\Documents\Hieu\Books\C# 2015\Exercise starts\Files\Customers.xml";

		public static void SaveCustomers(List<Customer> customers)
		{
            // TODO: Add code that writes the Customer objects
            // in the List<> to the Customers.xml file
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            XmlWriter writer = XmlWriter.Create(path, settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("Customers");
            foreach(Customer c in customers)
            {
                writer.WriteStartElement("Customer");
                writer.WriteElementString("FirstName", c.FirstName);
                writer.WriteElementString("LastName", c.LastName);
                writer.WriteElementString("Email", c.Email);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
        }

        public static List<Customer> GetCustomers()
        {
            // create the list
            List<Customer> customers = new List<Customer>();

            // TODO: Add code that reads data from the Customers.xml file
            // and stores that data in the List<Customer> object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            XmlReader reader = XmlReader.Create(path, settings);
            reader.ReadToDescendant("Customer");
            do
            {
                Customer customer = new Customer();
                reader.ReadStartElement();
                customer.FirstName = reader.ReadElementContentAsString();
                customer.LastName = reader.ReadElementContentAsString();
                customer.Email = reader.ReadElementContentAsString();
                customers.Add(customer);
            }
            while (reader.ReadToNextSibling("Customer"));

            reader.Close();

            return customers;
        }
	}
}
