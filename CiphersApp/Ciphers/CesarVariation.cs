using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class CesarVariation : CipherDescription
    {
        public string ShortDescription { get; set; } = " ";
        public string Name { get; set; } = "Base64";
        public int CipherNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Decode(string str, int shift)
        {
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = DecodeChar(tab[i], shift);

            return new string(tab);
        }
        public string Encode(string str, int shift)
        {
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = EncodeChar(tab[i], shift);

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
