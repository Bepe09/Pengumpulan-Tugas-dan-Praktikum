
namespace Tugas_Week_14
{
    partial class FormTugas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelkalimat = new System.Windows.Forms.Label();
            this.labelhuruf = new System.Windows.Forms.Label();
            this.labelmenjadi = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.labeloutputhasil = new System.Windows.Forms.Label();
            this.textBoxinputkalimat = new System.Windows.Forms.TextBox();
            this.textBoxinputhuruf = new System.Windows.Forms.TextBox();
            this.textBoxinputjadi = new System.Windows.Forms.TextBox();
            this.buttonkonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelkalimat
            // 
            this.labelkalimat.AutoSize = true;
            this.labelkalimat.Location = new System.Drawing.Point(41, 62);
            this.labelkalimat.Name = "labelkalimat";
            this.labelkalimat.Size = new System.Drawing.Size(122, 17);
            this.labelkalimat.TabIndex = 0;
            this.labelkalimat.Text = "Masukkan Kalimat";
            // 
            // labelhuruf
            // 
            this.labelhuruf.AutoSize = true;
            this.labelhuruf.Location = new System.Drawing.Point(41, 118);
            this.labelhuruf.Name = "labelhuruf";
            this.labelhuruf.Size = new System.Drawing.Size(111, 17);
            this.labelhuruf.TabIndex = 1;
            this.labelhuruf.Text = "Masukkan Huruf";
            // 
            // labelmenjadi
            // 
            this.labelmenjadi.AutoSize = true;
            this.labelmenjadi.Location = new System.Drawing.Point(397, 118);
            this.labelmenjadi.Name = "labelmenjadi";
            this.labelmenjadi.Size = new System.Drawing.Size(57, 17);
            this.labelmenjadi.TabIndex = 2;
            this.labelmenjadi.Text = "Menjadi";
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(41, 342);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(55, 17);
            this.labelhasil.TabIndex = 3;
            this.labelhasil.Text = "Hasil = ";
            // 
            // labeloutputhasil
            // 
            this.labeloutputhasil.AutoSize = true;
            this.labeloutputhasil.Location = new System.Drawing.Point(206, 342);
            this.labeloutputhasil.Name = "labeloutputhasil";
            this.labeloutputhasil.Size = new System.Drawing.Size(12, 17);
            this.labeloutputhasil.TabIndex = 4;
            this.labeloutputhasil.Text = " ";
            // 
            // textBoxinputkalimat
            // 
            this.textBoxinputkalimat.Location = new System.Drawing.Point(209, 62);
            this.textBoxinputkalimat.Name = "textBoxinputkalimat";
            this.textBoxinputkalimat.Size = new System.Drawing.Size(437, 22);
            this.textBoxinputkalimat.TabIndex = 5;
            // 
            // textBoxinputhuruf
            // 
            this.textBoxinputhuruf.Location = new System.Drawing.Point(209, 113);
            this.textBoxinputhuruf.Name = "textBoxinputhuruf";
            this.textBoxinputhuruf.Size = new System.Drawing.Size(100, 22);
            this.textBoxinputhuruf.TabIndex = 6;
            // 
            // textBoxinputjadi
            // 
            this.textBoxinputjadi.Location = new System.Drawing.Point(546, 115);
            this.textBoxinputjadi.Name = "textBoxinputjadi";
            this.textBoxinputjadi.Size = new System.Drawing.Size(100, 22);
            this.textBoxinputjadi.TabIndex = 7;
            // 
            // buttonkonversi
            // 
            this.buttonkonversi.Location = new System.Drawing.Point(209, 236);
            this.buttonkonversi.Name = "buttonkonversi";
            this.buttonkonversi.Size = new System.Drawing.Size(437, 23);
            this.buttonkonversi.TabIndex = 8;
            this.buttonkonversi.Text = "KONVERSI";
            this.buttonkonversi.UseVisualStyleBackColor = true;
            this.buttonkonversi.Click += new System.EventHandler(this.buttonkonversi_Click);
            // 
            // FormTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonkonversi);
            this.Controls.Add(this.textBoxinputjadi);
            this.Controls.Add(this.textBoxinputhuruf);
            this.Controls.Add(this.textBoxinputkalimat);
            this.Controls.Add(this.labeloutputhasil);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.labelmenjadi);
            this.Controls.Add(this.labelhuruf);
            this.Controls.Add(this.labelkalimat);
            this.Name = "FormTugas";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkalimat;
        private System.Windows.Forms.Label labelhuruf;
        private System.Windows.Forms.Label labelmenjadi;
        private System.Windows.Forms.Label labelhasil;
        private System.Windows.Forms.Label labeloutputhasil;
        private System.Windows.Forms.TextBox textBoxinputkalimat;
        private System.Windows.Forms.TextBox textBoxinputhuruf;
        private System.Windows.Forms.TextBox textBoxinputjadi;
        private System.Windows.Forms.Button buttonkonversi;
    }
}

