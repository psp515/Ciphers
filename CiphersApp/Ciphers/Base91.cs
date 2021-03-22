
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base91 : CipherDescription
    {
        public string ShortDescription { get; set; } = " ";
        public string Name { get; set; } = "Base64";
        public int CipherNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Decode(string str)
        {
            throw new NotImplementedException();
        }
        public string Encode(string str)
        {
            throw new NotImplementedException();
        }  
    }
}
