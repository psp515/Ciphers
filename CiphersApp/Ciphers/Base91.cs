
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base91 : CipherClass, CipherStr
    {
        public override int Id { get; set; } = 3;
        public override string Name { get; set; } = "Base91 (work in progress)";
        public override string ShortDescription { get; set; } = "Base91, is a form of binary-to-text encoding scheme(same as Base64) developed by Joachim Henke.";
        public override string WikipediaHttps { get; set; } = "https://en.everybodywiki.com/BasE91";

        public Base91()
        {

        }
        public Base91(int a)
        {
            WriteInfo();
        }

        public string Decode(string message)
        {
            throw new NotImplementedException();
        }
        public string Encode(string message)
        {
            throw new NotImplementedException();
        }
    }
}
