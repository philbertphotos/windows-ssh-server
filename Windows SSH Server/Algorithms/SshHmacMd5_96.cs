﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindowsSshServer.Algorithms
{
    internal class SshHmacMd5_96 : SshHmacMd5
    {
        internal SshHmacMd5_96()
            : base()
        {
        }

        public override string Name
        {
            get { return "hmac-md5-96"; }
        }

        public override byte[] ComputeHash(byte[] input)
        {
            var hash = base.ComputeHash(input);
            Array.Resize(ref hash, 12); // 12 bytes = 96 bits

            return hash;
        }
    }
}
