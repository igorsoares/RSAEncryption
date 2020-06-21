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
using System.Xml;
using System.Xml.Serialization;


namespace RSAEncrypt.FORMS
{
    public partial class GenerateKey : Form
    {
        public Gen_Rec persistencia;
        RSACryptoServiceProvider mainRSA;
        public GenerateKey(Gen_Rec rcvGen)
        {
            InitializeComponent();
            persistencia = rcvGen;
            try
            {
                if (rcvGen.mainRSA.KeySize > 1)
                {
                    // significa que há chaves geradas ja
                    tbPublic.Text = rcvGen.mainRSA.ToXmlString(false);
                    tbPrivate.Text = rcvGen.mainRSA.ToXmlString(true);

                    btCopiar.Enabled = true;
                    btCopiarPrivada.Enabled = true;
                    btSalvarComoPub.Enabled = true;
                    btSalvarComoPriv.Enabled = true;
                }
            }
            catch
            {

            }
            finally
            {
                cbLenght.SelectedIndex = 0;
            }
            

            
        }

        public Gen_Rec ReturnGen()
        {
            return persistencia;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // OBJETO MAIS IMPORTANTE.
            mainRSA = new RSACryptoServiceProvider(Int32.Parse(cbLenght.SelectedItem.ToString()));
            persistencia = new Gen_Rec(mainRSA);
            tbPublic.Text = persistencia.publicKey;
            tbPrivate.Text = persistencia.privateKey;

            btCopiar.Enabled = true;
            btCopiarPrivada.Enabled = true;
            btSalvarComoPub.Enabled = true;
            btSalvarComoPriv.Enabled = true;
            
            
        }
    }
}
