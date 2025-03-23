using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    internal static class Extensions
    {
        public static decimal ValidateAndParse(this string? str ) {
            while (true)
            {
                if (string.IsNullOrEmpty(str))
                    throw new ArgumentNullException("\"Введено ничего\"");

                bool isInt = decimal.TryParse(str, out decimal value);

                if (value < 0)
                    throw new ArgumentNullException("\"Введено отрицательное число\"");

                return value;
            }
        }

        public static int ValidateAndParseInt(this string? str)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(str))
                    throw new ArgumentNullException("\"Введено ничего\"");

                bool isInt = int.TryParse(str, out int value);

                if (value < 0)
                    throw new ArgumentNullException("\"Введено отрицательное число\"");

                return value;
            }
        }
    }
}
