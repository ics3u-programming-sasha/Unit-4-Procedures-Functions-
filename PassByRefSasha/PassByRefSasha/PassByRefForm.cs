/*
 * Created by: Sasha Malko
 * Created on: 13-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Pass by Reference
 * This program changes the image in the picture box when the user clicks on it. 
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

namespace PassByRefSasha
{
    public partial class frmPassByRef : Form
    {
        // declare global variables
        Random randNumberGenerator = new Random();

        public frmPassByRef()
        {
            InitializeComponent();
        }

        // Procedure: ChangeCard
        // Input: ref PictureBox aPictureBox, int cardNumber
        // Description: This procedure takes a picture box passed by reference and a card number. It assigns the image
        // in the picture box to the card with the given card number.
        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.AC;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.AD;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.AH;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.AS;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.TwoC;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.TwoD;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.TwoH;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.TwoS;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.ThreeC;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.ThreeD;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.ThreeH;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.ThreeS;
            }
            else if (cardNumber == 14)
            {
                aPictureBox.Image = Properties.Resources.FourC;
            }
            else if (cardNumber == 15)
            {
                aPictureBox.Image = Properties.Resources.FourD;
            }
            else if (cardNumber == 16)
            {
                aPictureBox.Image = Properties.Resources.FourH;
            }
            else if (cardNumber == 17)
            {
                aPictureBox.Image = Properties.Resources.FourS;
            }
            else if (cardNumber == 18)
            {
                aPictureBox.Image = Properties.Resources.FiveC;
            }
            else if (cardNumber == 19)
            {
                aPictureBox.Image = Properties.Resources.FiveD;
            }
            else if (cardNumber == 20)
            {
                aPictureBox.Image = Properties.Resources.FiveH;
            }
            else if (cardNumber == 21)
            {
                aPictureBox.Image = Properties.Resources.FiveS;
            }
            else if (cardNumber == 22)
            {
                aPictureBox.Image = Properties.Resources.SixC;
            }
            else if (cardNumber == 23)
            {
                aPictureBox.Image = Properties.Resources.SixD;
            }
            else if (cardNumber == 24)
            {
                aPictureBox.Image = Properties.Resources.SixH;
            }
            else if (cardNumber == 25)
            {
                aPictureBox.Image = Properties.Resources.SixS;
            }
            else if (cardNumber == 26)
            {
                aPictureBox.Image = Properties.Resources.SevenC;
            }
            else if (cardNumber == 27)
            {
                aPictureBox.Image = Properties.Resources.SevenD;
            }
            else if (cardNumber == 28)
            {
                aPictureBox.Image = Properties.Resources.SevenH;
            }
            else if (cardNumber == 29)
            {
                aPictureBox.Image = Properties.Resources.SevenS;
            }
            else if (cardNumber == 30)
            {
                aPictureBox.Image = Properties.Resources.EightS;
            }
            else if (cardNumber == 31)
            {
                aPictureBox.Image = Properties.Resources.EightC;
            }
            else if (cardNumber == 32)
            {
                aPictureBox.Image = Properties.Resources.EightD;
            }
            else if (cardNumber == 33)
            {
                aPictureBox.Image = Properties.Resources.EightH;
            }
            else if (cardNumber == 34)
            {
                aPictureBox.Image = Properties.Resources.NineS;
            }
            else if (cardNumber == 35)
            {
                aPictureBox.Image = Properties.Resources.NineC;
            }
            else if (cardNumber == 36)
            {
                aPictureBox.Image = Properties.Resources.NineD;
            }
            else if (cardNumber == 37)
            {
                aPictureBox.Image = Properties.Resources.NineH;
            }
            else if (cardNumber == 38)
            {
                aPictureBox.Image = Properties.Resources.TenS;
            }
            else if (cardNumber == 39)
            {
                aPictureBox.Image = Properties.Resources.TenC;
            }
            else if (cardNumber == 40)
            {
                aPictureBox.Image = Properties.Resources.TenD;
            }
            else if (cardNumber == 41)
            {
                aPictureBox.Image = Properties.Resources.TenH;
            }
            else if (cardNumber == 42)
            {
                aPictureBox.Image = Properties.Resources.JS;
            }
            else if (cardNumber == 43)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 44)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
            else if (cardNumber == 45)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 46)
            {
                aPictureBox.Image = Properties.Resources.QS;
            }
            else if (cardNumber == 47)
            {
                aPictureBox.Image = Properties.Resources.QC;
            }
            else if (cardNumber == 48)
            {
                aPictureBox.Image = Properties.Resources.QD;
            }
            else if (cardNumber == 49)
            {
                aPictureBox.Image = Properties.Resources.QH;
            }
            else if (cardNumber == 50)
            {
                aPictureBox.Image = Properties.Resources.KS;
            }
            else if (cardNumber == 51)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
            else if (cardNumber == 52)
            {
                aPictureBox.Image = Properties.Resources.KD;
            }
            else if (cardNumber == 53)
            {
                aPictureBox.Image = Properties.Resources.KH;
            }
        }

        private void picCard_Click(object sender, EventArgs e)
        {
            // declare local constants
            const int MAX_NUM_CARDS = 53;

            // declare local variables
            int aRandomNumber;

            // get a random number between 1 and the maximum
            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            // get the card depending on the random selection
            ChangeCard(ref this.picCard, aRandomNumber);
        }
    }
}