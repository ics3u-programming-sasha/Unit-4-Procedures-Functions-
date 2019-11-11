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

        private int ConvertToPercent(String level)
        {
            int percentage;

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
                    percentage = 75;
                    break;

            }
        }
        private void BtnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
