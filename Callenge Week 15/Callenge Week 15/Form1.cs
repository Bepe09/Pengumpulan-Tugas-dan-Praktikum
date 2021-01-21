using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Callenge_Week_15
{
    public partial class FormCalculator : Form
    {
        int hasil = 0;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonangka7_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "7";
                labelHasilTotal.Text = "7";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "7";
                labelHasilTotal.Text = labelHasilTotal.Text + "7";
            }
            
        }

        private void buttonangka8_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "8";
                labelHasilTotal.Text = "8";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "8";
                labelHasilTotal.Text = labelHasilTotal.Text + "8";
            }
        }

        private void buttonangka9_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "9";
                labelHasilTotal.Text = "9";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "9";
                labelHasilTotal.Text = labelHasilTotal.Text + "9";
            }
        }

        private void buttonangka4_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "4";
                labelHasilTotal.Text = "4";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "4";
                labelHasilTotal.Text = labelHasilTotal.Text + "4";
            }
        }

        private void buttonangka5_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "5";
                labelHasilTotal.Text = "5";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "5";
                labelHasilTotal.Text = labelHasilTotal.Text + "5";
            }
        }

        private void buttonangka6_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "6";
                labelHasilTotal.Text = "6";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "6";
                labelHasilTotal.Text = labelHasilTotal.Text + "6";
            }
        }

        private void buttonangka1_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "1";
                labelHasilTotal.Text = "1";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "1";
                labelHasilTotal.Text = labelHasilTotal.Text + "1";
            }
        }

        private void buttonangka2_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "2";
                labelHasilTotal.Text = "2";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "2";
                labelHasilTotal.Text = labelHasilTotal.Text + "2";
            }
        }

        private void buttonangka3_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "3";
                labelHasilTotal.Text = "3";
            }
            else if (labelhasil.Text != "0" || labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "3";
                labelHasilTotal.Text = labelHasilTotal.Text + "3";
            }
        }

        private void buttonangka0_Click(object sender, EventArgs e)
        {
            if (labelhasil.Text == "0" && labelHasilTotal.Text == "0")
            {
                labelhasil.Text = "0";
                labelHasilTotal.Text = "0";
            }
            else if (labelhasil.Text != "0" && labelHasilTotal.Text != "0")
            {
                labelhasil.Text = labelhasil.Text + "0";
                labelHasilTotal.Text = labelHasilTotal.Text + "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelhasil.Text = "0";
            labelHasilTotal.Text = "0";
            hasil = 0;
        }

        private void buttonsamadengan_Click(object sender, EventArgs e)
        {
            hasil = hasil + Convert.ToInt32(labelHasilTotal.Text);
            labelHasilTotal.Text = Convert.ToString(hasil);
            //labelhasil.Text
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            hasil = hasil + Convert.ToInt32(labelHasilTotal.Text);
            labelhasil.Text = labelhasil.Text + "+";
            labelHasilTotal.Text = "0";
        }
    }
}
