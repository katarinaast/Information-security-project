
namespace Forma
{
    partial class EnigmaForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbKljucEnigma = new System.Windows.Forms.TextBox();
            this.btnUcitajFajlEnigma = new System.Windows.Forms.Button();
            this.tbUcitanFajlEnigma = new System.Windows.Forms.TextBox();
            this.tbDekriptovanFajlEnigma = new System.Windows.Forms.TextBox();
            this.tbEnkriptovanFajlEnigma = new System.Windows.Forms.TextBox();
            this.btnEnkriptujFajlEnigma = new System.Windows.Forms.Button();
            this.btnDekriptujFajlEnigma = new System.Windows.Forms.Button();
            this.btnSacuvajUFajlEnigma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlugboardEnigma = new System.Windows.Forms.TextBox();
            this.tbReflektorEnigma = new System.Windows.Forms.TextBox();
            this.btnDefaultEnigma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite kljuc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Izaberite fajl:";
            // 
            // tbKljucEnigma
            // 
            this.tbKljucEnigma.Location = new System.Drawing.Point(122, 31);
            this.tbKljucEnigma.Name = "tbKljucEnigma";
            this.tbKljucEnigma.Size = new System.Drawing.Size(100, 20);
            this.tbKljucEnigma.TabIndex = 4;
            this.tbKljucEnigma.TextChanged += new System.EventHandler(this.tbKljucEnigma_TextChanged);
            // 
            // btnUcitajFajlEnigma
            // 
            this.btnUcitajFajlEnigma.Location = new System.Drawing.Point(122, 176);
            this.btnUcitajFajlEnigma.Name = "btnUcitajFajlEnigma";
            this.btnUcitajFajlEnigma.Size = new System.Drawing.Size(100, 23);
            this.btnUcitajFajlEnigma.TabIndex = 5;
            this.btnUcitajFajlEnigma.Text = "Ucitajte fajl";
            this.btnUcitajFajlEnigma.UseVisualStyleBackColor = true;
            this.btnUcitajFajlEnigma.Click += new System.EventHandler(this.btnUcitajFajlEnigma_Click);
            // 
            // tbUcitanFajlEnigma
            // 
            this.tbUcitanFajlEnigma.Location = new System.Drawing.Point(303, 31);
            this.tbUcitanFajlEnigma.Multiline = true;
            this.tbUcitanFajlEnigma.Name = "tbUcitanFajlEnigma";
            this.tbUcitanFajlEnigma.Size = new System.Drawing.Size(100, 213);
            this.tbUcitanFajlEnigma.TabIndex = 6;
            // 
            // tbDekriptovanFajlEnigma
            // 
            this.tbDekriptovanFajlEnigma.Location = new System.Drawing.Point(626, 31);
            this.tbDekriptovanFajlEnigma.Multiline = true;
            this.tbDekriptovanFajlEnigma.Name = "tbDekriptovanFajlEnigma";
            this.tbDekriptovanFajlEnigma.Size = new System.Drawing.Size(100, 213);
            this.tbDekriptovanFajlEnigma.TabIndex = 7;
            // 
            // tbEnkriptovanFajlEnigma
            // 
            this.tbEnkriptovanFajlEnigma.Location = new System.Drawing.Point(463, 31);
            this.tbEnkriptovanFajlEnigma.Multiline = true;
            this.tbEnkriptovanFajlEnigma.Name = "tbEnkriptovanFajlEnigma";
            this.tbEnkriptovanFajlEnigma.Size = new System.Drawing.Size(100, 213);
            this.tbEnkriptovanFajlEnigma.TabIndex = 8;
            // 
            // btnEnkriptujFajlEnigma
            // 
            this.btnEnkriptujFajlEnigma.Location = new System.Drawing.Point(303, 272);
            this.btnEnkriptujFajlEnigma.Name = "btnEnkriptujFajlEnigma";
            this.btnEnkriptujFajlEnigma.Size = new System.Drawing.Size(100, 23);
            this.btnEnkriptujFajlEnigma.TabIndex = 9;
            this.btnEnkriptujFajlEnigma.Text = "Enkriptuj";
            this.btnEnkriptujFajlEnigma.UseVisualStyleBackColor = true;
            this.btnEnkriptujFajlEnigma.Click += new System.EventHandler(this.btnEnkriptujFajlEnigma_Click);
            // 
            // btnDekriptujFajlEnigma
            // 
            this.btnDekriptujFajlEnigma.Location = new System.Drawing.Point(463, 272);
            this.btnDekriptujFajlEnigma.Name = "btnDekriptujFajlEnigma";
            this.btnDekriptujFajlEnigma.Size = new System.Drawing.Size(100, 23);
            this.btnDekriptujFajlEnigma.TabIndex = 10;
            this.btnDekriptujFajlEnigma.Text = "Dekriptuj";
            this.btnDekriptujFajlEnigma.UseVisualStyleBackColor = true;
            this.btnDekriptujFajlEnigma.Click += new System.EventHandler(this.btnDekriptujFajlEnigma_Click);
            // 
            // btnSacuvajUFajlEnigma
            // 
            this.btnSacuvajUFajlEnigma.Location = new System.Drawing.Point(626, 272);
            this.btnSacuvajUFajlEnigma.Name = "btnSacuvajUFajlEnigma";
            this.btnSacuvajUFajlEnigma.Size = new System.Drawing.Size(100, 23);
            this.btnSacuvajUFajlEnigma.TabIndex = 11;
            this.btnSacuvajUFajlEnigma.Text = "Sacuvaj u fajl";
            this.btnSacuvajUFajlEnigma.UseVisualStyleBackColor = true;
            this.btnSacuvajUFajlEnigma.Click += new System.EventHandler(this.btnSacuvajUFajlEnigma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Unesite plugboard:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unesite reflektor:";
            // 
            // tbPlugboardEnigma
            // 
            this.tbPlugboardEnigma.Location = new System.Drawing.Point(122, 126);
            this.tbPlugboardEnigma.Name = "tbPlugboardEnigma";
            this.tbPlugboardEnigma.Size = new System.Drawing.Size(100, 20);
            this.tbPlugboardEnigma.TabIndex = 16;
            // 
            // tbReflektorEnigma
            // 
            this.tbReflektorEnigma.Location = new System.Drawing.Point(122, 76);
            this.tbReflektorEnigma.Name = "tbReflektorEnigma";
            this.tbReflektorEnigma.Size = new System.Drawing.Size(100, 20);
            this.tbReflektorEnigma.TabIndex = 17;
            // 
            // btnDefaultEnigma
            // 
            this.btnDefaultEnigma.Location = new System.Drawing.Point(15, 236);
            this.btnDefaultEnigma.Name = "btnDefaultEnigma";
            this.btnDefaultEnigma.Size = new System.Drawing.Size(207, 23);
            this.btnDefaultEnigma.TabIndex = 18;
            this.btnDefaultEnigma.Text = "Unesite podrazumevane vrednosti:";
            this.btnDefaultEnigma.UseVisualStyleBackColor = true;
            this.btnDefaultEnigma.Click += new System.EventHandler(this.btnDefaultEnigma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "*Napomena: Tekst koji enkriptujete treba da se sastoji iskljucivo od velikih slov" +
    "a abecede";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ucitan fajl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dekriptovan fajl:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enkriptovan fajl:";
            // 
            // EnigmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDefaultEnigma);
            this.Controls.Add(this.tbReflektorEnigma);
            this.Controls.Add(this.tbPlugboardEnigma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSacuvajUFajlEnigma);
            this.Controls.Add(this.btnDekriptujFajlEnigma);
            this.Controls.Add(this.btnEnkriptujFajlEnigma);
            this.Controls.Add(this.tbEnkriptovanFajlEnigma);
            this.Controls.Add(this.tbDekriptovanFajlEnigma);
            this.Controls.Add(this.tbUcitanFajlEnigma);
            this.Controls.Add(this.btnUcitajFajlEnigma);
            this.Controls.Add(this.tbKljucEnigma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "EnigmaForm";
            this.Text = "EnigmaForm";
            this.Load += new System.EventHandler(this.EnigmaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKljucEnigma;
        private System.Windows.Forms.Button btnUcitajFajlEnigma;
        private System.Windows.Forms.TextBox tbUcitanFajlEnigma;
        private System.Windows.Forms.TextBox tbDekriptovanFajlEnigma;
        private System.Windows.Forms.TextBox tbEnkriptovanFajlEnigma;
        private System.Windows.Forms.Button btnEnkriptujFajlEnigma;
        private System.Windows.Forms.Button btnDekriptujFajlEnigma;
        private System.Windows.Forms.Button btnSacuvajUFajlEnigma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlugboardEnigma;
        private System.Windows.Forms.TextBox tbReflektorEnigma;
        private System.Windows.Forms.Button btnDefaultEnigma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}