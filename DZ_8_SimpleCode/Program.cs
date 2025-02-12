using System;
using System.Collections;
using System.Collections.Generic;

namespace DZ_8_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упаковка и распаковка числа

            int boxingNumber_1 = 42;
            object obj_1 = boxingNumber_1;
            int unboxed_1 = (int)obj_1;
            Console.WriteLine(unboxed_1);

            //Проверка типа перед распаковкой

            int boxingNumber_2 = 42;
            object obj_2 = boxingNumber_2;

            if (obj_2 is double)
            {
                Console.WriteLine("Распаковываем число");
                double unboxed_2 = (double)obj_2;
                Console.WriteLine(unboxed_2);
            }
            else
            {
                Console.WriteLine("Распаковка в double не удалась");
            }

            //Упаковка и распаковка с nullable - типом

            int? boxingNumber_3 = 23;
            object obj_3 = boxingNumber_3;

            int? unboxed_3 = (int?)obj_3;

            if (unboxed_3.HasValue)
            {
                Console.WriteLine("Распаковыванный Nullable int имеет значение");
                Console.WriteLine(unboxed_3.Value);
            }
            else
            {
                Console.WriteLine("Распаковыванный Nullable int = null");
            }

            //Упаковка и распаковка в коллекции

            ArrayList boxing_4 = new ArrayList();
            boxing_4.Add(10);
            boxing_4.Add(20);
            boxing_4.Add(30);

            int result = 0;
            for (int i = 0; i < boxing_4.Count; i++)
            {
                result += (int)boxing_4[i];
            }

            Console.WriteLine("Сумма ArrayList");
            Console.WriteLine(result);
        }
    }
}
