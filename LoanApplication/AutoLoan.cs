using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApplication
{
    //auto is derived from the loan class

    class AutoLoan : Loan
    {
        //declare variables
        int year;
           string  make;
          string  model;
          
        
      
              
        
        //create property
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        //constructor

        public AutoLoan()
        {
            //default
        }

        public AutoLoan(string fn,string ln,  double amt, int yr, string mk, string mdl)

            : base(fn, ln, amt)
        {
            year = yr;
            make = mk;
            model = mdl;
        }

        public override string GetInfo()
        {


            return FirstName + " " + LastName + " " +
                "\nLoan Amount:" + " " + LoanAmount.ToString("c") +
                  "\nYear: " +
               year.ToString() + "\nMake: " +
               make.ToString() + "\nModel: " +
               model.ToString() + "\nInterest Rate: " + "8.8%" +  
               "\nLoan Number: " +"0058711111"  +
               "\nNumber of years: " +"15";
                
             

        }
    }

}





    

