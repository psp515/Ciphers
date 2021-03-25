using CiphersApp.Ciphers;
using CiphersApp.Helpers;
using CiphersApp.Model;
using EncryptionApp.Ciphers.C_Classes;
using System;

namespace CiphersApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\t\t\t  Welcome to Ciphers Repo!\n\t\t\tThis list of actual Ciphers:");
            Starting();
        }

        private static void Starting()
        {
            CiphersLists cl = new CiphersLists();
            Action WriteMenu = () => HelperClass.WriteCipherList(cl.MenuModels);
            FindOption(HelperClass.GetUserChoice(WriteMenu, 0, 9));
        }

        private static void FindOption(int a)
        {
            switch (a)
            {
                case 0:
                    HelperClass.LeaveApp();
                    break;
                case 1:
                    Amc amc = new Amc(a);
                    break;
                case 2:
                    Base64 b = new Base64(a);
                    break; 
                case 3:
                    
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                default:
                    HelperClass.Error();
                    break;
                    
            }
        }
    }
}
