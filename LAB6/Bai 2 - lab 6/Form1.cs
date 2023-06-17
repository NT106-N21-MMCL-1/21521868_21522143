using System.Text;

namespace Bai_2___lab_6
{
    public partial class Form1 : Form
    {

        Dictionary<char, int> Key = new Dictionary<char, int>();
        public Form1()
        {
            InitializeComponent();

        }

        private string Encrypt(string plaintext, string key)
        {
            StringBuilder ciphertext = new StringBuilder();

            int keyIndex = 0;
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    int plainCharIndex = c - 'A';
                    int keyCharIndex = key[keyIndex % key.Length] - 'A';

                    int encryptedCharIndex = (plainCharIndex + keyCharIndex) % 26;

                    char encryptedChar = (char)('A' + encryptedCharIndex);
                    ciphertext.Append(encryptedChar);

                    keyIndex++;
                }
                else
                {
                    ciphertext.Append(c);
                }
            }

            return ciphertext.ToString();
        }

        private string Decrypt(string ciphertext, string key)
        {
            StringBuilder plaintext = new StringBuilder();

            int keyIndex = 0;
            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    int encryptedCharIndex = c - 'A';
                    int keyCharIndex = key[keyIndex % key.Length] - 'A';

                    int decryptedCharIndex = (encryptedCharIndex - keyCharIndex + 26) % 26;

                    char decryptedChar = (char)('A' + decryptedCharIndex);
                    plaintext.Append(decryptedChar);

                    keyIndex++;
                }
                else
                {
                    plaintext.Append(c);
                }
            }

            return plaintext.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encrypt(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Decrypt(textBox1.Text, textBox2.Text);
        }
    }
}