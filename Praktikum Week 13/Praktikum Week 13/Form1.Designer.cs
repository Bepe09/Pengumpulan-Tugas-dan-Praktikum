
namespace Praktikum_Week_13
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
            this.labelEmpty = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Location = new System.Drawing.Point(78, 334);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(63, 17);
            this.labelEmpty.TabIndex = 0;
            this.labelEmpty.Text = "[EMPTY]";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(78, 42);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(81, 17);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Input Data :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(81, 82);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(324, 22);
            this.textBoxInput.TabIndex = 2;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(81, 201);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(150, 46);
            this.buttonProses.TabIndex = 3;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelEmpty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonProses;
    }
}

