using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to parse name
            if(!String.IsNullOrEmpty(txtFullName.Text))
            {
                string firstName = "";
                string middleName = "";
                string lastName = "";
                string[] names = txtFullName.Text.Trim().Split(' ');
                
                if(names.Length == 1)
                {
                    firstName = names[0];
                }
                else if(names.Length == 2)
                {
                    firstName = names[0];
                    lastName = names[1];
                }
                else
                {
                    firstName = names[0];
                    middleName = names[1];
                    for(int i = 2; i < names.Length; i++)
                    {
                        lastName += names[i];
                    }
                }

                ToInitialCap(ref firstName);
                ToInitialCap(ref middleName);
                ToInitialCap(ref lastName);
                MessageBox.Show("Full name:\t" + firstName + "\nMiddle name:\t" + middleName +
                    "\nLast name:\t" + lastName, "Parse Name");
            }
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to edit the phone number
            if(!String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                string enteredNumber = txtPhoneNumber.Text.Trim();
                string digitsOnly = "";
                foreach (char c in enteredNumber)
                {
                    if (c == '(' || c == ')' || c == '-' ||
                        c == ' ' || c == '.')
                    {
                        continue;
                    }
                    digitsOnly += c;
                }

                string standardFormat = digitsOnly.Insert(3, "-");
                standardFormat = standardFormat.Insert(7, "-");

                MessageBox.Show("Entered:\t\t"
                    + enteredNumber + "\n"
                    + "Digits only:\t"
                    + digitsOnly + "\n"
                    + "Standard format:\t"
                    + standardFormat, "Edit Phone Number");
            }
        }

        // TODO: Add ToInitialCap method here
        private void ToInitialCap(ref string s)
        {
            if(!String.IsNullOrEmpty(s))
            {
                string firstChar = s.Substring(0, 1);
                firstChar = firstChar.ToUpper();
                s = firstChar + s.Substring(1);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}