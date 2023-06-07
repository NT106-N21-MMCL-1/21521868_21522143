using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        
        private string Encrypt(string input, int shift)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(((c - 'A') + shift) % 26 + 'A');
                    encryptedText.Append(encryptedChar);
                }
                else
                {
                    encryptedText.Append(c);
                }
            }

            return encryptedText.ToString();
        }

        private string Decrypt(int shift)
        {

            StringBuilder decryptedText = new StringBuilder();

            foreach (char c in txtEncrypt.Text)
            {
                if (char.IsLetter(c))
                {
                    char decryptedChar = (char)(((c - 'A') - shift + 26) % 26 + 'A');
                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    decryptedText.Append(c);
                }
            }
            return decryptedText.ToString();
        }
        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncrypt.Clear();
            try
            {
                string input = txtInput.Text.ToUpper();
                int shift = Convert.ToInt32(txtShift.Text);

                string encryptedText = Encrypt(input, shift);
                txtEncrypt.Text = encryptedText;
            }catch(Exception ex)
            {
                MessageBox.Show($"Unable to Encrypt data.\n Error : {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypt.Clear();
            try
            {
                string input = txtInput.Text.ToUpper();
                int shift = Convert.ToInt32(txtShift.Text);

                string decryptedText = Decrypt(shift);
                txtDecrypt.Text = decryptedText;
            }catch(Exception ex)
            {
                MessageBox.Show($"Unable to decrypt data.\n Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
