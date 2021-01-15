
namespace Praktikum_Week_15
{
    partial class Form1
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
            this.buttonBeli = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxMakanan = new System.Windows.Forms.ComboBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.comboBoxMinuman = new System.Windows.Forms.ComboBox();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.groupBoxJenismakanan = new System.Windows.Forms.GroupBox();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.groupBoxJenismakanan.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBeli
            // 
            this.buttonBeli.Location = new System.Drawing.Point(300, 273);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.Size = new System.Drawing.Size(75, 23);
            this.buttonBeli.TabIndex = 0;
            this.buttonBeli.Text = "Beli";
            this.buttonBeli.UseVisualStyleBackColor = true;
            this.buttonBeli.Click += new System.EventHandler(this.buttonBeli_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(159, 358);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(150, 71);
            this.buttonCheckout.TabIndex = 1;
            this.buttonCheckout.Text = "Check Out";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(477, 382);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxMakanan
            // 
            this.comboBoxMakanan.FormattingEnabled = true;
            this.comboBoxMakanan.Items.AddRange(new object[] {
            "Nasi Goreng",
            "Nasi Goreng Spesial",
            "Nasi Goreng Pete",
            "Ayam Bakar"});
            this.comboBoxMakanan.Location = new System.Drawing.Point(101, 164);
            this.comboBoxMakanan.Name = "comboBoxMakanan";
            this.comboBoxMakanan.Size = new System.Drawing.Size(154, 24);
            this.comboBoxMakanan.TabIndex = 3;
            this.comboBoxMakanan.SelectedIndexChanged += new System.EventHandler(this.comboBoxMakanan_SelectedIndexChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(29, 171);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(43, 17);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Menu";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(297, 171);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(47, 17);
            this.labelHarga.TabIndex = 5;
            this.labelHarga.Text = "Harga";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(590, 30);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(46, 17);
            this.labelItems.TabIndex = 6;
            this.labelItems.Text = "label1";
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(19, 17);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(87, 21);
            this.radioButtonMakanan.TabIndex = 7;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(145, 17);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(86, 21);
            this.radioButtonMinuman.TabIndex = 8;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 16;
            this.listBoxMenu.Location = new System.Drawing.Point(477, 79);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(148, 276);
            this.listBoxMenu.TabIndex = 9;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.ItemHeight = 16;
            this.listBoxHarga.Location = new System.Drawing.Point(631, 79);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(148, 276);
            this.listBoxHarga.TabIndex = 10;
            // 
            // comboBoxMinuman
            // 
            this.comboBoxMinuman.FormattingEnabled = true;
            this.comboBoxMinuman.Items.AddRange(new object[] {
            "Es Teh",
            "Teh Hangat",
            "Nutrisari",
            "Aqua"});
            this.comboBoxMinuman.Location = new System.Drawing.Point(101, 164);
            this.comboBoxMinuman.Name = "comboBoxMinuman";
            this.comboBoxMinuman.Size = new System.Drawing.Size(154, 24);
            this.comboBoxMinuman.TabIndex = 11;
            this.comboBoxMinuman.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinuman_SelectedIndexChanged);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(10, 38);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(74, 21);
            this.radioButtonNormal.TabIndex = 12;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(136, 38);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(71, 21);
            this.radioButtonJumbo.TabIndex = 13;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            // 
            // groupBoxJenismakanan
            // 
            this.groupBoxJenismakanan.Controls.Add(this.radioButtonMinuman);
            this.groupBoxJenismakanan.Controls.Add(this.radioButtonMakanan);
            this.groupBoxJenismakanan.Location = new System.Drawing.Point(13, 71);
            this.groupBoxJenismakanan.Name = "groupBoxJenismakanan";
            this.groupBoxJenismakanan.Size = new System.Drawing.Size(250, 56);
            this.groupBoxJenismakanan.TabIndex = 15;
            this.groupBoxJenismakanan.TabStop = false;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonJumbo);
            this.groupBoxSize.Controls.Add(this.radioButtonNormal);
            this.groupBoxSize.Location = new System.Drawing.Point(23, 235);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(240, 92);
            this.groupBoxSize.TabIndex = 16;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxJenismakanan);
            this.Controls.Add(this.comboBoxMinuman);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.comboBoxMakanan);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonBeli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxJenismakanan.ResumeLayout(false);
            this.groupBoxJenismakanan.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBeli;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxMakanan;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.ComboBox comboBoxMinuman;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.GroupBox groupBoxJenismakanan;
        private System.Windows.Forms.GroupBox groupBoxSize;
    }
}

