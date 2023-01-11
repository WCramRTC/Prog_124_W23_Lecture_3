using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_W23_Lecture_3
{
    public class BankAccount
    {
        // Always make the fields private
        // Naming convention on a private fields
        // Starts with an underscore, and is camel case
        // Lower first letter, Then Upper Case Afterwards
        string _name;
        decimal _balance;

        public BankAccount(string Name, decimal Balance)
        {
            _name = Name;
            _balance = Balance;
        }

        // Properties
        // Properties give access to the user to read and write values to our fields
        // Getters and Setters
        // Getters are used to read the values
        // Setters are used to write the values

        // Creating a Property
        // Access Modifer - RETURN TYPE THAT IS THE SAME AS THE FIELD - Name, the same as the field - NO PARAMETERS
        // Accessors - What are they?
        // Getters Setters
        // BankAccount.Name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Value
                _name = value;
            }
        }
        // Restricting the user from changing values
        public decimal Balance
        {
            get => _balance;
            // No set, makes it read only. THey cant change the _balance
            set
            {        
                if(value > 0)
                {
                    _balance = value;
                }
                else
                {
                    MessageBox.Show("Please don't take my money");
                }
            }
        }




    } // class

} // namespace
