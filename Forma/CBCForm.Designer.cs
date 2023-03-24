
namespace Forma
{
    partial class CBCForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUcitajFajlCBC = new System.Windows.Forms.Button();
            this.btnGenerisiVektorCBC = new System.Windows.Forms.Button();
            this.tbKljucCBC = new System.Windows.Forms.TextBox();
            this.tbVektorCBC = new System.Windows.Forms.TextBox();
            this.tbUcitanFajlCBC = new System.Windows.Forms.TextBox();
            this.tbEnkriptovanFajlCBC = new System.Windows.Forms.TextBox();
            this.tbDekriptovanFajlCBC = new System.Windows.Forms.TextBox();
            this.btnEnkriptujCBC = new System.Windows.Forms.Button();
            this.btnSacuvajUFajlCBC = new System.Windows.Forms.Button();
            this.btnDekriptujCBC = new System.Windows.Forms.Button();
            this.btnRandomKljucCBC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUcitajBmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPutanja = new System.Windows.Forms.TextBox();
            this.btnEnkriptujBMP = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDekriptujBitmapu = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite kljuc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izaberite fajl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unesite IV:";
            // 
            // btnUcitajFajlCBC
            // 
            this.btnUcitajFajlCBC.Location = new System.Drawing.Point(104, 218);
            this.btnUcitajFajlCBC.Name = "btnUcitajFajlCBC";
            this.btnUcitajFajlCBC.Size = new System.Drawing.Size(100, 23);
            this.btnUcitajFajlCBC.TabIndex = 3;
            this.btnUcitajFajlCBC.Text = "Ucitaj fajl";
            this.btnUcitajFajlCBC.UseVisualStyleBackColor = true;
            this.btnUcitajFajlCBC.Click += new System.EventHandler(this.btnUcitajFajlCBC_Click);
            // 
            // btnGenerisiVektorCBC
            // 
            this.btnGenerisiVektorCBC.Location = new System.Drawing.Point(22, 172);
            this.btnGenerisiVektorCBC.Name = "btnGenerisiVektorCBC";
            this.btnGenerisiVektorCBC.Size = new System.Drawing.Size(179, 23);
            this.btnGenerisiVektorCBC.TabIndex = 4;
            this.btnGenerisiVektorCBC.Text = "Generisi random vektor";
            this.btnGenerisiVektorCBC.UseVisualStyleBackColor = true;
            this.btnGenerisiVektorCBC.Click += new System.EventHandler(this.btnGenerisiVektorCBC_Click);
            // 
            // tbKljucCBC
            // 
            this.tbKljucCBC.Location = new System.Drawing.Point(104, 33);
            this.tbKljucCBC.Name = "tbKljucCBC";
            this.tbKljucCBC.Size = new System.Drawing.Size(100, 20);
            this.tbKljucCBC.TabIndex = 5;
            // 
            // tbVektorCBC
            // 
            this.tbVektorCBC.Location = new System.Drawing.Point(104, 125);
            this.tbVektorCBC.Name = "tbVektorCBC";
            this.tbVektorCBC.Size = new System.Drawing.Size(100, 20);
            this.tbVektorCBC.TabIndex = 6;
            // 
            // tbUcitanFajlCBC
            // 
            this.tbUcitanFajlCBC.Location = new System.Drawing.Point(307, 29);
            this.tbUcitanFajlCBC.Multiline = true;
            this.tbUcitanFajlCBC.Name = "tbUcitanFajlCBC";
            this.tbUcitanFajlCBC.Size = new System.Drawing.Size(100, 166);
            this.tbUcitanFajlCBC.TabIndex = 7;
            // 
            // tbEnkriptovanFajlCBC
            // 
            this.tbEnkriptovanFajlCBC.Location = new System.Drawing.Point(480, 33);
            this.tbEnkriptovanFajlCBC.Multiline = true;
            this.tbEnkriptovanFajlCBC.Name = "tbEnkriptovanFajlCBC";
            this.tbEnkriptovanFajlCBC.Size = new System.Drawing.Size(100, 162);
            this.tbEnkriptovanFajlCBC.TabIndex = 8;
            // 
            // tbDekriptovanFajlCBC
            // 
            this.tbDekriptovanFajlCBC.Location = new System.Drawing.Point(647, 29);
            this.tbDekriptovanFajlCBC.Multiline = true;
            this.tbDekriptovanFajlCBC.Name = "tbDekriptovanFajlCBC";
            this.tbDekriptovanFajlCBC.Size = new System.Drawing.Size(100, 166);
            this.tbDekriptovanFajlCBC.TabIndex = 9;
            // 
            // btnEnkriptujCBC
            // 
            this.btnEnkriptujCBC.Location = new System.Drawing.Point(307, 223);
            this.btnEnkriptujCBC.Name = "btnEnkriptujCBC";
            this.btnEnkriptujCBC.Size = new System.Drawing.Size(100, 23);
            this.btnEnkriptujCBC.TabIndex = 10;
            this.btnEnkriptujCBC.Text = "Enkriptuj";
            this.btnEnkriptujCBC.UseVisualStyleBackColor = true;
            this.btnEnkriptujCBC.Click += new System.EventHandler(this.btnEnkriptujCBC_Click);
            // 
            // btnSacuvajUFajlCBC
            // 
            this.btnSacuvajUFajlCBC.Location = new System.Drawing.Point(647, 223);
            this.btnSacuvajUFajlCBC.Name = "btnSacuvajUFajlCBC";
            this.btnSacuvajUFajlCBC.Size = new System.Drawing.Size(100, 23);
            this.btnSacuvajUFajlCBC.TabIndex = 11;
            this.btnSacuvajUFajlCBC.Text = "Sacuvaj u fajl";
            this.btnSacuvajUFajlCBC.UseVisualStyleBackColor = true;
            this.btnSacuvajUFajlCBC.Click += new System.EventHandler(this.btnSacuvajUFajlCBC_Click);
            // 
            // btnDekriptujCBC
            // 
            this.btnDekriptujCBC.Location = new System.Drawing.Point(480, 223);
            this.btnDekriptujCBC.Name = "btnDekriptujCBC";
            this.btnDekriptujCBC.Size = new System.Drawing.Size(100, 23);
            this.btnDekriptujCBC.TabIndex = 12;
            this.btnDekriptujCBC.Text = "Dekriptuj";
            this.btnDekriptujCBC.UseVisualStyleBackColor = true;
            this.btnDekriptujCBC.Click += new System.EventHandler(this.btnDekriptujCBC_Click);
            // 
            // btnRandomKljucCBC
            // 
            this.btnRandomKljucCBC.Location = new System.Drawing.Point(22, 78);
            this.btnRandomKljucCBC.Name = "btnRandomKljucCBC";
            this.btnRandomKljucCBC.Size = new System.Drawing.Size(182, 23);
            this.btnRandomKljucCBC.TabIndex = 13;
            this.btnRandomKljucCBC.Text = "Generisi random kljuc";
            this.btnRandomKljucCBC.UseVisualStyleBackColor = true;
            this.btnRandomKljucCBC.Click += new System.EventHandler(this.btnRandomKljucCBC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ucitan fajl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enkriptovan fajl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dekriptovan fajl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Izaberite bmp:";
            // 
            // btnUcitajBmp
            // 
            this.btnUcitajBmp.Location = new System.Drawing.Point(104, 267);
            this.btnUcitajBmp.Name = "btnUcitajBmp";
            this.btnUcitajBmp.Size = new System.Drawing.Size(97, 23);
            this.btnUcitajBmp.TabIndex = 18;
            this.btnUcitajBmp.Text = "Ucitaj bitmapu";
            this.btnUcitajBmp.UseVisualStyleBackColor = true;
            this.btnUcitajBmp.Click += new System.EventHandler(this.btnUcitajBmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(307, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 128);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // tbPutanja
            // 
            this.tbPutanja.Location = new System.Drawing.Point(307, 262);
            this.tbPutanja.Name = "tbPutanja";
            this.tbPutanja.Size = new System.Drawing.Size(440, 20);
            this.tbPutanja.TabIndex = 20;
            // 
            // btnEnkriptujBMP
            // 
            this.btnEnkriptujBMP.Location = new System.Drawing.Point(307, 422);
            this.btnEnkriptujBMP.Name = "btnEnkriptujBMP";
            this.btnEnkriptujBMP.Size = new System.Drawing.Size(109, 23);
            this.btnEnkriptujBMP.TabIndex = 21;
            this.btnEnkriptujBMP.Text = "Enkriptuj bitmapu";
            this.btnEnkriptujBMP.UseVisualStyleBackColor = true;
            this.btnEnkriptujBMP.Click += new System.EventHandler(this.btnEnkriptujBMP_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(471, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 128);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnDekriptujBitmapu
            // 
            this.btnDekriptujBitmapu.Location = new System.Drawing.Point(471, 422);
            this.btnDekriptujBitmapu.Name = "btnDekriptujBitmapu";
            this.btnDekriptujBitmapu.Size = new System.Drawing.Size(109, 23);
            this.btnDekriptujBitmapu.TabIndex = 23;
            this.btnDekriptujBitmapu.Text = "Dekriptuj bitmapu";
            this.btnDekriptujBitmapu.UseVisualStyleBackColor = true;
            this.btnDekriptujBitmapu.Click += new System.EventHandler(this.btnDekriptujBitmapu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(638, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 128);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // CBCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 472);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnDekriptujBitmapu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEnkriptujBMP);
            this.Controls.Add(this.tbPutanja);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUcitajBmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRandomKljucCBC);
            this.Controls.Add(this.btnDekriptujCBC);
            this.Controls.Add(this.btnSacuvajUFajlCBC);
            this.Controls.Add(this.btnEnkriptujCBC);
            this.Controls.Add(this.tbDekriptovanFajlCBC);
            this.Controls.Add(this.tbEnkriptovanFajlCBC);
            this.Controls.Add(this.tbUcitanFajlCBC);
            this.Controls.Add(this.tbVektorCBC);
            this.Controls.Add(this.tbKljucCBC);
            this.Controls.Add(this.btnGenerisiVektorCBC);
            this.Controls.Add(this.btnUcitajFajlCBC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CBCForm";
            this.Text = "CBCForm";
            this.Load += new System.EventHandler(this.CBCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUcitajFajlCBC;
        private System.Windows.Forms.Button btnGenerisiVektorCBC;
        private System.Windows.Forms.TextBox tbKljucCBC;
        private System.Windows.Forms.TextBox tbVektorCBC;
        private System.Windows.Forms.TextBox tbUcitanFajlCBC;
        private System.Windows.Forms.TextBox tbEnkriptovanFajlCBC;
        private System.Windows.Forms.TextBox tbDekriptovanFajlCBC;
        private System.Windows.Forms.Button btnEnkriptujCBC;
        private System.Windows.Forms.Button btnSacuvajUFajlCBC;
        private System.Windows.Forms.Button btnDekriptujCBC;
        private System.Windows.Forms.Button btnRandomKljucCBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUcitajBmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPutanja;
        private System.Windows.Forms.Button btnEnkriptujBMP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDekriptujBitmapu;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}