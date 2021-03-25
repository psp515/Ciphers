
using CiphersApp;
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base64 : CipherClass, CipherStr
    {
        public override int Id { get; set; } = 2;
        public override string Name { get; set; } = "Base64";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediHttps { get; set; } = "";

        public Base64()
        {
            //SetShort description
        }
        public Base64(int a)
        {
            WriteInfo();
        }
        public override void Decode() => Console.WriteLine(Decode(HelperClass.GetString("Podaj wiadomość do odkodowania:")));
        public override void Encode() => Console.WriteLine(Encode(HelperClass.GetString("Podaj wiadomość do zakodowania:")));
        
        public  string Decode(string message) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(message));
        public  string Encode(string message) => System.Convert.ToBase64String(Encoding.UTF8.GetBytes(message));

    }
}
