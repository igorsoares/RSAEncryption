using RSAEncrypt.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using RSAEncrypt.ACTIONS;
using System.Diagnostics;
using System.IO;

namespace RSAEncrypt
{
    public partial class MainMenu : Form
    {
        RSACryptoServiceProvider mainRSAObj = new RSACryptoServiceProvider();
        Gen_Rec mainGen = new Gen_Rec();
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define os padrões (ingles)
            mainGen.defaultLanguage = "eu-usa";
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            GenerateKey obj = new GenerateKey(mainGen);
            this.Hide();
            obj.ShowDialog();
            mainGen = obj.ReturnGen();
            this.Show();
        }

        private void btMyKeys_Click(object sender, EventArgs e)
        {
            try
            {
                //if (String.IsNullOrEmpty(mainGen.mainRSA.ToXmlString(true)))
                //    return;
                this.Hide();
                MyKeys mK = new MyKeys(mainGen);
                mK.ShowDialog();
                this.Show();
            }
            catch 
            {
                // Se cai aqui, quer dizer que não existem chaves.
                // Saia.
                return;
            }
            
        }
        private void lbGithub_MouseEnter(object sender, EventArgs e)
        {
            lbGithub.ForeColor = Color.Blue;
        }

        private void lbGithub_MouseLeave(object sender, EventArgs e)
        {
            lbGithub.ForeColor = Color.Black;
        }

        private void lbGithub_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://github.com/igorsoares");

        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            Criptografar obj_enc = new Criptografar(mainGen);
            this.Hide();
            obj_enc.ShowDialog();
            this.Show();


        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/igorscuculha/");

        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            labelInstagram.ForeColor = Color.Blue;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            labelInstagram.ForeColor = Color.Black;
        }



        private void btDecrypt_Click(object sender, EventArgs e)
        {
            Descriptografar frm = new Descriptografar(mainGen);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void portuguesBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainGen.defaultLanguage = "pt-br";
            btGenerate.Text = "Gerar";
            btMyKeys.Text = "Minhas chaves";
            btEncrypt.Text = "Encriptar";
            btDecrypt.Text = "Descriptografar";
            label1.Text = "RSA é uma criptografia assimétrica. Com par de chaves você pode criptografar e";
            label2.Text = "descriptografar seus dados.";
            label4.Text = "O par de chaves pode ser gerado com os seguintes tamanho de chave:";
            exitToolStripMenuItem.Text = "Opções";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificação para economizar processamento. (mesmo que mínimo)
            if (!String.IsNullOrEmpty(mainGen.defaultLanguage) && mainGen.defaultLanguage == "eu-usa")
                return;
            mainGen.defaultLanguage = "eu-usa";
            btGenerate.Text = "Generate";
            btMyKeys.Text = "Show my keys";
            btEncrypt.Text = "Encrypt";
            btDecrypt.Text = "Decrypt";
            label1.Text = "RSA it's an assymetric cryptography, with key pair you can encrypt and";
            label2.Text = "decrypt your data.";
            label4.Text = "The pair key can be generated with some lenghts:";

        }

        private void btImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select private key file";
                ofd.Filter = "Txt|*.txt|Doc|*.docx|All|*.*";
                ofd.ShowDialog();
                try
                {
                    string fullPath = ofd.FileName;
                    StreamReader readerObj = new StreamReader(File.Open(fullPath, FileMode.Open));
                    RSACryptoServiceProvider rsaTmp = new RSACryptoServiceProvider();

                    rsaTmp.FromXmlString(readerObj.ReadToEnd());

                    mainGen = new Gen_Rec(rsaTmp);

                    readerObj.Close();

                    //mainGen.mainRSA.FromXmlString(readerObj.ReadToEnd());
                    // Se nao ocorrer erros, imprima que a importação ocorreu com sucesso!
                    MessageBox.Show("Private key was imported successfully.","Warning");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error : "+exc.Message,"Error");
                    
                }
            }
        }

        private void btPublic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select public key file";
                ofd.Filter = "Txt|*.txt|Doc|*.docx|All|*.*";
                ofd.ShowDialog();
                try
                {
                    string fullPath = ofd.FileName;
                    StreamReader readerObj = new StreamReader(File.Open(fullPath, FileMode.Open));
                    RSACryptoServiceProvider rsaTmp = new RSACryptoServiceProvider();

                    rsaTmp.FromXmlString(readerObj.ReadToEnd());

                    mainGen = new Gen_Rec();
                    mainGen.importPublicKey(rsaTmp);

                    readerObj.Close();

                    //mainGen.mainRSA.FromXmlString(readerObj.ReadToEnd());
                    // Se nao ocorrer erros, imprima que a importação ocorreu com sucesso!
                    MessageBox.Show("Public key was imported successfully.", "Warning");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error : " + exc.Message, "Error");

                }
            }
        }
    }
}
