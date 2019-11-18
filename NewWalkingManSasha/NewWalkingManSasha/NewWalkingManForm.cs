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
            this.lblInstructions.Hide();
            InitializeComponent();
        }

        private void GeneratePictureBoxes()
        {
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.lblInstructions.Show();

            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            tmpPicMan.Location = pntPic;

            tmpPicMan.Image = Properties.Resources.walk1;

            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmpPicMan = (PictureBox)sender;

            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk1;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 2)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk2;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 3)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk3;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 4)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk4;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 5)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk5;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 6)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk6;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 7)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk7;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 8)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk8;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else if (pictureFrameCounter == 9)
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk9;
                    // add one to the picture frame counter
                    pictureFrameCounter = pictureFrameCounter + 1;
                }

                else
                {
                    // display an image
                    this.tmpPicMan.Image = Properties.Resources.walk10;
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
