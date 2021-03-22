
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Scytale : CipherClass, CipherStrInt
    {
        public override int Id { get; set; } = 7;
        public override string Name { get; set; } = "Scytale";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediHttps { get; set; } = "";

        public Scytale()
        {

        }

        public string Decode(string message, int n)
        {
            throw new NotImplementedException();
        }
        public string Encode(string message, int n)
        {
            throw new NotImplementedException();
        }
    }
}
