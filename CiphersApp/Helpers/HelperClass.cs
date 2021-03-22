using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp
{
    public class HelperClass
    {
        public static int Radomize(int minValue, int maxValue)
        {
            Random r = new Random();
            return r.Next(minValue, maxValue);
        }
        public static int GetUserChoice(Action printMenu, int choiceMax)
        {
            printMenu();
            Int32.TryParse(Console.ReadLine(), out int choice);
            if (choice < 1 || choice > choiceMax) 
            {
                Console.WriteLine("Wrong option. Please choose correct option.");
                GetUserChoice(printMenu, choiceMax);
            }
            return choice;
        }
        public void CipherChoiceMenuWrite(int cipherNumber,string name) => Console.WriteLine(string.Format("[{0}] - {1}", cipherNumber.ToString(), name));
    }
}
