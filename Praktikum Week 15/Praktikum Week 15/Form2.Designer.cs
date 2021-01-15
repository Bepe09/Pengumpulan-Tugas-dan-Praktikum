
namespace Praktikum_Week_15
{
    partial class Form2
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
            this.checkBoxDiskon = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubtotalAngka = new System.Windows.Forms.Label();
            this.labelTaxAngka = new System.Windows.Forms.Label();
            this.labelDiscountAngka = new System.Windows.Forms.Label();
            this.labelTotalAngka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxDiskon
            // 
            this.checkBoxDiskon.AutoSize = true;
            this.checkBoxDiskon.Location = new System.Drawing.Point(27, 26);
            this.checkBoxDiskon.Name = "checkBoxDiskon";
            this.checkBoxDiskon.Size = new System.Drawing.Size(85, 21);
            this.checkBoxDiskon.TabIndex = 0;
            this.checkBoxDiskon.Text = "Discount";
            this.checkBoxDiskon.UseVisualStyleBackColor = true;
            this.checkBoxDiskon.CheckedChanged += new System.EventHandler(this.checkBoxDiskon_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(27, 180);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(323, 57);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(60, 17);
            this.labelSubtotal.TabIndex = 2;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(323, 100);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(31, 17);
            this.labelTax.TabIndex = 3;
            this.labelTax.Text = "Tax";
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.Location = new System.Drawing.Point(323, 142);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(63, 17);
            this.labelDiskon.TabIndex = 4;
            this.labelDiskon.Text = "Discount";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(323, 186);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 17);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // labelSubtotalAngka
            // 
            this.labelSubtotalAngka.AutoSize = true;
            this.labelSubtotalAngka.Location = new System.Drawing.Point(442, 57);
            this.labelSubtotalAngka.Name = "labelSubtotalAngka";
            this.labelSubtotalAngka.Size = new System.Drawing.Size(16, 17);
            this.labelSubtotalAngka.TabIndex = 6;
            this.labelSubtotalAngka.Text = "0";
            // 
            // labelTaxAngka
            // 
            this.labelTaxAngka.AutoSize = true;
            this.labelTaxAngka.Location = new System.Drawing.Point(442, 100);
            this.labelTaxAngka.Name = "labelTaxAngka";
            this.labelTaxAngka.Size = new System.Drawing.Size(16, 17);
            this.labelTaxAngka.TabIndex = 7;
            this.labelTaxAngka.Text = "0";
            // 
            // labelDiscountAngka
            // 
            this.labelDiscountAngka.AutoSize = true;
            this.labelDiscountAngka.Location = new System.Drawing.Point(442, 142);
            this.labelDiscountAngka.Name = "labelDiscountAngka";
            this.labelDiscountAngka.Size = new System.Drawing.Size(16, 17);
            this.labelDiscountAngka.TabIndex = 8;
            this.labelDiscountAngka.Text = "0";
            // 
            // labelTotalAngka
            // 
            this.labelTotalAngka.AutoSize = true;
            this.labelTotalAngka.Location = new System.Drawing.Point(442, 186);
            this.labelTotalAngka.Name = "labelTotalAngka";
            this.labelTotalAngka.Size = new System.Drawing.Size(16, 17);
            this.labelTotalAngka.TabIndex = 9;
            this.labelTotalAngka.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalAngka);
            this.Controls.Add(this.labelDiscountAngka);
            this.Controls.Add(this.labelTaxAngka);
            this.Controls.Add(this.labelSubtotalAngka);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiskon);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.checkBoxDiskon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDiskon;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubtotalAngka;
        private System.Windows.Forms.Label labelTaxAngka;
        private System.Windows.Forms.Label labelDiscountAngka;
        private System.Windows.Forms.Label labelTotalAngka;
    }
}