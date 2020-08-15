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
                this.Hide();
                MyKeys mK = new MyKeys(mainGen);
                mK.ShowDialog();
                this.Show();
            }
            catch 
            {
                MessageBox.Show("Please create your keys first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Show();
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
            btGenerate.Text = "Gerar";
            btMyKeys.Text = "Minhas chaves";
            btEncrypt.Text = "Encriptar";
            btDecrypt.Text = "Descriptografar";
            label1.Text = "RSA é uma criptografia assimétrica. Com par de chaves você pode criptografar e";
            label2.Text = "descriptografar seus dados.";
            label4.Text = "O par de chaves pode ser gerado com os seguintes tamanho de chave:";
            exitToolStripMenuItem.Text = "Opções";
        }
    }
}
