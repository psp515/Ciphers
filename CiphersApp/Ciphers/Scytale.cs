
using CiphersApp;
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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
        public override void Decode()
        {
            string a = Decode(HelperClass.GetString("Provide encoded message:"), HelperClass.GetInt("Enter the number of cilindersides:"));
            TextCopy.ClipboardService.SetText(a);
            Console.WriteLine("Your message: (encoded message is saved in clipboard) \n" + a);
        }

        public override void Encode()
        {
            string a = Encode(HelperClass.GetString("Provide message:"), HelperClass.GetInt("Set number of cilindersides:"));
            TextCopy.ClipboardService.SetText(a);
            Console.WriteLine("Your encoded message: (encoded message is saved in clipboard) \n" + a);
        }

        public string Decode(string ciphertext, int key)
        {
            return null;
        }
        public string Encode(string plaintext, int key)
        {
            return null;
        }
    }
}

