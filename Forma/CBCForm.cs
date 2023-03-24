using Forma.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class CBCForm : Form
    {
        private Service1Client proxy;
        private string loadedFile;
        private string encryptedFile;
        private string decryptedFile;
        public CBCForm()
        {
            proxy = new Service1Client();
            InitializeComponent();
        }

        private void CBCForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitajFajlCBC_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                loadedFile = proxy.ReadFromFile(dialog.FileName);
                tbUcitanFajlCBC.Text = loadedFile;
            }
        }

        private void btnEnkriptujCBC_Click(object sender, EventArgs e)
        {
            if (tbKljucCBC.TextLength == 16 && tbVektorCBC.TextLength == 16 && loadedFile!=null)
            {
                byte[] kljuc = Encoding.UTF8.GetBytes(tbKljucCBC.Text);
                byte[] vektor = Encoding.UTF8.GetBytes(tbVektorCBC.Text);
                byte[] podaci = Encoding.UTF8.GetBytes(loadedFile);
                byte[] res = proxy.EncryptCBC(podaci, kljuc, vektor);
                encryptedFile = Encoding.ASCII.GetString(res);
                tbEnkriptovanFajlCBC.Text = encryptedFile;
            }
            else if (tbVektorCBC.TextLength != 16)
            {
                MessageBox.Show("Vektor mora biti velicine 16B", "Error", MessageBoxButtons.OK);
            }
            else if(tbKljucCBC.TextLength!=16)
            {
                MessageBox.Show("Kljuc mora biti velicine 16B", "Error", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Ucitajte fajl!", "Error", MessageBoxButtons.OK);

            }
        }

        private void btnDekriptujCBC_Click(object sender, EventArgs e)
        {
            if (encryptedFile==null)
            {
                MessageBox.Show("Najpre enkriptujte fajl koji zelite!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                byte[] kljuc = Encoding.UTF8.GetBytes(tbKljucCBC.Text);
                byte[] vektor = Encoding.UTF8.GetBytes(tbVektorCBC.Text);
                byte[] podaci = Encoding.UTF8.GetBytes(encryptedFile);
                byte[] res = proxy.DecryptCBC(podaci, kljuc, vektor);
                decryptedFile = Encoding.ASCII.GetString(res);
                tbDekriptovanFajlCBC.Text = decryptedFile;
            }
            
        }

        private void btnSacuvajUFajlCBC_Click(object sender, EventArgs e)
        {
            if (decryptedFile == null)
            {
                MessageBox.Show("Najpre dekriptujte enkriptovani fajl, nakon toga je omoguceno cuvanje u fajl!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                SaveFileDialog folderDialog = new SaveFileDialog();
                folderDialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    proxy.WriteToFile(folderDialog.FileName, decryptedFile);
                }
            }
            
        }

        private void btnGenerisiVektorCBC_Click(object sender, EventArgs e)
        {
            try
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] randomNumbers = new byte[16];
                rng.GetNonZeroBytes(randomNumbers);
                string dif = Encoding.Default.GetString(randomNumbers);
                tbVektorCBC.Text = dif;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }
        }

        private void btnRandomKljucCBC_Click(object sender, EventArgs e)
        {
            try
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] randomNumbers = new byte[16];
                rng.GetNonZeroBytes(randomNumbers);
                string dif = Encoding.Default.GetString(randomNumbers);
                tbKljucCBC.Text = dif;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void btnUcitajBmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Bitmap Files (*.bmp) | *.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                pictureBox1.ImageLocation = dialog.FileName;
                pictureBox1.Refresh();
                tbPutanja.Text = dialog.FileName;
            }
        }

        private void btnEnkriptujBMP_Click(object sender, EventArgs e)
        {
            if (tbKljucCBC.TextLength == 16 && tbVektorCBC.TextLength == 16)
            {
                byte[] kljuc = Encoding.UTF8.GetBytes(tbKljucCBC.Text);
                byte[] vektor = Encoding.UTF8.GetBytes(tbVektorCBC.Text);
                byte[] bmpD = proxy.EncryptBMP(tbPutanja.Text, kljuc, vektor);
                using (MemoryStream stream = new MemoryStream(bmpD))
                {
                    Bitmap image = new Bitmap(stream);
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "Bitmap Files (*.bmp) | *.bmp";
                    dialog.ShowDialog();
                    if (dialog.FileName != "")
                    {
                        image.Save(dialog.FileName);
                        pictureBox2.ImageLocation = (dialog.FileName);
                        pictureBox2.Refresh();
                    }
                }
            }
            else if (tbVektorCBC.TextLength != 16)
            {
                MessageBox.Show("Vektor mora biti velicine 16B", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kljuc mora biti velicine 16B", "Error", MessageBoxButtons.OK);

            }
        }

        private void btnDekriptujBitmapu_Click(object sender, EventArgs e)
        {
            if (tbKljucCBC.TextLength == 16 && tbVektorCBC.TextLength == 16)
            {
                byte[] kljuc = Encoding.UTF8.GetBytes(tbKljucCBC.Text);
                byte[] vektor = Encoding.UTF8.GetBytes(tbVektorCBC.Text);
                byte[] bmpD = proxy.DecryptBMP(tbPutanja.Text, kljuc, vektor);

                using (MemoryStream stream = new MemoryStream(bmpD))
                {
                    Bitmap image = new Bitmap(stream);
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "Bitmap Files (*.bmp) | *.bmp";
                    dialog.ShowDialog();
                    if (dialog.FileName != "")
                    {
                        image.Save(dialog.FileName);
                        pictureBox3.ImageLocation = (dialog.FileName);
                        pictureBox3.Refresh();
                    }
                }
            }
            else if (tbVektorCBC.TextLength != 16)
            {
                MessageBox.Show("Vektor mora biti velicine 16B", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kljuc mora biti velicine 16B", "Error", MessageBoxButtons.OK);

            }
        }

        private void btnParalelizovano_Click(object sender, EventArgs e)
        {
            
        }
    }
}
