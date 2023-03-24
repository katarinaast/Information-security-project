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
    public partial class Form1 : Form
    {
        private Service1Client proxy;
        public Form1()
        {
            proxy = new Service1Client();
            InitializeComponent();
        }

        private void btnrc4_Click(object sender, EventArgs e)
        {
            RC4Form rc4 = new RC4Form();
            rc4.Show();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            TEAForm tea = new TEAForm();
            tea.Show();
        }

        private void btnEnigma_Click(object sender, EventArgs e)
        {
            EnigmaForm enigma = new EnigmaForm();
            enigma.Show();
        }

        private void btnCBC_Click(object sender, EventArgs e)
        {
            CBCForm cbc = new CBCForm();
            cbc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
