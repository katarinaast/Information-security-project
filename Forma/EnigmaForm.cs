using Forma.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class EnigmaForm : Form
    {
        private Service1Client proxy;
        private string loadedFile;
        private string encryptedFile;
        private string decryptedFile;
        private string hashPath = "C:\\Users\\Kaca\\Desktop";
        private string fileName = "hash.bin";
        private uint checksum;
        public EnigmaForm()
        {
            proxy = new Service1Client();
            InitializeComponent();
        }

        private void EnigmaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitajFajlEnigma_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                loadedFile = proxy.ReadFromFile(dialog.FileName);
                tbUcitanFajlEnigma.Text = loadedFile;
                checksum = proxy.CalculateCRC(Encoding.ASCII.GetBytes(loadedFile), loadedFile.Length);


                string filePath = this.hashPath + "\\" + fileName;

                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {

                    writer.Write(checksum);
                }
            }
        }

        private void btnEnkriptujFajlEnigma_Click(object sender, EventArgs e)
        {
            if (tbKljucEnigma.TextLength == 0 || tbReflektorEnigma.TextLength==0 || tbPlugboardEnigma.TextLength==0)
            {
                MessageBox.Show("Unesite odgovarajuce parametre ili generisite podrazumevane!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (tbKljucEnigma.TextLength != 3 || tbReflektorEnigma.TextLength != 26 || tbPlugboardEnigma.TextLength != 26)
                {
                    MessageBox.Show("Kjuc treba da se sastoji od 3 velika slova, dok reflektor i plugboard treba da se sastoje od svih 26 velikih slova abecede, permutovanih po zelji!", "Error", MessageBoxButtons.OK);

                }
                else
                {
                    if (loadedFile == null)
                    {
                        MessageBox.Show("Ucitajte fajl!", "Error", MessageBoxButtons.OK);

                    }
                    else
                    {
                        string key = tbKljucEnigma.Text;
                        string reflector = tbReflektorEnigma.Text;
                        string plugboard = tbPlugboardEnigma.Text;

                        {
                            encryptedFile = proxy.EncryptDecryptEnigma(loadedFile, key, reflector, plugboard);
                            tbEnkriptovanFajlEnigma.Text = encryptedFile;
                        }
                    }
                    
                }
            } 
        }

        private void btnDekriptujFajlEnigma_Click(object sender, EventArgs e)
        {
            if (encryptedFile == null)
            {
                MessageBox.Show("Najpre enkriptujte fajl koji zelite!", "Error", MessageBoxButtons.OK);
            }
            else
            {

                string key = tbKljucEnigma.Text;
                string reflector = tbReflektorEnigma.Text;
                string plugboard = tbPlugboardEnigma.Text;


                {
                    decryptedFile = proxy.EncryptDecryptEnigma(encryptedFile, key, reflector, plugboard);
                    tbDekriptovanFajlEnigma.Text = decryptedFile;
                }

            }

        }

        private void btnSacuvajUFajlEnigma_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                proxy.WriteToFile(folderDialog.FileName, decryptedFile);
                string filePath = this.hashPath + "\\" + fileName;
                uint hash;

                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    hash = reader.ReadUInt32();
                }

                string writtenFile = proxy.ReadFromFile(folderDialog.FileName);
                uint checksum2 = proxy.CalculateCRC(Encoding.ASCII.GetBytes(writtenFile), writtenFile.Length);


                if (hash == checksum2)
                {
                    MessageBox.Show("Fajl je validan");
                }
                else
                {
                    MessageBox.Show("CheckSum se ne poklapa!");
                }
            }
        }

        private void tbKljucEnigma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDefaultEnigma_Click(object sender, EventArgs e)
        {
            tbKljucEnigma.Text = "ABC";
            tbReflektorEnigma.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            tbPlugboardEnigma.Text = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        }
    }
}
