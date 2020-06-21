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

        private void Criptografar_Load(object sender, EventArgs e)
        {
            try
            {
                int lenght = main_gen.privateKey.Length;
                // se continuar, é pq tem chave

                labelStatus.Text = "Keys found.";
                labelStatus.ForeColor = Color.DarkGreen;
                

            }
            catch 
            {
                labelStatus.Text = "Gen keys first.";
                labelStatus.ForeColor = Color.DarkRed;
                btEncrypt.Enabled = false;
            }
            


        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
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
    }
}
