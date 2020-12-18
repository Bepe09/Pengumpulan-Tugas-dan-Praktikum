
namespace Praktikum_Week_14
{
    partial class Formstring
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
            this.labelinput = new System.Windows.Forms.Label();
            this.buttonsort = new System.Windows.Forms.Button();
            this.buttonreverse = new System.Windows.Forms.Button();
            this.labeloutput = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinput.Location = new System.Drawing.Point(61, 66);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(86, 32);
            this.labelinput.TabIndex = 0;
            this.labelinput.Text = "Input!";
            // 
            // buttonsort
            // 
            this.buttonsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsort.Location = new System.Drawing.Point(67, 225);
            this.buttonsort.Name = "buttonsort";
            this.buttonsort.Size = new System.Drawing.Size(124, 42);
            this.buttonsort.TabIndex = 1;
            this.buttonsort.Text = "Sort";
            this.buttonsort.UseVisualStyleBackColor = true;
            this.buttonsort.Click += new System.EventHandler(this.buttonsort_Click);
            // 
            // buttonreverse
            // 
            this.buttonreverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreverse.Location = new System.Drawing.Point(259, 225);
            this.buttonreverse.Name = "buttonreverse";
            this.buttonreverse.Size = new System.Drawing.Size(124, 42);
            this.buttonreverse.TabIndex = 2;
            this.buttonreverse.Text = "Reverse";
            this.buttonreverse.UseVisualStyleBackColor = true;
            this.buttonreverse.Click += new System.EventHandler(this.buttonreverse_Click);
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloutput.Location = new System.Drawing.Point(61, 335);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(109, 32);
            this.labeloutput.TabIndex = 3;
            this.labeloutput.Text = "Output!";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxinput.Location = new System.Drawing.Point(67, 119);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(316, 38);
            this.textBoxinput.TabIndex = 4;
            // 
            // Formstring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.buttonreverse);
            this.Controls.Add(this.buttonsort);
            this.Controls.Add(this.labelinput);
            this.Name = "Formstring";
            this.Text = "Praktikum Week 14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.Button buttonsort;
        private System.Windows.Forms.Button buttonreverse;
        private System.Windows.Forms.Label labeloutput;
        private System.Windows.Forms.TextBox textBoxinput;
    }
}

