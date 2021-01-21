using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_15
{
    public partial class FormUtama : Form
    {
        string[] makanan = new string[30];
        string[] minuman = new string[30];
        int cmakan = 0;
        int cminum = 0;

        public FormUtama()
        {
            InitializeComponent();
            textBoxNamaItem.Focus();
            makanan[0] = "Mie Instan";
            listBoxListItem.Items.Add(makanan[0]);
            makanan[1] = "Telor";
            listBoxListItem.Items.Add(makanan[1]);
            minuman[0] = "Susu Sapi";
            listBoxListItem.Items.Add(minuman[0]);
            minuman[1] = "Kopi";
            listBoxListItem.Items.Add(minuman[1]);
            makanan[2] = "Roti";
            listBoxListItem.Items.Add(makanan[2]);
            makanan[3] = "Keju";
            listBoxListItem.Items.Add(makanan[3]);
            makanan[4] = "Daging Giling";
            listBoxListItem.Items.Add(makanan[4]);
            minuman[2] = "Teh";
            listBoxListItem.Items.Add(minuman[2]);
            minuman[3] = "Bir";
            listBoxListItem.Items.Add(minuman[3]);
            cmakan = cmakan + 5;
            cminum = cminum + 4;
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (textBoxNamaItem.Text == "" || !radioButtonMakanan.Checked && !radioButtonMinuman.Checked)
            {
                MessageBox.Show("!!!TOLONG BOS DIISI DULU DATA ITEM NYA!!!");
            }
            else if (listBoxListItem.Items.Contains(textBoxNamaItem.Text))
            {
                MessageBox.Show("!!! ITEM SUDAH ADA DI DALAM LIST !!!");
            }
            else
            {
                if (radioButtonMakanan.Checked == true)
                {
                    makanan[cmakan] = textBoxNamaItem.Text;
                    listBoxListItem.Items.Add(makanan[cmakan]);
                    cmakan++;
                }
                else if (radioButtonMinuman.Checked == true)
                {
                    minuman[cminum] = textBoxNamaItem.Text;
                    listBoxListItem.Items.Add(minuman[cminum]);
                    cminum++;
                }
            }
        }

        private void buttonSalin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBoxListItem.SelectedIndices.Count - 1; i++)
            {

                listBoxdisalin.Items.Add(listBoxListItem.SelectedItems[i]);

            }
            listBoxListItem.ClearSelected();
        }

        private void checkBoxmakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmakanan.Checked == true)
            {
                for (int i = 0; i < cmakan; i++)
                {
                    if (makanan[i] == "")
                    {

                    }
                    else
                    {
                        listBoxListItem.SetSelected(listBoxListItem.FindString(makanan[i]), true);
                    }
                }
            }
            else if (checkBoxmakanan.Checked == false)
            {
                listBoxListItem.ClearSelected();
                if (checkBoxminuman.Checked == true)
                {
                    for (int i = 0; i < cminum; i++)
                    {
                        if (minuman[i] == "")
                        {

                        }
                        else
                        {
                            listBoxListItem.SetSelected(listBoxListItem.FindString(minuman[i]), true);
                        }
                    }
                }
            }
        }

        private void listBoxListItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxListItem.SelectionMode = SelectionMode.MultiExtended;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (listBoxdisalin.Items.Count > 0) 
            {
                if (listBoxdisalin.SelectedItems.Count  > 0)
                {
                    listBoxdisalin.Items.Remove(listBoxdisalin.SelectedItem);
                    listBoxdisalin.ClearSelected();
                }
                else if (listBoxdisalin.SelectedItems.Count == 0)
                {
                    listBoxdisalin.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("!!!SUDAH KOSONG BOS QUE!!!");
            }
        }

        private void checkBoxminuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxminuman.Checked == true)
            {
                for (int i = 0; i < cminum; i++)
                {
                    if (minuman[i] == "")
                    {

                    }
                    else
                    {
                        listBoxListItem.SetSelected(listBoxListItem.FindString(minuman[i]), true);
                    }
                }
            }
            else if (checkBoxminuman.Checked == false)
            {
                listBoxListItem.ClearSelected();
                if (checkBoxmakanan.Checked == true)
                {
                    for (int i = 0; i < cmakan; i++)
                    {
                        if (makanan[i] == "")
                        {

                        }
                        else
                        {
                            listBoxListItem.SetSelected(listBoxListItem.FindString(makanan[i]), true);
                        }
                    }
                }
            }
        }
    }
}
