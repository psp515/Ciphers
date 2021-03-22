﻿
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Cesar : CipherDescription 
    {
        public string ShortDescription { get; set; } = " ";
        public string Name { get; set; } = "Base64";
        public int CipherNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Decode(string str)
        {
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                 tab[i] = DecodeChar(tab[i]);
           
            return new string(tab);
        }
        public string Encode(string str)
        {
            char[] tab = str.ToCharArray();
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