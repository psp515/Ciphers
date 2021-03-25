using CiphersApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace CiphersApp
{
    public class HelperClass
    {
        public static int Radomize(int minValue, int maxValue)
        {
            Random r = new Random();
            return r.Next(minValue, maxValue);
        }
        public static int GetUserChoice(Action writeMenu,int choiceMin, int choiceMax)
        {
            writeMenu();
            int choice = GetIntChoice();

            if (choice<choiceMin||choice>choiceMax||choice==-1) 
            {
                Console.Clear();
                Console.WriteLine("Wrong option. Please choose correct option.");
                choice = GetUserChoice(writeMenu, choiceMin, choiceMax);
            }

            return choice;
        }
        public static int GetUserChoiceCipher(Action writeMenu, int choiceMin, int choiceMax)
        {
            //todo
            writeMenu();
            int choice = GetIntChoice();

            if (choice < choiceMin || choice > choiceMax || choice == -1)
            {
                Console.Clear();
                Console.WriteLine("Wrong option. Please choose correct option.");
                choice = GetUserChoice(writeMenu, choiceMin, choiceMax);
            }

            return choice;
        }
        private static int GetIntChoice()
        {
            string a = Console.ReadLine();
            if(Regex.IsMatch(a, @"^\d+$"))
            {
                return Int32.Parse(a);
            }
            return -1;
        }
        public static int GetInt(string text)
        {
            Console.WriteLine(text);
            //to do
            return 1;
        }
        public static string GetString(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public static void BreakText() =>Console.WriteLine("-----------------------------------------------------------------------------------");
        public static void WriteCipherList(List<CipherMenuModel> listCipherMenuModel)
        {
            BreakText();
            foreach (CipherMenuModel c in listCipherMenuModel)
                Console.WriteLine(string.Format("[{0}] - {1}", c.Id.ToString(), c.Name));  
            BreakText();
        }
        public static void WriteCipherOptions()
        {
            BreakText();
            Console.WriteLine("[0] - Go to main menu.\n[1] - Encode\n[2] - Decode");
            BreakText();
        }
        public static void WriteEndingOptions()
        {
            BreakText();
            Console.WriteLine("[0] - Quit app\n[1] - Continue with the same cipher\n[2] - Go to main menu");
            BreakText();
        }
        public static void Error() 
        {
            Console.Clear();
            Console.WriteLine("Sorry, something went wrong moving to main menu!");
            Thread.Sleep(1000);
            Console.Clear();
            Program.Main();
        }
        public static void LeaveApp()
        {
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("\t\t\tThanks for speding some time with my App!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\t\t\tHave a wonderfull day!");
            Thread.Sleep(1500);
            Environment.Exit(0);
        }

    }
}
