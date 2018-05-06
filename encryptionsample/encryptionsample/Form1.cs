using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace encryptionsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public String Encrypt(String data_to_encrypt)
        {
            //pattern of encryption
            //you can change this pattern
            String encryption_pattern = "your enc";

            byte[] passwordBytes = UTF8Encoding.UTF8.GetBytes(encryption_pattern);
            byte[] messageBytes = UTF8Encoding.UTF8.GetBytes(data_to_encrypt);

            // Set encryption settings -- Use password for both key and init. vector     
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Mode = CipherMode.ECB;
            provider.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and encrypt     
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read the encrypted message from the memory stream     
            byte[] encryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            // Encode the encrypted message as base64 string     
            String encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

            //encrypted data
            return encryptedMessage;

        }

        public String Decrypt(String encrypted_data)
        {

            encrypted_data = encrypted_data.Replace("\n", "");

            // decrypt
            // convert out of base 64
            byte[] messageBytes = Convert.FromBase64String(encrypted_data);

            //pattern of encryption
            //you can change this pattern
            //to decrypt your data, you need to use the same encryption pattern. 
            String encryption_pattern = "your enc";

            byte[] passwordBytes = UTF8Encoding.UTF8.GetBytes(encryption_pattern);

            // Set encryption settings -- Use password for both key and init. vector     
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Mode = CipherMode.ECB;
            provider.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            // Set up streams and decrypt    
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(messageBytes, 0, messageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Read the decrypted message from the memory stream    
            byte[] decryptedMessageBytes = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            // Decode the decrypted message 
            string decrypted_data = System.Text.UTF8Encoding.UTF8.GetString(decryptedMessageBytes);

            //return decrypted data
            return decrypted_data;

        }

        private void btnEncryptText_Click(object sender, EventArgs e)
        {
            //check if data is ready to be encrypted
            if (txtTextToBeEncrypted.Lines.Length > 0)
                txtEncryptedtext.Clear();

            //loop through every line in the richtext box and encrypts line by line
            for (int i = 0; i < txtTextToBeEncrypted.Lines.Length; i++)
            {
                //outputs encryption of each line to the bottom richtextbox. 
                txtEncryptedtext.Text = txtEncryptedtext.Text + Encrypt(txtTextToBeEncrypted.Lines[i]) + "\n";
            }
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {

            //check if data is ready to be encrypted
            if (txtEncryptedtext.Lines.Length > 0)
                txtTextToBeEncrypted.Clear();

            //loop through every line in the richtext box and encrypts line by line
            for (int i = 0; i < txtEncryptedtext.Lines.Length; i++)
            {
                //outputs encryption of each line to the top richtextbox. 
                txtTextToBeEncrypted.Text = txtTextToBeEncrypted.Text + Decrypt(txtEncryptedtext.Lines[i]) + "\n";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTextToBeEncrypted.Clear();
            txtEncryptedtext.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

