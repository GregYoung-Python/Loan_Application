using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApplication
{
    class Loan
    {
       //declare variables
           string firstName;
           string    lastName;
          
           double loanAmount;


              
       //create properties
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

      

       public double LoanAmount
       {
           get
           {
               return loanAmount;
           }
           set
           {
               loanAmount = value;
           }
       }

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
       //constructors
       public Loan()
       {
           //default
       }

       public Loan(string fn, string ln,  double amt)
       {
           firstName = fn;
           lastName = ln;
          
           loanAmount = amt;
       }

       public virtual string GetInfo()
       {
           return firstName + " " + lastName +" " +  + loanAmount;
       }



           
    }//end of class
}//end of namespace
