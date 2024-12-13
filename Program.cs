using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace bunagir
{
    internal class Program

    {
        // Ededin tek ve ya cut olmasi
        //public static bool funksiya(int reqem)
        //{
        //    return reqem % 2 == 0;
        //}

        //static void Main()
        //{
        //    int eded=int.Parse(Console.ReadLine());

        //    if (funksiya(eded))
        //        {
        //        Console.WriteLine("cutdur");
        //    }
        //    else {
        //        Console.WriteLine("tekdir");
        //    }
        //}

        //factoriali tapan proqram
        //public static int factorial(int reqem)
        //{
        //    if (reqem <= 1)
        //        return 1;
        //    return reqem * factorial(reqem - 1);

        //}

        //static void Main()
        //{
        //    int eded = int.Parse(Console.ReadLine());

        //    Console.WriteLine(factorial(eded));
        //}

        // musbet menfi olmasin yoxlayan kod

        //public static string CheckNumberSign(int number)
        //{
        //    if (number < 0)
        //        return "Negative";
        //    else if (number > 0)
        //        return "Positive";
        //    else
        //        return "Zero";
        //}

        //static void Main()
        //{
        //    int input = int.Parse(Console.ReadLine());
        //    Console.WriteLine(CheckNumberSign(input));
        //}

        public static int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            string[] words = text.Split(new char[] { ' ', '\t', '\n', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void Main()
        {
            
            string text = Console.ReadLine();
            Console.WriteLine(CountWords(text));
        }
    }







}
}
