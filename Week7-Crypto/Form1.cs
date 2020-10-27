using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            string outputText = "";
            asciiTB.ResetText();
            for (int i = 0; i <= 127; i++)
            {
                outputText = String.Format("{0,-8}{1,8}{2,9:X2}{3,12}\r\n", i, (char)i, i, Convert.ToString(i, 2).PadLeft(8, '0'));
                asciiTB.AppendText(outputText);
            }
            //asciiTB.AppendText(outputText);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string encrypt = "";

            foreach (char c in rawTB.Text)
                encrypt += (char)(c + 1);// Note : encrypt must be declared as a string. 

            encryptedTB.Text = encrypt;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string decrypted = "";

            foreach (char c in encryptedTB.Text)
                decrypted += (char)(c - 1);// Note : encrypt must be declared as a string. 

            decryptedTB.Text = decrypted;
        }

        private void hashBtn_Click(object sender, EventArgs e)
        {
            SHA512Managed sha = new SHA512Managed();
            byte[] input = Encoding.UTF8.GetBytes(rawTB.Text);
            byte[] output = sha.ComputeHash(input);
            hashedTB.Text = Convert.ToBase64String(output);

            // generate random salt
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomSalt = new byte[32];
            rng.GetBytes(randomSalt);
            string salt = Convert.ToBase64String(randomSalt);

            // hash and salt raw input
            input = Encoding.UTF8.GetBytes(rawTB.Text + salt);
            output = sha.ComputeHash(input);
            hashedAndSaltedTB.Text = Convert.ToBase64String(output);
        }
    }
}
