using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if i need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";
            //string myString = string.Format("{0} = {1}", "First","Second");
            //string myString = string.Format("{0:C}",123.45);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .1230);
            //string myString = string.Format("Phone Number: {0:(##) #####-####}", 11964507012); //os digitos são alinhados da diretia para esquerda(Cuidado CAGADA)

            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = string.Format("Lenght before: {0} -- Lenght after: {1}",
                myString.Length, 
                myString.Trim().Length);
            */

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
