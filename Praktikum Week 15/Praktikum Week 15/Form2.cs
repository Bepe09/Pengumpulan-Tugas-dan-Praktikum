using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (checkBoxDiskon.Checked == false)
            {
                labelDiskon.Text = "";
            }
        }

        private void checkBoxDiskon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiskon.Checked == true)
            {

            }
        }
    }
}
