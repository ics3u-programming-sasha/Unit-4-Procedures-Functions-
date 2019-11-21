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

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string string1, string2, stringUppercase1, stringUppercase2;
            int stringLength1, stringLength2;
            bool isEqual = false;

            string1 = this.txtString1.Text;
            string2 = this.txtString1.Text; 

            stringLength1 = string1.Length;
            stringLength2 = string2.Length; 

            if (stringLength1 == stringLength2)
            {
                stringUppercase1 = string1.ToUpper();
                stringUppercase2 = string2.ToUpper();
            }
        }
    }
}
