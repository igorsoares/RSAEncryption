using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Security;
using System.Security.Cryptography;

namespace RSAEncrypt.ACTIONS
{
    public class Gen_Rec
    {
        public RSACryptoServiceProvider mainRSA;
        public string publicKey = null;
        public string privateKey = null;
        public Gen_Rec(RSACryptoServiceProvider tmpRSA)
        {
            mainRSA = tmpRSA;
            publicKey = mainRSA.ToXmlString(false);
            privateKey = mainRSA.ToXmlString(true);
        }
        
    }
}
