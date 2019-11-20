/*
 * Created by: Sasha Malko
 * Created on: 20-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #34 - New Walking Man
 * This program creates a Picture Box dynamically and then responds to a mouse click. 
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
using System.Threading;

namespace NewWalkingManSasha
{
    public partial class frmNewWalkingMan : Form
    {
        public frmNewWalkingMan()
        {
            InitializeComponent();

            // hide the instructions label
            this.lblInstructions.Hide();
        }

        private void GeneratePictureBoxes()
        {
            // generate each of the picture boxes on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // reveal the instructions
            this.lblInstructions.Show();

            // generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x,y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // set the location of the picture box
            tmpPicMan.Location = pntPic;

            // assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            // stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // cast the sender object into a PictureBox
            PictureBox tmpPicMan = (PictureBox)sender;

            // write a message to the console to check which picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            // declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // continue this loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk1;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 2)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk2;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 3)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk3;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 4)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk4;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 5)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk5;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 6)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk6;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 7)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk7;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 8)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk8;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 9)
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk9;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else
                {
                    // display an image
                    tmpPicMan.Image = Properties.Resources.walk10;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                // refresh the form
                this.Refresh();

                // pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }
        }
    }
}