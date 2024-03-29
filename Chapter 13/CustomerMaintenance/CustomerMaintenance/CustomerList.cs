﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class CustomerList
    {
        private List<Customer> customers;

        public delegate void ChangeHandler(CustomerList customers);

        public event ChangeHandler Changed;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public Customer this[int i]
        {
            get { return customers[i]; }
            set
            {
                customers[i] = value;
                Changed(this);
            }
        }

        public int Count => customers.Count;

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Changed(this);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            Changed(this);
        }

        public void Fill() => customers = CustomerDB.GetCustomers();

        public void Save() => CustomerDB.SaveCustomers(customers);

        public static CustomerList operator + (CustomerList c1, Customer c)
        {
            c1.Add(c);
            return c1;
        }

        public static CustomerList operator - (CustomerList c1, Customer c)
        {
            c1.Remove(c);
            return c1;
        }
    }
}
