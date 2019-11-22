/*
 * Created by: Sasha Malko
 * Created on: 21-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks if 2 strings are the same (if you ignore capitals and smalls), 
 * and returns a boolean "bool" value. 
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

namespace StringEqualitySasha
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        // Function: StringsAreEqual
        // Input: string string1, string string2
        // Output: bool
        // Description: This function checks if the two given strings are equal without considering cases. 
        private bool StringsAreEqual(string string1, string string2)
        {
            // set the boolean variable equal to false
            bool isEqual = false; 

            // declare local variables;
            int stringLength1, stringLength2;

            // get the lengths of the strings
            stringLength1 = string1.Length;
            stringLength2 = string2.Length;

            // check if the strings are equal in length
            if (stringLength1 == stringLength2)
            {
                // declare local variables
                string stringCase1, stringCase2; 

                // convert the strings to uppercase
                stringCase1 = string1.ToUpper();
                stringCase2 = string2.ToUpper();

                // check if the strings are equal without considering cases
                if (stringCase1 == stringCase2)
                {
                    // set the boolean variable equal to true
                    isEqual = true;
                }
            }

            // return the boolean variable
            return isEqual;
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // declare local variables
            string uString1, uString2;
            bool equal;

            // get the strings from the text boxes
            uString1 = this.txtString1.Text;
            uString2 = this.txtString2.Text;

            // call the function to check if the strings are equal
            equal = StringsAreEqual(uString1, uString2);

            // check if the boolean variable equals true
            if (equal == true)
            {
                // display that the strings are equal
                this.lblEqual.Text = "These strings are equal.";
            }
            else
            {
                // display that the strings are not equal
                this.lblEqual.Text = "These strings are NOT equal.";
            }

        }
    }
}