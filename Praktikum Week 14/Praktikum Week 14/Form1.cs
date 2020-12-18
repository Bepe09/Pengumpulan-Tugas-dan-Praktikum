using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_14
{
    public partial class Formstring : Form
    {
        public Formstring()
        {
            InitializeComponent();
        }

        private void buttonreverse_Click(object sender, EventArgs e)
        {
            if (textBoxinput.Text != "")
            {
                string input = textBoxinput.Text;
                char[] inputarray = input.ToCharArray();
                Array.Reverse(inputarray);
                string reverse = new string(inputarray);
                labeloutput.Text = reverse;
            }
            else if (textBoxinput.Text == "")
            {
                string message = "Tolong isi textbox dulu bos!";
                MessageBox.Show(message);
            }
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            if (textBoxinput.Text != "")
            {
                string input = textBoxinput.Text;
                char[] inputarray = input.ToCharArray();
                Array.Sort(inputarray);
                string sort = new string(inputarray);
                labeloutput.Text = sort;
            }
            else if (textBoxinput.Text == "")
            {
                string message = "Tolong isi textbox dulu bos!";
                MessageBox.Show(message);
            }
        }
    }
}
