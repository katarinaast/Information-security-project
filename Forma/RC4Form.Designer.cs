
namespace Forma
{
    partial class RC4Form
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
            this.tbKljucRc4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUcitajFajlRc4 = new System.Windows.Forms.Button();
            this.tbUcitanFajlRC4 = new System.Windows.Forms.TextBox();
            this.tbEnkriptovanFajlRc4 = new System.Windows.Forms.TextBox();
            this.tbDekriptovanFajlRc4 = new System.Windows.Forms.TextBox();
            this.btnEncryptRC4 = new System.Windows.Forms.Button();
            this.btnDecryptRc4 = new System.Windows.Forms.Button();
            this.btnSacuvajUFajlRc4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite kljuc:";
            // 
            // tbKljucRc4
            // 
            this.tbKljucRc4.Location = new System.Drawing.Point(102, 42);
            this.tbKljucRc4.Name = "tbKljucRc4";
            this.tbKljucRc4.Size = new System.Drawing.Size(136, 20);
            this.tbKljucRc4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite fajl:";
            // 
            // btnUcitajFajlRc4
            // 
            this.btnUcitajFajlRc4.Location = new System.Drawing.Point(102, 85);
            this.btnUcitajFajlRc4.Name = "btnUcitajFajlRc4";
            this.btnUcitajFajlRc4.Size = new System.Drawing.Size(136, 23);
            this.btnUcitajFajlRc4.TabIndex = 4;
            this.btnUcitajFajlRc4.Text = "Ucitaj fajl";
            this.btnUcitajFajlRc4.UseVisualStyleBackColor = true;
            this.btnUcitajFajlRc4.Click += new System.EventHandler(this.btnUcitajFajlRc4_Click);
            // 
            // tbUcitanFajlRC4
            // 
            this.tbUcitanFajlRC4.Location = new System.Drawing.Point(304, 42);
            this.tbUcitanFajlRC4.Multiline = true;
            this.tbUcitanFajlRC4.Name = "tbUcitanFajlRC4";
            this.tbUcitanFajlRC4.Size = new System.Drawing.Size(140, 192);
            this.tbUcitanFajlRC4.TabIndex = 5;
            // 
            // tbEnkriptovanFajlRc4
            // 
            this.tbEnkriptovanFajlRc4.Location = new System.Drawing.Point(478, 42);
            this.tbEnkriptovanFajlRc4.Multiline = true;
            this.tbEnkriptovanFajlRc4.Name = "tbEnkriptovanFajlRc4";
            this.tbEnkriptovanFajlRc4.Size = new System.Drawing.Size(132, 189);
            this.tbEnkriptovanFajlRc4.TabIndex = 6;
            // 
            // tbDekriptovanFajlRc4
            // 
            this.tbDekriptovanFajlRc4.Location = new System.Drawing.Point(651, 42);
            this.tbDekriptovanFajlRc4.Multiline = true;
            this.tbDekriptovanFajlRc4.Name = "tbDekriptovanFajlRc4";
            this.tbDekriptovanFajlRc4.Size = new System.Drawing.Size(116, 192);
            this.tbDekriptovanFajlRc4.TabIndex = 7;
            // 
            // btnEncryptRC4
            // 
            this.btnEncryptRC4.Location = new System.Drawing.Point(304, 278);
            this.btnEncryptRC4.Name = "btnEncryptRC4";
            this.btnEncryptRC4.Size = new System.Drawing.Size(140, 23);
            this.btnEncryptRC4.TabIndex = 8;
            this.btnEncryptRC4.Text = "Enkriptuj";
            this.btnEncryptRC4.UseVisualStyleBackColor = true;
            this.btnEncryptRC4.Click += new System.EventHandler(this.btnEncryptRC4_Click);
            // 
            // btnDecryptRc4
            // 
            this.btnDecryptRc4.Location = new System.Drawing.Point(478, 278);
            this.btnDecryptRc4.Name = "btnDecryptRc4";
            this.btnDecryptRc4.Size = new System.Drawing.Size(132, 23);
            this.btnDecryptRc4.TabIndex = 9;
            this.btnDecryptRc4.Text = "Dekriptuj";
            this.btnDecryptRc4.UseVisualStyleBackColor = true;
            this.btnDecryptRc4.Click += new System.EventHandler(this.btnDecryptRc4_Click);
            // 
            // btnSacuvajUFajlRc4
            // 
            this.btnSacuvajUFajlRc4.Location = new System.Drawing.Point(651, 278);
            this.btnSacuvajUFajlRc4.Name = "btnSacuvajUFajlRc4";
            this.btnSacuvajUFajlRc4.Size = new System.Drawing.Size(116, 23);
            this.btnSacuvajUFajlRc4.TabIndex = 10;
            this.btnSacuvajUFajlRc4.Text = "Sacuvaj u fajl";
            this.btnSacuvajUFajlRc4.UseVisualStyleBackColor = true;
            this.btnSacuvajUFajlRc4.Click += new System.EventHandler(this.btnSacuvajUFajlRc4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ucitan fajl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enkriptovan fajl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dekriptovan fajl:";
            // 
            // RC4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSacuvajUFajlRc4);
            this.Controls.Add(this.btnDecryptRc4);
            this.Controls.Add(this.btnEncryptRC4);
            this.Controls.Add(this.tbDekriptovanFajlRc4);
            this.Controls.Add(this.tbEnkriptovanFajlRc4);
            this.Controls.Add(this.tbUcitanFajlRC4);
            this.Controls.Add(this.btnUcitajFajlRc4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKljucRc4);
            this.Controls.Add(this.label1);
            this.Name = "RC4Form";
            this.Text = "RC4Form";
            this.Load += new System.EventHandler(this.RC4Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKljucRc4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUcitajFajlRc4;
        private System.Windows.Forms.TextBox tbUcitanFajlRC4;
        private System.Windows.Forms.TextBox tbEnkriptovanFajlRc4;
        private System.Windows.Forms.TextBox tbDekriptovanFajlRc4;
        private System.Windows.Forms.Button btnEncryptRC4;
        private System.Windows.Forms.Button btnDecryptRc4;
        private System.Windows.Forms.Button btnSacuvajUFajlRc4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}