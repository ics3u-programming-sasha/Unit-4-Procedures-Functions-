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

        private void PrintAddress(string aptNumber, string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show("Your address is: " + aptNumber + streetAddress + city + province + postalCode, "Address Program");
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string aptNumber, streetAddress, city, province, postalCode;

            aptNumber = this.txtUnit.Text;
            streetAddress = this.txtAddress.Text;
            city  = this.txtCity.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;

            if (streetAddress == "")
            {
                MessageBox.Show("Please enter your street address.", "Address Program");
            }
        }
    }
}
