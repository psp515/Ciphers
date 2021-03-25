using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp.Ciphers
{
    public abstract class CipherClass
    {
        public virtual int Id { get; set; } = 0;
        public virtual string Name { get; set; } = "No name";
        public virtual string ShortDescription { get; set; } = "No Description";
        public virtual string WikipediHttps { get; set; } = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
        public virtual void WriteInfo()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t"+Name+"\n");
            Console.WriteLine(ShortDescription);
            Console.WriteLine("\nMore info here: " + WikipediHttps);
            Console.WriteLine("\nAvaliable actions:");
            Action Menu = HelperClass.WriteCipherOptions;
            FindOption(HelperClass.GetUserChoice(Menu, 0, 2));
        }
        public virtual void Decode()
        {

        }
        public virtual void Encode()
        {

        }

        public virtual void FindOption(int a)
        {
           switch(a)
           {
                case 0:
                    BackToMainMenu();
                    break;
                case 1:
                    StartEncode();
                    break;
                case 2:
                    StartDecode();
                    break;
                default:
                    Console.Clear();
                    HelperClass.Error();
                    break;
           }
        }

        public virtual void BackToMainMenu()
        {
            Console.Clear();
            Program.Main();
        }

        private void StartDecode()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tDecoding message with " + Name);
            Decode();
            Ending();
        }

        
        private void StartEncode()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tEncoding message with " + Name);
            Encode();
            Ending();
        }

        
        private void Ending()
        {
            Action Menu = HelperClass.WriteEndingOptions;
            EndingFindOption(HelperClass.GetUserChoice(Menu,0,2));
        }

        private void EndingFindOption(int a)
        {
            switch (a)
            {
                case 0:
                    HelperClass.LeaveApp();
                    break;
                case 1:
                    WriteInfo();
                    break;
                case 2:
                    BackToMainMenu();
                    break;
                default:
                    HelperClass.Error();
                    break;
            }
        }

        
    }
}
