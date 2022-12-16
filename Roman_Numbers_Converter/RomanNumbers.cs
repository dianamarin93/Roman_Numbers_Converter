using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numbers_Converter
{
    public class RomanNumbers
    {

        // I II III IV V VI VII VIII IX X 
        // L- 50 , C - 100, D - 500, M - 1000
        // The biggest roman number is 3999;

        // 2754 - MMDCCLIV

        public static string Convert(int number)
        {
            if (number > 0 && number < 4000)
            {
                int[] arr = SplitNumber(number);

                if (arr.Length == 4)
                {
                    return ConvertThousands(arr[0]) + ConvertHundreds(arr[1]) + ConvertTens(arr[2]) +
                           ConvertUnits(arr[3]);
                }
                if (arr.Length == 3)
                {
                    return ConvertHundreds(arr[0]) + ConvertTens(arr[1]) + ConvertUnits(arr[2]);
                }
                if (arr.Length == 2)
                {
                    return ConvertTens(arr[0]) + ConvertUnits(arr[1]);
                }

                return ConvertUnits(arr[0]);

            }

            return "Erorr! Number must be between 1 and 3999.";

        }

        private static string ConvertThousands(int number)
        {
            switch (number)
            {
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
                default:
                    return "";
            }

        }

        private static string ConvertHundreds(int number)
        {
            string[] arr = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

            return arr[number];

        }

        private static string ConvertTens(int number)
        {
            string[] value = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            return value[number];
        }

        private static string ConvertUnits(int number)
        {
            string[] arr = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return arr[number];

        }

        private static int[] SplitNumber(int number)
        {
            int[] arr = new int[number.ToString().Length];

            int index = number.ToString().Length - 1;

            while (number > 0)
            {
                arr[index] = number % 10;
                number /= 10;

                index--;
            }

            return arr;
        }

    }
}
