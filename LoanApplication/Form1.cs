using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApplication
{
    public partial class FrmLoanProcess : Form
    {

        //create global objects
        HomeLoan myHomeLoan = new HomeLoan();
        AutoLoan myAutoLoan = new AutoLoan();




        public FrmLoanProcess()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            double loanAmount;
            int year;
            int squareFeet;
            int numberOfRooms;
            

            if (cmbLoan.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("First name empty! please re-enter");
                    txtFirstName.Clear();
                    txtFirstName.Focus();
                }

                else if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Last name is empty! Please re-enter");
                    txtLastName.Clear();
                    txtLastName.Focus();
                }
                else if (double.TryParse(txtLoanAmount.Text, out loanAmount) == false)
                {
                    MessageBox.Show("Invalid amount! Please re-enter");
                    txtLoanAmount.Clear();
                    txtLoanAmount.Focus();
                }
                else if (int.TryParse(txtYear.Text,out year) == false)
                {
                    MessageBox.Show("Invalid year! Please re-enter");
                    txtYear.Clear();
                    txtYear.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtMake.Text))
                {
                    MessageBox.Show("Make is empty! Please re-enter");
                    txtMake.Clear();
                    txtMake.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    MessageBox.Show("Model is empty! Please re-enter");
                    txtModel.Clear();
                    txtModel.Focus();
                }

                else
                {
                    myAutoLoan.FirstName = txtFirstName.Text;
                    myAutoLoan.LastName = txtLastName.Text;
                    myAutoLoan.Make = txtMake.Text;
                    myAutoLoan.Model = txtModel.Text;
                    myAutoLoan.Year = year;
                    myAutoLoan.LoanAmount = loanAmount;

                    MessageBox.Show(myAutoLoan.GetInfo());


                }
                    
            }
            else if (cmbLoan.SelectedIndex == 0)
            {
               
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    MessageBox.Show("First Name is empty! Please re-enter");
                    txtFirstName.Clear();
                    txtFirstName.Focus();
                }
               
                
                   
                else if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Last name is empty! Please re-enter");
                    txtLastName.Clear();
                    txtLastName.Focus();
                }
                else if (double.TryParse(txtLoanAmount.Text, out loanAmount) == false)
                {
                    MessageBox.Show("Invalid Loan Amount! Please re-enter");
                    txtLoanAmount.Clear();
                    txtLoanAmount.Focus();
                }
                else if (int.TryParse(txtSquareFeet.Text, out squareFeet) == false)
                {
                    MessageBox.Show("Invalid Number! Please re-enter");
                    txtSquareFeet.Clear();
                    txtSquareFeet.Focus();
                }
                else if (int.TryParse(txtNumberOfRooms.Text, out numberOfRooms) == false)
                {
                    MessageBox.Show("Invalid Number of Rooms! Please re-enter");
                    txtNumberOfRooms.Clear();
                    txtNumberOfRooms.Focus();
                }
                  

                else
                {
                    myHomeLoan.FirstName = txtFirstName.Text;
                    myHomeLoan.LastName = txtLastName.Text;
                    myHomeLoan.LoanAmount = loanAmount;
                    myHomeLoan.SquareFeet = squareFeet;
                    myHomeLoan.NumberOfRooms = numberOfRooms;
                    
                    MessageBox.Show(myHomeLoan.GetInfo());

                }



                   
              
            }
            


           
           
              
            



        }

        private void FrmLoanProcess_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoan.SelectedIndex == 1)
            {


                txtInterestRate.Text = "5.5%";
                lblInterestRate.Visible = true;
                txtInterestRate.Visible = true;
                lblCarDetails.Visible = true;
                lblYear.Visible = true;
                txtYear.Visible = true;
                lblMake.Visible = true;
                txtMake.Visible = true;
                lblModel.Visible = true;
                txtModel.Visible = true;
             
              
              
               
               


            }
            else if (cmbLoan.SelectedIndex == 0)
            {
                txtInterestRate.Text = "8.10%";
                lblInterestRate.Visible = true;
                txtInterestRate.Visible = true;
                lblHomeDetails.Visible = true;
                lblSquareFeet.Visible = true;
                txtSquareFeet.Visible = true;
                txtNumberOfRooms.Visible = true;
                lblNumberOfRooms.Visible = true;
              
            
                
            }

        }


    }
}
            

        

       

