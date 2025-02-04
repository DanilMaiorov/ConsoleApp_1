using System;
using System.Data.SqlTypes;

namespace DZ_4_5_SimpleCode
{
    internal class Program
    {

        static bool isNumber = false;

        static int tryCounter = 5;  

        static int currentValue;

        static int limit;

        static bool inputNumber(ref bool itIsNumber, string str, ref int value, ref int counter)
        {
            string inputNumber = Console.ReadLine();
            bool success = int.TryParse(inputNumber, out int result); 

            if (success)
            {
                value = result;
                itIsNumber = false;
                Console.WriteLine($"{value} - {str} число");
                counter = 5;
            }
            else
            {
                itIsNumber = true;
                counter--;
                Console.WriteLine($"Осталось попыток на ввод числа: {tryCounter} ");

                if (counter == 0)
                {
                    Console.WriteLine($"Попытки кончились, выбирается случайное число");
                    itIsNumber = false;
                    Random random = new Random();
                    value = random.Next(1, 100);
                    Console.WriteLine($"{value} - {str} случайное число"); 
                    counter = 5;
                }
            }
            return itIsNumber;
        }

        static void Main(string[] args)
        {

            int evenResult = 0;
            int oddResult = 0;

            Console.WriteLine($"Всего {tryCounter} попыток на ввод первого числа. Если попытки кончатся, то число будет выбрано случайно");
            while (inputNumber(ref isNumber, "первое", ref currentValue, ref tryCounter));

            Console.WriteLine($"Всего {tryCounter} попыток на ввод второго числа. Если попытки кончатся, то число будет выбрано случайно");
            while (inputNumber(ref isNumber, "второе", ref limit, ref tryCounter));

            if (currentValue > limit)
            {
                Console.WriteLine("Начальное число больше конечного, придётся поменять местами числа");
                Console.WriteLine(currentValue + " изначально первое число диапазона");
                Console.WriteLine(limit + " изначально второе число диапазона");
                int temp = currentValue;
                currentValue = limit;
                limit = temp;
            }

            Console.WriteLine(currentValue + " итоговое первое число диапазона");

            Console.WriteLine(limit + " итоговое второе число диапазона");

            while (limit >= currentValue)
            {
                if (currentValue % 2 == 0)
                    evenResult += currentValue;
                else
                    oddResult += currentValue;

                currentValue++;
            }

            Console.WriteLine($"\n{evenResult} это итоговый evenResult\n");
            Console.WriteLine($"{oddResult} это итоговый evenResult\n");
        }
    }
}
