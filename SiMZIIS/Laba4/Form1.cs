using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void GeneratePrimitiveButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(MainNumberBox.Text, out int res))
            {
                PrimitiveElementBox.Text = SecretGenerator.FindPrimitive(res).ToString();
            }
        }

        private void GenerateSecretButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PrimitiveElementBox.Text, out int primitive) &&
                int.TryParse(FirstKeyBox.Text, out int firstKey) && int.TryParse(SecondKeyBox.Text, out int secondKey))
            {
                SecretBox.Text =
                    SecretGenerator.GenerateSharedKey(int.Parse(MainNumberBox.Text), primitive, firstKey, secondKey).ToString();
            }
        }
        
    }
}