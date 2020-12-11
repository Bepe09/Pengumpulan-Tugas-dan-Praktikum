using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelEmpty.Text == "[EMPTY]") 
            {
                labelEmpty.Text = textBoxInput.Text;
                textBoxInput.Text = "";
            }
            else if (labelEmpty.Text != "[EMPTY]" && textBoxInput.Text == "DELETE") 
            {
                labelEmpty.Text = "[EMPTY]";
                labelEmpty.ForeColor = System.Drawing.Color.Black;
                textBoxInput.Text = "";
            }
            else if (labelEmpty.Text != "[EMPTY]" && textBoxInput.Text == "SHOWN") 
            {
                labelEmpty.Visible = true;
                textBoxInput.Text = "";
            }
            else if (labelEmpty.Text != "[EMPTY]" && textBoxInput.Text == "HIDE") 
            {
                labelEmpty.Visible = false;
                textBoxInput.Text = "";
            }
            else if (labelEmpty.Text != "[EMPTY]" && textBoxInput.Text == "BLUE") 
            {
                labelEmpty.ForeColor = System.Drawing.Color.Blue;
                textBoxInput.Text = "";
            }
            else if (labelEmpty.Text != "[EMPTY]" && textBoxInput.Text == "RED") 
            {
                labelEmpty.ForeColor = System.Drawing.Color.Red;
                textBoxInput.Text = "";
            }
            else if (labelEmpty.Text != "[EMPTY]" && textBoxInput.Text == "GREEN") 
            {
                labelEmpty.ForeColor = System.Drawing.Color.Green;
                textBoxInput.Text = "";
            }
        }
    }
}
