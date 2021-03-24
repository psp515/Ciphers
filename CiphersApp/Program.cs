using CiphersApp.Ciphers;
using CiphersApp.Helpers;
using CiphersApp.Model;
using System;

namespace CiphersApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\t\t\t  Welcome to Ciphers Repo!\n\t\t\tThis list of actual Ciphers:");
            HelperClass.BreakText();
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
                    Console.Clear();
                    HelperClass.LeaveApp();
                    break;
                case 1:
                    Console.Clear();
                    Amc amc = new Amc(a);
                    break;
                case 2:
                    Console.Clear();
                    
                    break;
                case 3:
                    Console.Clear();
                    
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    break;
                default:
                    HelperClass.Error();
                    break;
                    
            }
        }
    }
}
