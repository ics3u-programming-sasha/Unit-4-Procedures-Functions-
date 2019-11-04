/*
 * Created by: Sasha Malko
 * Created on: 4-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Address Program
 * This program has 2 procedures with the same name (PrintAddress) but different parameters.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptParSasha
{
    public partial class frmOptPar : Form
    {
        public frmOptPar()
        {
            InitializeComponent();
        }

        // Procedure: PrintAddress
        // Input: string aptNumber, string streetAddress, string city, string province, string postalCode
        // Output: void
        // Description: This procedure displays a message box with the given fiven parameters: apt. number, street address, city, province, and postal code. 
        private void PrintAddress(string aptNumber, string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show("Your address is: " + streetAddress + ", Unit: " + aptNumber + ", " + city + ", " + province + ", " + postalCode, "Address Program");
        }

        // Procedure: PrintAddress
        // Input: string streetAddress, string city, string province, string postalCode
        // Output: void
        // Description: This procedure displays a message box with the given four parameters: street address, city, province, and postal code. 
        private void PrintAddress(string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show("Your address is: " + streetAddress + ", " + city + ", " + province + ", " + postalCode, "Address Program");
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            string aptNumber, streetAddress, city, province, postalCode;

            // get information from text boxes
            aptNumber = this.txtUnit.Text;
            streetAddress = this.txtAddress.Text;
            city = this.txtCity.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;

            // make the user enter a street address
            if (streetAddress == "")
            {
                MessageBox.Show("Please enter a valid address.", "Address Program");
            }
            // make the user enter a city
            else if (city == "")
            {
                MessageBox.Show("Please enter a valid city.", "Address Program");
            }
            // make the user enter a province
            else if (province == "")
            {
                MessageBox.Show("Please enter a valid province.", "Address Program");
            }
            // make the user enter a postal code
            else if (postalCode == "")
            {
                MessageBox.Show("Please enter a valid postal code.", "Address Program");
            }
            // if the user does not enter an apt. number, call the procedure that accepts only 4 String parameters
            else if (aptNumber == "")
            {
                PrintAddress(streetAddress, city, province, postalCode);
            }
            // if the user enters all of the information, call the procedure that accepts all 5 String parameters
            else
            {
                PrintAddress(aptNumber, streetAddress, city, province, postalCode);
            }

            // clear the text boxes
            txtAddress.Clear();
            txtCity.Clear();
            txtPostalCode.Clear();
            txtProvince.Clear();
            txtUnit.Clear();
        }
    }
}