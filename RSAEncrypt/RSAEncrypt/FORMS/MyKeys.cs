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

            try
            {
                if (mainGen.mainRSA.ToXmlString(false).Length > 0)
                    tbPublic.Text = mainGen.mainRSA.ToXmlString(false);
            }
            catch
            {
                tbPublic.Text = "";
            }


            try
            {
                if (mainGen.mainRSA.ToXmlString(true).Length > 0)
                    tbPrivate.Text = mainGen.mainRSA.ToXmlString(true);

            }
            catch
            {
                tbPrivate.Text = "";
            }

            this.mainGen = mainGen;
        }

        private void MyKeys_Load(object sender, EventArgs e)
        {
            try
            {
                labelLenght.Text = mainGen.mainRSA.KeySize.ToString();
            }
            catch
            {
                labelLenght.Text = "";
            }
        }
    }
}
