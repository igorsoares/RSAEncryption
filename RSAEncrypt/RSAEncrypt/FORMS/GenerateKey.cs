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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RSAEncrypt.FORMS
{
    public partial class GenerateKey : Form
    {
        public Gen_Rec persistencia;
        public GenerateKey()
        {
            InitializeComponent();
            cbLenght.SelectedIndex = 0;
        }

        public void SerializaObjeto(Gen_Rec obj)
        {
        
                
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider myRsa = new RSACryptoServiceProvider(Int32.Parse(cbLenght.SelectedItem.ToString()));
            Gen_Rec obj = new Gen_Rec(myRsa);
            tbPublic.Text = obj.publicKey;
            tbPrivate.Text = obj.privateKey;
            persistencia = obj;
        }
    }
}
