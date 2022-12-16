using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numbers_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2754 - MMDCCLIV
            Console.WriteLine(RomanNumbers.Convert(2754));
            Console.WriteLine(RomanNumbers.Convert(754));
            Console.WriteLine(RomanNumbers.Convert(54));
            Console.WriteLine(RomanNumbers.Convert(4));
            Console.WriteLine(RomanNumbers.Convert(5700));
            Console.WriteLine(RomanNumbers.Convert(-3));
            Console.ReadKey();
        }

    }
}
