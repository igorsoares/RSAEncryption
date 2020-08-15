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
using System.Security.Cryptography;
using RSAEncrypt.ACTIONS;
namespace RSAEncrypt.FORMS
{
    public partial class MyKeys : Form
    {
        Gen_Rec mainGen;
        public MyKeys(Gen_Rec mainGen)
        {
            InitializeComponent();

            tbPublic.Text = mainGen.mainRSA.ToXmlString(false);
            tbPrivate.Text = mainGen.mainRSA.ToXmlString(true);
            this.mainGen = mainGen;
        }

        private void MyKeys_Load(object sender, EventArgs e)
        {
            labelLenght.Text = mainGen.mainRSA.KeySize.ToString();
        }
    }
}
