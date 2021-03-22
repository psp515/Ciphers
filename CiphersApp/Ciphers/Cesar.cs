using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Cesar : CipherClass , CipherStr
    {
        public override int Id { get; set; } = 3;
        public override string Name { get; set; } = "Cesar";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediHttps { get; set; } = "";

        public Cesar()
        {

        }

        public string Decode(string message)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                 tab[i] = DecodeChar(tab[i]);
           
            return new string(tab);
        }
        public string Encode(string message)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                  tab[i] = EncodeChar(tab[i]);
         
            return new string(tab);
        }
        public char EncodeChar(char a)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a + 3);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a + 3);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else
                return a;
        }
        public char DecodeChar(char a) 
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a - 3);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a - 3);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else
                return a;
        }
    }
}
