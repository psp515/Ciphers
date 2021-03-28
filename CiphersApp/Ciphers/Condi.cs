using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Condi : CipherClass, CipherStrStrInt
    {
        public override int Id { get; set; } = 6;
        public override string Name { get; set; } = "Condi Cipher (work in progress)";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediaHttps { get; set; } = "https://sites.google.com/site/bionspot/condi-ciphers";

        public Condi()
        {

        }
        public Condi(int a)
        {
            WriteInfo();
        }
        public string Encode(string message, string k, int n)
        {
            throw new NotImplementedException();
        }
        public string Decode(string message, string k, int n)
        {
            throw new NotImplementedException();
        }
    }
}
