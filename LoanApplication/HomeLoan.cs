using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApplication
        {
             //Home is derived from the Loan class


              class HomeLoan: Loan
        {
              //declare variables
              int squareFeet;
              int numberOfRooms;
         
         
         
         
            //create property
            public int SquareFeet
            {
                get
                {
                    return squareFeet;
                }
                set
                {
                    squareFeet = value;
                }
            }

            public int NumberOfRooms
            {
                get
                {
                    return numberOfRooms;
                }
                set
                {
                    numberOfRooms = value;
                }
            }

            //constructors

            public HomeLoan()
            {
                //default
            }

            public HomeLoan(string fn, string ln,  double amt, int sqft, int nor)
                :base (fn, ln,  amt)

            {
                squareFeet = sqft;
                numberOfRooms = nor;
            }
            public override string GetInfo()
            {
                return FirstName + " " + LastName + " " + " " +
                    "\nLoan Amount: " + "" + LoanAmount.ToString("c") + " " + "\nSquare Feet: " +
                    squareFeet.ToString() + "\nNumber of Rooms: " +
                    numberOfRooms.ToString() + "\nInterest Rate: " +"8.8%" +
                    "\nLoan Number: " + "000561111" +
                    "\nType: " + "single family detached" +
                    "\nNumber of Years: " + "30";





            }

    }//end of class

}//end of namespace
