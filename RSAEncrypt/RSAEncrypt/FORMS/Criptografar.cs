using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSAEncrypt.ACTIONS;
namespace RSAEncrypt.FORMS
{
    public partial class Criptografar : Form
    {
        Gen_Rec main_gen;
        public Criptografar(Gen_Rec obj)
        {
            InitializeComponent();
            main_gen = obj;
        }

        private void Verifica_linguagem()
        {
            if(main_gen.defaultLanguage == "pt-br")
            {
                label2.Text = "Saída";
                btEncrypt.Text = "Criptografar";
                btCopy.Text = "Copiar saída";
                label3.Text = "Status:";
                

            }
        }

        private void Criptografar_Load(object sender, EventArgs e)
        {
            string lingua = main_gen.defaultLanguage;
            try
            {
                // Verifica a linguagem selecionada (pt-BR / eu_USA)
                Verifica_linguagem();

                int lenght = main_gen.publicKey.Length;
                // se continuar, é pq tem chave
                
                if(lingua == "pt-br")
                    labelStatus.Text = "Chaves OK.";
                else
                    labelStatus.Text = "Keys found.";
                labelStatus.ForeColor = Color.DarkGreen;
                

            }
            catch 
            {
                if(lingua == "pt-br")
                    labelStatus.Text = "Gere as chaves.";
                else
                    labelStatus.Text = "Gen keys first.";
                labelStatus.ForeColor = Color.DarkRed;
                btEncrypt.Enabled = false;
            }
            


        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            btCopy.Enabled = true;
            if(tbOriginal.Text.Length == 0)
            {
                labelStatus.Text = "Empty text";
                labelStatus.ForeColor = Color.DarkRed;
                tbOriginal.Focus();
                return;
            }
            byte[] encrypted=main_gen.mainRSA.Encrypt(Encoding.ASCII.GetBytes(tbOriginal.Text), false);
            tbOutput.Text = Convert.ToBase64String(encrypted);


        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbOutput.Text);
            labelStatus.Text = "Copied";
        }
    }
}
