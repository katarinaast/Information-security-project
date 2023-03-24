
namespace Forma
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnrc4 = new System.Windows.Forms.Button();
            this.btnEnigma = new System.Windows.Forms.Button();
            this.btnCBC = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite algoritam:";
            // 
            // btnrc4
            // 
            this.btnrc4.Location = new System.Drawing.Point(90, 169);
            this.btnrc4.Name = "btnrc4";
            this.btnrc4.Size = new System.Drawing.Size(75, 23);
            this.btnrc4.TabIndex = 1;
            this.btnrc4.Text = "RC4";
            this.btnrc4.UseVisualStyleBackColor = true;
            this.btnrc4.Click += new System.EventHandler(this.btnrc4_Click);
            // 
            // btnEnigma
            // 
            this.btnEnigma.Location = new System.Drawing.Point(415, 169);
            this.btnEnigma.Name = "btnEnigma";
            this.btnEnigma.Size = new System.Drawing.Size(75, 23);
            this.btnEnigma.TabIndex = 2;
            this.btnEnigma.Text = "Enigma";
            this.btnEnigma.UseVisualStyleBackColor = true;
            this.btnEnigma.Click += new System.EventHandler(this.btnEnigma_Click);
            // 
            // btnCBC
            // 
            this.btnCBC.Location = new System.Drawing.Point(556, 169);
            this.btnCBC.Name = "btnCBC";
            this.btnCBC.Size = new System.Drawing.Size(75, 23);
            this.btnCBC.TabIndex = 3;
            this.btnCBC.Text = "CBC";
            this.btnCBC.UseVisualStyleBackColor = true;
            this.btnCBC.Click += new System.EventHandler(this.btnCBC_Click);
            // 
            // btnTea
            // 
            this.btnTea.Location = new System.Drawing.Point(244, 169);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(75, 23);
            this.btnTea.TabIndex = 4;
            this.btnTea.Text = "TEA";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.btnCBC);
            this.Controls.Add(this.btnEnigma);
            this.Controls.Add(this.btnrc4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrc4;
        private System.Windows.Forms.Button btnEnigma;
        private System.Windows.Forms.Button btnCBC;
        private System.Windows.Forms.Button btnTea;
    }
}

