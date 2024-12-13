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

        public static int factorial(int reqem)
        {
            if (reqem <= 1)
                return 1;
            return reqem * factorial(reqem - 1);

        }

        static void Main()
        {
            int eded = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(eded));
        }

    }
}
