using System;
using System.Collections.Generic;
using System.Text;
using CiphersApp.Ciphers;
using CiphersApp.Interfaces;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class CesarVariation : CipherClass, CipherStrInt
    {
        public override int Id { get; set; } = 4;
        public override string Name { get; set; } = "CesarVariation";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediHttps { get; set; } = "";

        public CesarVariation()
        {

        }

        public string Decode(string message, int n)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = DecodeChar(tab[i], n);

            return new string(tab);
        }
        public string Encode(string message, int n)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = EncodeChar(tab[i], n);

            return new string(tab);
        }
        public char EncodeChar(char a, int n)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a + n);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a + n);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsDigit(a))
            {
                a = (char)(a + 5);
                if (a > '9')
                    return (char)(a - 10);
                else if (a < '0')
                    return (char)(a + 10);
                else
                    return a;
            }
            else
                return a;
        }
        public char DecodeChar(char a, int n)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a - n);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a - n);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsDigit(a))
            {
                a = (char)(a - 5);
                if (a > '9')
                    return (char)(a - 10);
                else if (a < '0')
                    return (char)(a + 10);
                else
                    return a;
            }
            else
                return a;
        }

    }
}
