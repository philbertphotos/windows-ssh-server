﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindowsSshServer.Algorithms
{
    internal class SshAes196Cbc : EncryptionAlgorithm
    {
        internal SshAes196Cbc()
            : base()
        {
            _algorithm = new AesCryptoServiceProvider();
            _algorithm.Mode = CipherMode.CBC;
            _algorithm.KeySize = 192;
        }

        public override string Name
        {
            get { return "aes196-cbc"; }
        }
    }
}
