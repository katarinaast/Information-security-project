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
    public partial class TEAForm : Form
    {
        private Service1Client proxy;
        private string loadedFile;
        private string encryptedFile;
        private string decryptedFile;
        private string hashPath = "C:\\Users\\Kaca\\Desktop";
        private string fileName = "hash.bin";
        private uint checksum;
        public TEAForm()
        {
            proxy = new Service1Client();
            InitializeComponent();
        }

        private void TEAForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitajFajlTea_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                loadedFile = proxy.ReadFromFile(dialog.FileName);
                tbUcitanFajlTea.Text = loadedFile;
                
            }
        }

        private void btnEnkriptujFajlTea_Click(object sender, EventArgs e)
        {
            if (tbKljucTea.TextLength == 0)
            {
                MessageBox.Show("Unesite kljuc!", "Error", MessageBoxButtons.OK);
            }
            else if (tbKljucTea.TextLength > 16)
            {
                MessageBox.Show("Kljuc mora biti duzine 1-16!", "Error", MessageBoxButtons.OK);

            }
            else
            {
                if (loadedFile == null)
                {
                    MessageBox.Show("Ucitajte fajl!", "Error", MessageBoxButtons.OK);

                }
                else
                {
                    if (cbParallelTea.Checked)
                    {
                        int numThreads = Int32.Parse(tbBrojNitiTea.Text);
                        encryptedFile = proxy.EncryptTeaParallel(loadedFile, tbKljucTea.Text, numThreads);
                        tbEnkriptovanFajlTea.Text = encryptedFile;
                    }
                    else
                    {
                        encryptedFile = proxy.EncryptTea(loadedFile, tbKljucTea.Text);
                        tbEnkriptovanFajlTea.Text = encryptedFile;
                    }
                }
                
                
            }
          
        }

        private void btnDekriptujFajlTea_Click(object sender, EventArgs e)
        {
            if (encryptedFile == null)
            {
                MessageBox.Show("Najpre enkriptujte fajl koji zelite!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //if (cbParallelTea.Checked)
                //{
                //    int numThreads = Int32.Parse(tbBrojNitiTea.Text);
                //    decryptedFile = proxy.DecryptTeaParallel(encryptedFile, tbKljucTea.Text, numThreads);
                //    tbDekriptovanFajlTea.Text = decryptedFile;
                //}
                //else
                {
                    decryptedFile = proxy.DecryptTea(encryptedFile, tbKljucTea.Text);
                    tbDekriptovanFajlTea.Text = decryptedFile;
                }
                
            }
            
        }

        private void btnSacuvajUFajlTea_Click(object sender, EventArgs e)
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

        private void btnRandomKljucTEA_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 17);

            try
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] randomNumbers = new byte[number];
                rng.GetNonZeroBytes(randomNumbers);
                string dif = Encoding.Default.GetString(randomNumbers);
                tbKljucTea.Text = dif;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
}
