using System;
using System.Collections;
using System.Collections.Generic;

namespace CloneCustomer
{
    public class CustomerList : IEnumerable<Customer>
	{
        private List<Customer> customers = new List<Customer>();

		public int Count => customers.Count;

		public Customer this[int i] => customers[i];

		public void Add(Customer customer) => customers.Add(customer);

        public IEnumerator<Customer> GetEnumerator()
        {
            foreach(Customer c in customers)
            {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
