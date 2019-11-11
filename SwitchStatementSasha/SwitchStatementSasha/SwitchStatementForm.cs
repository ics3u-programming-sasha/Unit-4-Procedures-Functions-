/*
 * Created by: Sasha Malko
 * Created on: 11-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Percentage Program
 * This program has a function that takes the user's 
 * grade level and returns the equivalent percentage mark.  
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

namespace SwitchStatementSasha
{
    public partial class frmSwitchStatement : Form
    {
        public frmSwitchStatement()
        {
            InitializeComponent();
        }

        // Function: ConvertToPercent
        // Input: String level
        // Output: int
        // Description: This function accepts a level of type string and returns the percentage equivalent as an integer.
        private int ConvertToPercent(String level)
        {
            // declare local variable
            int percentage;

            // convert the level into a percentage
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            // return the percentage
            return percentage; 
        }
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            // declare local variables
            string level, percentage;

            // set the level equal to the text in the text box
            level = this.txtLevel.Text;

            // call the function to convert the level and convert the percentage into a string
            percentage = Convert.ToString(ConvertToPercent(level));

            // display the level and the percentage equivalent to it 
            MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%", "Percentage Program");
        }
    }
}