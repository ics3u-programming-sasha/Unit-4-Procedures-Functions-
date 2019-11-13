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
        Random randNumberGenerator = new Random();

        public frmPassByRef()
        {
            InitializeComponent();
        }

        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber = 1)

                aPictureBox.Image = Properties.Resources.Front;
        }

        private void picCard_Click(object sender, EventArgs e)
        {
            const int MAX_NUM_CARDS = 13;

            int aRandomNumber;

            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            ChangeCard(ref this.picCard, aRandomNumber);
        }
    }
}
