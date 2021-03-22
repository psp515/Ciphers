
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base64 : CipherDescription
    {
        public string ShortDescription { get; set; } = " ";
        public string Name { get; set; } = "Base64";
        public int CipherNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Decode(string str) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(str));
        public string Encode(string str) => System.Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
    }
}
