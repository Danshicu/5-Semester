using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        private string imagePath;
        private byte[] key = new byte[32];
        private byte[] iv = new byte[16];
        public Form1()
        {
            InitializeComponent();
            CipherModeBox.DataSource = Enum.GetValues(typeof(CipherMode));
            InputPictureBox.AllowDrop = true;
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
                rng.GetBytes(iv);
            }
        }

        // private void CypherModeBox_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     throw new System.NotImplementedException();
        // }
        private void InputPictureBox_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptedPictureBox.Image = CryptoCipher.GetImage(CryptoCipher.MakeEncryption(imagePath, (CipherMode)CipherModeBox.SelectedItem, key, iv));
        }

        private void InputPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    InputPictureBox.Image = Image.FromFile(filenames[0]);
                    imagePath = filenames[0];
                }
            }
        }

        private void InputPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}