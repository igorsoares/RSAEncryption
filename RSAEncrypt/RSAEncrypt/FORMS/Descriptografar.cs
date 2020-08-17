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
using RSAEncrypt.ACTIONS;

namespace RSAEncrypt.FORMS
{
    public partial class Descriptografar : Form
    {
        Gen_Rec obj;
        public Descriptografar(Gen_Rec obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void Descriptografar_Load(object sender, EventArgs e)
        {
            Verifica_linguagem();
            string lingua = obj.defaultLanguage;
            try
            {
                int lenght = obj.publicKey.Length;
                
                // se continuar, é pq tem chave
                if (lingua == "pt-br")
                    labelStatus.Text = "Chaves OK.";
                else
                    labelStatus.Text = "Keys found.";
                labelStatus.ForeColor = Color.DarkGreen;

            }
            catch
            {
                if (lingua == "pt-br")
                    labelStatus.Text = "Gere as chaves.";
                else
                    labelStatus.Text = "Gen keys first.";
                labelStatus.ForeColor = Color.DarkRed;
                btDecrypt.Enabled = false;
            }

        }

        private void Verifica_linguagem()
        {
            if (obj.defaultLanguage == "pt-br")
            {
                label2.Text = "Saída";
                btDecrypt.Text = "Descriptografar";
                btCopy.Text = "Copiar saída";
                label3.Text = "Status:";


            }
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            
            btCopy.Enabled = true;
            if (tbEncrypted.Text.Length == 0)
            {
                labelStatus.Text = "Empty text";
                labelStatus.ForeColor = Color.DarkRed;
                tbEncrypted.Focus();
                return;
            }
            //RSACryptoServiceProvider RSA2 = new RSACryptoServiceProvider();
            //RSA2.FromXmlString(obj.privateKey);

            try
            {
                byte[] encrypted = Convert.FromBase64String(tbEncrypted.Text);
                byte[] decrypted = obj.mainRSA.Decrypt(encrypted, false);

                tbOutput.Text = Encoding.UTF8.GetString(decrypted);
            }
            catch
            {
                MessageBox.Show("Error. Verify your keys.");
            }
            
        }
    }
}
