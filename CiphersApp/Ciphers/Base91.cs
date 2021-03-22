﻿
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base91 : CipherClass, CipherStr
    {
        public override int Id { get; set; } = 2;
        public override string Name { get; set; } = "Base91";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediHttps { get; set; } = "";

        public Base91()
        {

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
