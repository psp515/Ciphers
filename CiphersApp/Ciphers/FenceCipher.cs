using CiphersApp.Ciphers;
using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class FenceCipher : CipherClass, CipherStrInt
    {
        public override int Id { get; set; } = 5;
        public override string Name { get; set; } = "FenceCipher";
        public override string ShortDescription { get; set; } = "Will be from wikipedia";
        public override string WikipediHttps { get; set; } = "";

        public FenceCipher()
        {

        }

        public string Encode(string message, int n)
        {
            
            string[] tab = new string[n];
            int counter = 1;
            int direction = 0;
            int rw = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char a = message[i];

                tab[rw] = string.Concat(tab[rw], a);
                if (rw == (n - 1) && direction == 0)
                {
                    direction = 1;
                    counter = -1;
                }
                else if ((rw == 0 && i != 0) && direction == 1)
                {
                    direction = 0;
                    counter = 1;
                }
                rw = rw + counter;
            }
            string odp = "";
            for (int i = 0; i < tab.Length; i++)
                odp = string.Concat(odp, tab[i]);

            return odp;
        }
        public string Decode(string message, int n)
        {
            
            char[] tab = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                tab[i] = ' ';
            }
            int row = 0;
            int direction = 1;
            for (int i = 0; i < n; i++)
            {
                direction = 1;
                for (int j = i; j < message.Length;)
                {
                    if (row >= message.Length)
                        break;
                    tab[j] = message[row];
                    if (i == 0 || i == n - 1)
                    {
                        j += (n - 1) * 2;
                    }
                    else if (direction == 1 && (i != 0 && i != n - 1))
                    {
                        direction = -1;
                        j += (n - 1 - i) * 2;
                    }
                    else if (direction == -1 && (i != 0 && i != n - 1))
                    {
                        direction = 1;
                        j += i * 2;
                    }
                    row++;
                }
                if (row >= message.Length)
                    break;
            }
            return new string(tab);
        }
    }
}
