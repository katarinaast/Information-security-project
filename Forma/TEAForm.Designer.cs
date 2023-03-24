
namespace Forma
{
    partial class TEAForm
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
            this.tbKljucTea = new System.Windows.Forms.TextBox();
            this.btnUcitajFajlTea = new System.Windows.Forms.Button();
            this.tbUcitanFajlTea = new System.Windows.Forms.TextBox();
            this.tbEnkriptovanFajlTea = new System.Windows.Forms.TextBox();
            this.tbDekriptovanFajlTea = new System.Windows.Forms.TextBox();
            this.btnDekriptujFajlTea = new System.Windows.Forms.Button();
            this.btnEnkriptujFajlTea = new System.Windows.Forms.Button();
            this.btnSacuvajUFajlTea = new System.Windows.Forms.Button();
            this.btnRandomKljucTEA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParallelTea = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBrojNitiTea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite kljuc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izaberite fajl:";
            // 
            // tbKljucTea
            // 
            this.tbKljucTea.Location = new System.Drawing.Point(121, 31);
            this.tbKljucTea.Name = "tbKljucTea";
            this.tbKljucTea.Size = new System.Drawing.Size(100, 20);
            this.tbKljucTea.TabIndex = 2;
            // 
            // btnUcitajFajlTea
            // 
            this.btnUcitajFajlTea.Location = new System.Drawing.Point(121, 114);
            this.btnUcitajFajlTea.Name = "btnUcitajFajlTea";
            this.btnUcitajFajlTea.Size = new System.Drawing.Size(100, 23);
            this.btnUcitajFajlTea.TabIndex = 3;
            this.btnUcitajFajlTea.Text = "Ucitajte fajl";
            this.btnUcitajFajlTea.UseVisualStyleBackColor = true;
            this.btnUcitajFajlTea.Click += new System.EventHandler(this.btnUcitajFajlTea_Click);
            // 
            // tbUcitanFajlTea
            // 
            this.tbUcitanFajlTea.Location = new System.Drawing.Point(333, 31);
            this.tbUcitanFajlTea.Multiline = true;
            this.tbUcitanFajlTea.Name = "tbUcitanFajlTea";
            this.tbUcitanFajlTea.Size = new System.Drawing.Size(100, 208);
            this.tbUcitanFajlTea.TabIndex = 4;
            // 
            // tbEnkriptovanFajlTea
            // 
            this.tbEnkriptovanFajlTea.Location = new System.Drawing.Point(470, 31);
            this.tbEnkriptovanFajlTea.Multiline = true;
            this.tbEnkriptovanFajlTea.Name = "tbEnkriptovanFajlTea";
            this.tbEnkriptovanFajlTea.Size = new System.Drawing.Size(100, 208);
            this.tbEnkriptovanFajlTea.TabIndex = 5;
            // 
            // tbDekriptovanFajlTea
            // 
            this.tbDekriptovanFajlTea.Location = new System.Drawing.Point(613, 31);
            this.tbDekriptovanFajlTea.Multiline = true;
            this.tbDekriptovanFajlTea.Name = "tbDekriptovanFajlTea";
            this.tbDekriptovanFajlTea.Size = new System.Drawing.Size(100, 208);
            this.tbDekriptovanFajlTea.TabIndex = 6;
            // 
            // btnDekriptujFajlTea
            // 
            this.btnDekriptujFajlTea.Location = new System.Drawing.Point(470, 268);
            this.btnDekriptujFajlTea.Name = "btnDekriptujFajlTea";
            this.btnDekriptujFajlTea.Size = new System.Drawing.Size(100, 23);
            this.btnDekriptujFajlTea.TabIndex = 7;
            this.btnDekriptujFajlTea.Text = "Dekriptuj";
            this.btnDekriptujFajlTea.UseVisualStyleBackColor = true;
            this.btnDekriptujFajlTea.Click += new System.EventHandler(this.btnDekriptujFajlTea_Click);
            // 
            // btnEnkriptujFajlTea
            // 
            this.btnEnkriptujFajlTea.Location = new System.Drawing.Point(333, 268);
            this.btnEnkriptujFajlTea.Name = "btnEnkriptujFajlTea";
            this.btnEnkriptujFajlTea.Size = new System.Drawing.Size(100, 23);
            this.btnEnkriptujFajlTea.TabIndex = 8;
            this.btnEnkriptujFajlTea.Text = "Enkriptuj";
            this.btnEnkriptujFajlTea.UseVisualStyleBackColor = true;
            this.btnEnkriptujFajlTea.Click += new System.EventHandler(this.btnEnkriptujFajlTea_Click);
            // 
            // btnSacuvajUFajlTea
            // 
            this.btnSacuvajUFajlTea.Location = new System.Drawing.Point(613, 268);
            this.btnSacuvajUFajlTea.Name = "btnSacuvajUFajlTea";
            this.btnSacuvajUFajlTea.Size = new System.Drawing.Size(100, 23);
            this.btnSacuvajUFajlTea.TabIndex = 9;
            this.btnSacuvajUFajlTea.Text = "Sacuvaj u fajl";
            this.btnSacuvajUFajlTea.UseVisualStyleBackColor = true;
            this.btnSacuvajUFajlTea.Click += new System.EventHandler(this.btnSacuvajUFajlTea_Click);
            // 
            // btnRandomKljucTEA
            // 
            this.btnRandomKljucTEA.Location = new System.Drawing.Point(30, 67);
            this.btnRandomKljucTEA.Name = "btnRandomKljucTEA";
            this.btnRandomKljucTEA.Size = new System.Drawing.Size(191, 23);
            this.btnRandomKljucTEA.TabIndex = 10;
            this.btnRandomKljucTEA.Text = "Generisi random kljuc";
            this.btnRandomKljucTEA.UseVisualStyleBackColor = true;
            this.btnRandomKljucTEA.Click += new System.EventHandler(this.btnRandomKljucTEA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ucitan fajl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enkriptovan fajl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dekriptovan fajl:";
            // 
            // cbParallelTea
            // 
            this.cbParallelTea.AutoSize = true;
            this.cbParallelTea.Location = new System.Drawing.Point(30, 163);
            this.cbParallelTea.Name = "cbParallelTea";
            this.cbParallelTea.Size = new System.Drawing.Size(95, 17);
            this.cbParallelTea.TabIndex = 15;
            this.cbParallelTea.Text = "Paralelizovano";
            this.cbParallelTea.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Broj niti:";
            // 
            // tbBrojNitiTea
            // 
            this.tbBrojNitiTea.Location = new System.Drawing.Point(121, 195);
            this.tbBrojNitiTea.Name = "tbBrojNitiTea";
            this.tbBrojNitiTea.Size = new System.Drawing.Size(100, 20);
            this.tbBrojNitiTea.TabIndex = 17;
            // 
            // TEAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbBrojNitiTea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbParallelTea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRandomKljucTEA);
            this.Controls.Add(this.btnSacuvajUFajlTea);
            this.Controls.Add(this.btnEnkriptujFajlTea);
            this.Controls.Add(this.btnDekriptujFajlTea);
            this.Controls.Add(this.tbDekriptovanFajlTea);
            this.Controls.Add(this.tbEnkriptovanFajlTea);
            this.Controls.Add(this.tbUcitanFajlTea);
            this.Controls.Add(this.btnUcitajFajlTea);
            this.Controls.Add(this.tbKljucTea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TEAForm";
            this.Text = "TEAForm";
            this.Load += new System.EventHandler(this.TEAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKljucTea;
        private System.Windows.Forms.Button btnUcitajFajlTea;
        private System.Windows.Forms.TextBox tbUcitanFajlTea;
        private System.Windows.Forms.TextBox tbEnkriptovanFajlTea;
        private System.Windows.Forms.TextBox tbDekriptovanFajlTea;
        private System.Windows.Forms.Button btnDekriptujFajlTea;
        private System.Windows.Forms.Button btnEnkriptujFajlTea;
        private System.Windows.Forms.Button btnSacuvajUFajlTea;
        private System.Windows.Forms.Button btnRandomKljucTEA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbParallelTea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBrojNitiTea;
    }
}