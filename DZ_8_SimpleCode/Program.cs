using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

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
            //Console.WriteLine(unboxed_1);

            //Проверка типа перед распаковкой

            int boxingNumber_2 = 42;
            object obj_2 = boxingNumber_2;

            if (obj_2 is double)
            {
                //Console.WriteLine("Распаковываем число");
                double unboxed_2 = (double)obj_2;
                //Console.WriteLine(unboxed_2);
            }
            else
            {
                //Console.WriteLine("Распаковка в double не удалась");
            }

            //Упаковка и распаковка с nullable - типом

            int? boxingNumber_3 = 23;
            object obj_3 = boxingNumber_3;

            int? unboxed_3 = (int?)obj_3;

            if (unboxed_3.HasValue)
            {
                //Console.WriteLine("Распаковыванный Nullable int имеет значение");
                //Console.WriteLine(unboxed_3.Value);
            }
            else
            {
                //Console.WriteLine("Распаковыванный Nullable int = null");
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

            //Console.WriteLine("Сумма ArrayList");
            //Console.WriteLine(result);


            //Упаковка и распаковка в коллекции - 2

            ArrayList boxing_5 = new ArrayList();

            int result_5 = 0;

            for (int i = 1; i <= 10; i++)
            {
                boxing_5.Add(i);
            }

            foreach (object item in boxing_5)
            {
                //Console.WriteLine($"Распакованные числа - {(int)item}");
                result += (int)item;
            }

            //Console.WriteLine($"Сумма распакованных чисел - {result}");

            //Упаковка и распаковка с nullable - типами - 2

            Random rand = new Random();
            

            int?[] nullableArr = new int?[rand.Next(1, 30)];

            for (int i = 0; i < nullableArr.Length; i++)
            {
                if (i % 4 == 0)
                { 
                    int? nullableInt = null;
                    nullableArr[i] = nullableInt;
                } 
                else
                {
                    nullableArr[i] = i;
                }
            }

            object[] objectArr = new object[nullableArr.Length];

            for (int i = 1; i < objectArr.Length; i++)
            {
                objectArr[i] = nullableArr[i];
            }

            //Console.WriteLine("nulleable uboxing\n");

            for (int i = 0; i < objectArr.Length; i++)
            {
                int? unboxedInt = (int?)objectArr[i];

                if (objectArr[i] == null)
                {
                    unboxedInt = 0;
                }
                //Console.WriteLine(unboxedInt);
            }


            //Задача 1: Кодирование и декодирование строки в UTF-8

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            byte[] textBytes = EncodingDecoding.Enc(text, Encoding.UTF8);

            string decodedStr = EncodingDecoding.Dec(textBytes, Encoding.UTF8);

            //Задача 2: Запись и чтение текста в файл с разными кодировками

            EncodingDecoding.WriteFile("output.txt", "Привет как дела %:?", "utf-32", Encoding.UTF32);
            EncodingDecoding.ReadFile("output.txt");

            EncodingDecoding.WriteFile("output.txt", "Привет как дела %:?", "utf-8", Encoding.UTF8);
            EncodingDecoding.ReadFile("output.txt");

            EncodingDecoding.WriteFile("output.txt", "Привет как дела %:?", "unicode", Encoding.Unicode);
            EncodingDecoding.ReadFile("output.txt");

            EncodingDecoding.WriteFile("output.txt", "PRIVET KAK dela %:?", "ascii", Encoding.ASCII);
            EncodingDecoding.ReadFile("output.txt");

            //Задача 3: Проверка различий в кодировках

            string exapmleText = "Пт !=";
            Console.WriteLine(exapmleText);
            int utfBBytes = EncodingDecoding.ByteCounter(exapmleText, Encoding.UTF8);

            int asciiBBytes = EncodingDecoding.ByteCounter(exapmleText, Encoding.ASCII);

            EncodingDecoding.ByteComparer(utfBBytes, asciiBBytes);

            //Задача 4: Base64 кодирование и декодирование

            string toBase64 = "Hello, фыв C#";

            string toBase64Str = EncodingDecoding.ToBase64Convert(toBase64, Encoding.UTF8);

            string fromBase64Str = EncodingDecoding.FromBase64Convert(toBase64Str, Encoding.UTF8);

            //Задача 5: Кодировка строки в шестнадцатеричный вид(Hex)

            string toHex = Console.ReadLine();

            EncodingDecoding.ToHex(toHex, Encoding.UTF8);
        }
    }
}
