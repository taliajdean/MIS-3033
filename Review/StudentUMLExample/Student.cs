using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUMLExample
{
    class Student
    {
        //Write on mulitple lines
        //Hold Alt+Shift then use the arrow keys to select
        //which lines you want to edit and then release the keys and type
        public int SoonerID { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public bool IsOnProbation {get; set;}
        public double GPA {get; set;}
        private double BursarBalance;

        /// Default/Empty Constructor for the student
        
        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 1000;
        }

        /// <summary>
        /// Overloaded constrcutor that will set the deafult values of soonerid, firstname, lastname and bursarbalance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="BursarBalance"></param>
        public Student(int id, string fName, string lName, double BursarBalance) 
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }
        /// <summary>
        /// Make a payment on your Bursar balance
        /// </summary>
        /// <param name="amount"></param>
        public void MakePayment(double amount)
        {
            //BursarBalance = BursarBalance - amount;
            if (amount > 0)
            {
                BursarBalance -= amount;
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// The current state of your bursar account 
        /// </summary>
        /// <returns>How much you owe to the bursar</returns>
        public double CheckBalance()
        {
            return BursarBalance;
        }

        /// <summary>
        /// Create a string representation of our instance of the class 
        /// </summary>
        /// <returns>The current state of the class</returns>
        public override string ToString()
        {
            string output = $"{FirstName} {LastName} {SoonerID}";
            if (IsOnProbation == true)
            {
                output += "is on probation.\n";
            }
            else
            {
                output += "is not on probation.\n";
            }
            
            output += $"They have a {GPA.ToString("N2")} GPA" + 
                $"and they owe {BursarBalance}";
            return base.ToString();
        }
    }
}
