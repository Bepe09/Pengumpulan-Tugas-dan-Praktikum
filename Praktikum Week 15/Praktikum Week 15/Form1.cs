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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonDelete.Enabled = false;
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButtonMakanan.Checked == true)
             {
                comboBoxMakanan.Show();
                comboBoxMinuman.Hide();
                radioButtonNormal.Hide();
                radioButtonJumbo.Hide();
             }
        }

        public void buttonBeli_Click(object sender, EventArgs e)
        {
            if (radioButtonMakanan.Checked == true)
            {
                listBoxMenu.Items.Add(comboBoxMakanan.SelectedItem);
            }
            else if (radioButtonMinuman.Checked == true)
            {
                listBoxMenu.Items.Add(comboBoxMinuman.SelectedItem);
            }
            listBoxHarga.Items.Add(labelHarga.Text);
            buttonDelete.Enabled = true;
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                comboBoxMinuman.Show();
                comboBoxMakanan.Hide();
                radioButtonNormal.Show();
                radioButtonJumbo.Show();
            }
        }

        private void comboBoxMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonNormal.Checked == true)
            {
                if (comboBoxMinuman.SelectedIndex == 0)
                {
                    labelHarga.Text = "5.000";
                }
                else if (comboBoxMinuman.SelectedIndex == 1)
                {
                    labelHarga.Text = "3.000";
                }
                else if (comboBoxMinuman.SelectedIndex == 2)
                {
                    labelHarga.Text = "6.000";
                }
                else if (comboBoxMinuman.SelectedIndex == 3)
                {
                    labelHarga.Text = "2.000";
                }
            }
            else if (radioButtonJumbo.Checked == true)
            {
                if (comboBoxMinuman.SelectedIndex == 0)
                {
                    labelHarga.Text = "7.000";
                }
                else if (comboBoxMinuman.SelectedIndex == 1)
                {
                    labelHarga.Text = "5.000";
                }
                else if (comboBoxMinuman.SelectedIndex == 2)
                {
                    labelHarga.Text = "10.000";
                }
                else if (comboBoxMinuman.SelectedIndex == 3)
                {
                    labelHarga.Text = "5.000";
                }
            }
        }

        private void comboBoxMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMakanan.SelectedIndex == 0)
            {
                labelHarga.Text = "10.000";
            }
            else if (comboBoxMakanan.SelectedIndex == 1)
            {
                labelHarga.Text = "12.000";
            }
            else if (comboBoxMakanan.SelectedIndex == 2)
            {
                labelHarga.Text = "15.000";
            }
            else if (comboBoxMakanan.SelectedIndex == 3)
            {
                labelHarga.Text = "15.000";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.Items.Count > 0)
            {
                buttonDelete.Enabled = true;
                listBoxMenu.Items.RemoveAt(listBoxMenu.SelectedIndex);
            }
            else if (listBoxMenu.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.Items.Count > 0)
            {
                var Formbaru = new Form2();
                Formbaru.ShowDialog();
            }
            else if (listBoxMenu.Items.Count == 0)
            {
                MessageBox.Show("Order Masih Kosong, Pilih Menu Dulu!");
            }
        }
    }
}
