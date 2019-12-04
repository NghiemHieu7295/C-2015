using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class WholesaleCustomer : Customer
    {
        private string company;

        public WholesaleCustomer()
        { }

        public WholesaleCustomer(string firstName, string lastName, string email, string company) 
            : base(firstName, lastName, email)
        {
            this.Company = company;
        }

        public string Company { get; set; }

        public override string GetDisplayText()
        {
            return this.FirstName + " " + this.LastName + ", " + this.Email + " (" + this.Company + ")";
        }
    }
}
