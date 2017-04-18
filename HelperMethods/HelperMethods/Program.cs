using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            Console.Write("Result: ");
            DisplayResult(ReversedString(firstName),
            ReversedString(lastName),
            ReversedString(city));
            //DisplayResult(ReversedString(firstName) + " " + ReversedString(lastName) + " " + ReversedString(city));
            //DisplayResult(ReversedString(firstName));
            Console.ReadLine();

        }

        private static string ReversedString(string message)
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }

        private static void DisplayResult(string ReversedFirstName, string ReversedLastName, string ReversedCity)
        {
            Console.Write(ReversedFirstName + " ");
            Console.Write(ReversedLastName + " ");
            Console.Write(ReversedCity);
        }

        private static void DisplayResult(string Message)
        {
            Console.Write(Message);
        }
    }
}
