using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class RetailCustomer : Customer
    {
        private string homePhone;

        public RetailCustomer()
        { }

        public RetailCustomer(string firstName, string lastName, string email, string homePhone) 
            : base(firstName, lastName, email)
        {
            this.homePhone = homePhone;
        }

        public string HomePhone { get; set; }

        public override string GetDisplayText()
        {
            if(!String.IsNullOrEmpty(this.HomePhone))
            {
                string digitsOnly = "";
                foreach(char c in this.HomePhone)
                {
                    if (c == '(' || c == ')' || c == '.' || c == '-' || c == ' ')
                        continue;

                    digitsOnly += c;
                }

                this.HomePhone = digitsOnly.Insert(0, "(");
                this.HomePhone = this.HomePhone.Insert(4, ")");
                this.HomePhone = this.HomePhone.Insert(5, " ");
                this.HomePhone = this.HomePhone.Insert(9, "-");
            }
            return this.FirstName + " " + this.LastName + ", " + this.Email + " ph: " + this.HomePhone;
        }
    }
}
