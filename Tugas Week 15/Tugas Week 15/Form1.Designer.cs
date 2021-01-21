
namespace Tugas_Week_15
{
    partial class FormUtama
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
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.textBoxNamaItem = new System.Windows.Forms.TextBox();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.groupBoxJenis = new System.Windows.Forms.GroupBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBoxListItem = new System.Windows.Forms.ListBox();
            this.listBoxdisalin = new System.Windows.Forms.ListBox();
            this.buttonSalin = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.checkBoxmakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxminuman = new System.Windows.Forms.CheckBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.groupBoxJenis.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(27, 39);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(75, 17);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(30, 90);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(61, 17);
            this.labelKategori.TabIndex = 1;
            this.labelKategori.Text = "Kategori";
            // 
            // textBoxNamaItem
            // 
            this.textBoxNamaItem.Location = new System.Drawing.Point(170, 39);
            this.textBoxNamaItem.Name = "textBoxNamaItem";
            this.textBoxNamaItem.Size = new System.Drawing.Size(191, 22);
            this.textBoxNamaItem.TabIndex = 2;
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(23, 9);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(87, 21);
            this.radioButtonMakanan.TabIndex = 3;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(128, 9);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(86, 21);
            this.radioButtonMinuman.TabIndex = 4;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            // 
            // groupBoxJenis
            // 
            this.groupBoxJenis.Controls.Add(this.radioButtonMinuman);
            this.groupBoxJenis.Controls.Add(this.radioButtonMakanan);
            this.groupBoxJenis.Location = new System.Drawing.Point(147, 77);
            this.groupBoxJenis.Name = "groupBoxJenis";
            this.groupBoxJenis.Size = new System.Drawing.Size(231, 45);
            this.groupBoxJenis.TabIndex = 5;
            this.groupBoxJenis.TabStop = false;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(170, 128);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(87, 28);
            this.buttonInput.TabIndex = 6;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBoxListItem
            // 
            this.listBoxListItem.FormattingEnabled = true;
            this.listBoxListItem.ItemHeight = 16;
            this.listBoxListItem.Location = new System.Drawing.Point(33, 186);
            this.listBoxListItem.Name = "listBoxListItem";
            this.listBoxListItem.Size = new System.Drawing.Size(170, 244);
            this.listBoxListItem.TabIndex = 7;
            this.listBoxListItem.SelectedIndexChanged += new System.EventHandler(this.listBoxListItem_SelectedIndexChanged);
            // 
            // listBoxdisalin
            // 
            this.listBoxdisalin.FormattingEnabled = true;
            this.listBoxdisalin.ItemHeight = 16;
            this.listBoxdisalin.Location = new System.Drawing.Point(401, 186);
            this.listBoxdisalin.Name = "listBoxdisalin";
            this.listBoxdisalin.Size = new System.Drawing.Size(170, 244);
            this.listBoxdisalin.TabIndex = 8;
            // 
            // buttonSalin
            // 
            this.buttonSalin.Location = new System.Drawing.Point(263, 203);
            this.buttonSalin.Name = "buttonSalin";
            this.buttonSalin.Size = new System.Drawing.Size(75, 23);
            this.buttonSalin.TabIndex = 9;
            this.buttonSalin.Text = ">";
            this.buttonSalin.UseVisualStyleBackColor = true;
            this.buttonSalin.Click += new System.EventHandler(this.buttonSalin_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(263, 245);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 10;
            this.buttonHapus.Text = "X";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // checkBoxmakanan
            // 
            this.checkBoxmakanan.AutoSize = true;
            this.checkBoxmakanan.Location = new System.Drawing.Point(19, 24);
            this.checkBoxmakanan.Name = "checkBoxmakanan";
            this.checkBoxmakanan.Size = new System.Drawing.Size(88, 21);
            this.checkBoxmakanan.TabIndex = 11;
            this.checkBoxmakanan.Text = "Makanan";
            this.checkBoxmakanan.UseVisualStyleBackColor = true;
            this.checkBoxmakanan.CheckedChanged += new System.EventHandler(this.checkBoxmakanan_CheckedChanged);
            // 
            // checkBoxminuman
            // 
            this.checkBoxminuman.AutoSize = true;
            this.checkBoxminuman.Location = new System.Drawing.Point(19, 51);
            this.checkBoxminuman.Name = "checkBoxminuman";
            this.checkBoxminuman.Size = new System.Drawing.Size(87, 21);
            this.checkBoxminuman.TabIndex = 12;
            this.checkBoxminuman.Text = "Minuman";
            this.checkBoxminuman.UseVisualStyleBackColor = true;
            this.checkBoxminuman.CheckedChanged += new System.EventHandler(this.checkBoxminuman_CheckedChanged);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.checkBoxminuman);
            this.groupBoxFilter.Controls.Add(this.checkBoxmakanan);
            this.groupBoxFilter.Location = new System.Drawing.Point(244, 304);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(116, 87);
            this.groupBoxFilter.TabIndex = 13;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonSalin);
            this.Controls.Add(this.listBoxdisalin);
            this.Controls.Add(this.listBoxListItem);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.groupBoxJenis);
            this.Controls.Add(this.textBoxNamaItem);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "FormUtama";
            this.Text = "Form";
            this.groupBoxJenis.ResumeLayout(false);
            this.groupBoxJenis.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.TextBox textBoxNamaItem;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.GroupBox groupBoxJenis;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBoxListItem;
        private System.Windows.Forms.ListBox listBoxdisalin;
        private System.Windows.Forms.Button buttonSalin;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.CheckBox checkBoxmakanan;
        private System.Windows.Forms.CheckBox checkBoxminuman;
        private System.Windows.Forms.GroupBox groupBoxFilter;
    }
}

