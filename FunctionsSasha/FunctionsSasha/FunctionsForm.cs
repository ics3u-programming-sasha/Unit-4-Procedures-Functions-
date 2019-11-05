/*
 * Created by: Sasha Malko
 * Created on: 5-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Volume of a Cylinder
 * This program accepts 2 inputs and calculates the volume of a cylinder. 
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

namespace FunctionsSasha
{
    public partial class frmFunctions : Form
    {
        public frmFunctions()
        {
            InitializeComponent();
        }

        // Function: CalculateVolume
        // Input: double radius, double height
        // Output: double
        // Description: This function calculates the volume of a cylinder with the given radius and height. 
        private double CalculateVolume(double radius, double height)
        {
            // declare local variable
            double volume; 

            // calculate the volume of the cylinder
            volume = Math.PI * Math.Pow(radius, 2) * height;

            // return the volume
            return volume;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double radius, height, userVolume;

            // get the radius and height from the user
            radius = double.Parse(txtRadius.Text);
            height = double.Parse(txtHeight.Text);

            // call the function  to calculate the volume of the cylinder
            userVolume = CalculateVolume(radius, height);

            // display the volume of the cylinder
            this.lblVolume.Text = "The volume is: " + String.Format("{0:0.00}", userVolume) + " cubic units"; 
        }
    }
}