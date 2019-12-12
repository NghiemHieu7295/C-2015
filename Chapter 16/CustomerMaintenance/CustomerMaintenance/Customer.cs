using System;

namespace CustomerMaintenance
{
    /// <summary>
    /// Define Customer class
    /// </summary>
    public class Customer
	{
        /// <summary>
        /// First name of customer
        /// </summary>
		private string firstName;

        /// <summary>
        /// Last name of customer
        /// </summary>
		private string lastName;

        /// <summary>
        /// Email of customer
        /// </summary>
		private string email;

        /// <summary>
        /// Constructor no parameters
        /// </summary>
        public Customer()
		{
		}

        /// <summary>
        /// Constructor with first name, last name and email
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public Customer(string firstName, string lastName, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}

        /// <summary>
        /// Get or Set first name
        /// </summary>
        public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
                firstName = value;
			}
		}

        /// <summary>
        /// Get or Set last name
        /// </summary>
        public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

        /// <summary>
        /// Get or Set email
        /// </summary>
        public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

        /// <summary>
        /// Get the text display information about customer
        /// </summary>
        /// <returns>First name, last name and email of customer</returns>
        public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}