/*
 * Created by: Sasha Malko
 * Created on: 14-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Rounding Program
 * This program accepts a number with decimals, and the user can tell 
 * the program how many decimal places they want to round to. 
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

namespace RoundDecimalSasha
{
    public partial class frmRoundDecimal : Form
    {
        public frmRoundDecimal()
        {
            InitializeComponent();
        }

        // Function: RoundDecimal
        // Input: ref double value, double decimalPlace
        // Output: double
        // Description: This function rounds a decimal number with the given value and the number 
        // of decimal places to round to. 
        private double RoundDecimal(ref double value, double decimalPlace)
        {
            // declare local variable
            double roundedValue;

            // round the decimal number
            roundedValue = Math.Truncate(value * Math.Pow(10, decimalPlace) + 0.5) / Math.Pow(10, decimalPlace);

            // return the rounded value
            return roundedValue;
        }

        private void LblRound_Click(object sender, EventArgs e)
        {
            // declare local variables
            double uDecimalPlace, uRoundedValue, userValue;

            // get the value and the number of decimal places to round to from the user
            userValue = Double.Parse(txtValue.Text);
            uDecimalPlace = Convert.ToDouble(nudDecimal.Value);

            // call the function to round the value
            uRoundedValue = RoundDecimal(ref userValue, uDecimalPlace);

            // display the rounded value in a message box
            MessageBox.Show("The rounded answer is: " + Convert.ToString(uRoundedValue), "Round Decimal");
        }
    }
}