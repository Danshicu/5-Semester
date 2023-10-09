using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Flush(object sender, EventArgs e)
        {
            OpenTextBox.Text = null;
            DecryptedTextBox.Text = null;
            EncryptedTextBox.Text = null;
            KeyTextBox.Text = null;
            FindKeyTextBox.Text = null;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptedTextBox.Text = SkytaleCrypt.Encrypt(OpenTextBox.Text, int.Parse(KeyTextBox.Text));
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            DecryptedTextBox.Text = SkytaleCrypt.Decrypt(EncryptedTextBox.Text, int.Parse(KeyTextBox.Text));
        }

        private void FindKeyButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 1000; i++)
            {
                FindKeyTextBox.Text += ($"{Environment.NewLine} Key {i} : {SkytaleCrypt.Decrypt(EncryptedTextBox.Text, i)}");
            }
        }
    }
}