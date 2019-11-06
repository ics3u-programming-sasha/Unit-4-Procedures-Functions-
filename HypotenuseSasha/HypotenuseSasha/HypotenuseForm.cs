/*
 * Created by: Sasha Malko
 * Created on: 6-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Calculate the Hypotenuse
 * This program accepts 2 inputs and calculates the hypotenuse of a right-angle triangle.
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

namespace HypotenuseSasha
{
    public partial class frmHypotenuse : Form
    {
        public frmHypotenuse()
        {
            InitializeComponent();
        }

        // Function: CalculateHypotenuse
        // Input: double sideA, double sideB
        // Output: double
        // Description: This function calculates the hypotenuse of a triangle with the given side lengths.
        private double CalculateHypotenuse(double sideA, double sideB)
        {
            // declare local variable 
            double hypotenuse;

            // calculate the hypotenuse of the triangle 
            hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            // return the hypotenuse
            return hypotenuse; 
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double sideA, sideB, userHypotenuse;

            // get the side lengths from the user
            sideA = double.Parse(txtSideA.Text);
            sideB = double.Parse(txtSideB.Text);

            // call the function to calculate the hypotenuse of the triangle 
            userHypotenuse = CalculateHypotenuse(sideA, sideB);

            // display the hypotenuse of the triangle 
            this.lblHypotenuse.Text = "The hypotenuse is: " + String.Format("{0:0.0}", userHypotenuse) + " cm"; 
        }
    }
}