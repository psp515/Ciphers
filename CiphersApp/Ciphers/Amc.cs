﻿using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp.Ciphers
{
    public class Amc : CipherClass, CipherStr
    {
        public override int Id { get; set; } = 1;
        public override string Name { get; set; } = "Ascii Multiplier";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        
        public Amc(){ }
        public Amc(int a)
        {
            WriteInfo();
        }

        public override void Decode()
        {
            string a = Decode(HelperClass.GetString("Podaj wiadomość do odkodowania:"));
            Console.WriteLine(a);
        }
        public override void Encode()
        {
            string a = HelperClass.GetString("Podaj wiadomość do odkodowania:");
             a   = Encode(a);
            Console.WriteLine(a);
        }
        public string Encode(string message)
        {
            Console.WriteLine("ENCO");
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = (char)(6 * tab[i]);
            return new string(tab);
        }

        public string Decode(string message)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = (char)(tab[i] / 6);
            return new string(tab);
        }
    }
}
