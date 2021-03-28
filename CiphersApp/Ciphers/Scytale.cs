
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Scytale : CipherClass, CipherStrInt
    {
        public override int Id { get; set; } = 8;
        public override string Name { get; set; } = "Scytale (work in progress)";
        public override string ShortDescription { get; set; } = "In cryptography, a scytale is a tool used to perform a transposition cipher, consisting of a cylinder \nwith a strip of parchment wound around it on which is written a message. The ancient Greeks, \nand the Spartans in particular, are said to have used this cipher to communicate during military campaigns.";
        public override string WikipediaHttps { get; set; } = "https://en.wikipedia.org/wiki/Scytale";

        public Scytale()
        {

        }
        public Scytale(int a)
        {
            WriteInfo();
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
