using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_14
{
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }

        private void buttonkonversi_Click(object sender, EventArgs e)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] huruf = alfabet.ToCharArray();

            string kalimat = textBoxinputkalimat.Text;
            char[] kalimatarray = kalimat.ToCharArray();
            char[] besar = new char[kalimatarray.Length];
            char spasi = Convert.ToChar(" ");
            for (int i = 0; i < kalimatarray.Length; i++)
            {
                besar[i] = char.ToUpper(kalimatarray[i]);
            }

            char diubah = Convert.ToChar(textBoxinputhuruf.Text);
            char menjadi = Convert.ToChar(textBoxinputjadi.Text);
            int beda = menjadi - diubah;
            if (beda < 0)
            {
                beda += 26;
            }
            int bedadiubah;
            char[] kalimatdiubah = new char[besar.Length];
            for (int i = 0; i < kalimatdiubah.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (besar[i] == alfabet[j])
                    {
                        bedadiubah = j + beda;
                        if (bedadiubah >= 26)
                        {
                            bedadiubah -= 26;
                        }
                        kalimatdiubah[i] = huruf[bedadiubah];

                    }
                    else if (besar[i] == spasi)
                    {
                        kalimatdiubah[i] = spasi;
                    }
                }
            }

            string terubah = new string(kalimatdiubah);

            labeloutputhasil.Text = terubah;
        }
    }
}
