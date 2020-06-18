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
            this.Hide();
            MyKeys mK = new MyKeys(mainGen);
            mK.ShowDialog();
            this.Show();
        }
    }
}
