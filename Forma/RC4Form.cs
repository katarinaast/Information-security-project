using Forma.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class RC4Form : Form
    {
        private Service1Client proxy;
        private string loadedFile;
        private string encryptedFile;
        private string decryptedFile;
        public RC4Form()
        {
            proxy = new Service1Client();
            InitializeComponent();
        }


        private void btnUcitajFajlRc4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";

            if (dialog.ShowDialog()==DialogResult.OK)
            {
                
                loadedFile=proxy.ReadFromFile(dialog.FileName);
                tbUcitanFajlRC4.Text = loadedFile;
            }
        }

        private void RC4Form_Load(object sender, EventArgs e)
        {

        }

        private void btnEncryptRC4_Click(object sender, EventArgs e)
        {
            if (tbKljucRc4.TextLength == 0)
            {
                MessageBox.Show("Unesite kljuc!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (loadedFile == null)
                {
                    MessageBox.Show("Ucitajte fajl!", "Error", MessageBoxButtons.OK);

                }
                else
                {
                    encryptedFile = proxy.EncryptDecryptRC4(loadedFile, tbKljucRc4.Text);
                    tbEnkriptovanFajlRc4.Text = encryptedFile;
                }
               
            }
            
        }

        private void btnDecryptRc4_Click(object sender, EventArgs e)
        {
            if (encryptedFile == null)
            {
                MessageBox.Show("Najpre enkriptujte fajl koji zelite!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                decryptedFile = proxy.EncryptDecryptRC4(encryptedFile, tbKljucRc4.Text);
                tbDekriptovanFajlRc4.Text = decryptedFile;
            }
            
        }

        private void btnSacuvajUFajlRc4_Click(object sender, EventArgs e)
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
    }
}
