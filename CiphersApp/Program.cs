using System;

namespace CiphersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Starting();
        }

        private static void Starting()
        {
            Console.WriteLine("Welcome to Ciphers Repo!\nThis list of actual Ciphers:");
            Action PrintMenu = () =>Console.WriteLine("[1] - Cesar");
            int a=HelperClass.GetUserChoice(PrintMenu,3);
        }

    }
}
