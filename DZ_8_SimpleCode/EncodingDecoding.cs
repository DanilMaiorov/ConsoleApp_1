using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DZ_8_SimpleCode
{
    internal class EncodingDecoding
    {
        public static byte[] Enc(string str, Encoding Encoding)
        {
            if (str == null)
                str = "Строка не может быть null.";
            
            // Кодируем строку в массив байтов с использованием UTF-8

            byte[] encodedBytes = Encoding.GetBytes(str);

            Console.Write("Encoded bytes:");

            foreach (byte item in encodedBytes)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("\a");

            return encodedBytes;
        }

        public static string Dec(byte[] arr, Encoding Encoding)
        {
            // Декодируем массив байтов в строку

            string decodedBytes = Encoding.GetString(arr);

            Console.Write("Decoded bytes: ");

            Console.Write(decodedBytes);

            Console.WriteLine();
            return decodedBytes;
        }

        public static void WriteFile(string path, string str, string code, Encoding Encoding)
        {
            if (str == null)
                str = "Строка не может быть null.";
            switch (code)
            {
                case "utf-32":
                    File.WriteAllText(path, str, Encoding);
                    Console.WriteLine("Текст успешно записан в файл. Кодировка UTF-32");
                    Enc(str, Encoding.UTF32);
                    break;
                case "unicode":
                    File.WriteAllText(path, str, Encoding);
                    Console.WriteLine("Текст успешно записан в файл. Кодировка Unicode");
                    Enc(str, Encoding.Unicode);
                    break;
                case "ascii":
                    File.WriteAllText(path, str, Encoding);
                    Console.WriteLine("Текст успешно записан в файл. Кодировка ASCII");
                    Enc(str, Encoding.ASCII);
                    break;
                default:
                    File.WriteAllText(path, str, Encoding);
                    Console.WriteLine("Текст успешно записан в файл. Кодировка UTF-8");
                    Enc(str, Encoding.UTF32);
                    break;
            }
            Console.WriteLine("Текст успешно записан в файл.");
        }

        public static void ReadFile(string path)
        {
            string fileText = File.ReadAllText(path);

            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(fileText);
        }

        public static int ByteCounter(string str, Encoding Encoding)
        {
            int byteLength = Enc(str, Encoding).Length;
            Console.WriteLine($"Bytes amount: {byteLength}");
            return byteLength;
        }

        public static void ByteComparer(int firstBytes, int secondBytes)
        {
            if (firstBytes != secondBytes)
                Console.WriteLine($"Количество байт разное. UTF-8 - {firstBytes} байт. ASCII - {secondBytes} байт");
            else
                Console.WriteLine($"Количество байт одинаково и равно {secondBytes}");
        }

        public static string ToBase64Convert(string str, Encoding Encoding)
        {
            if (str == null)
                str = "Строка не может быть null.";

            byte[] bytesArr = Enc(str, Encoding);

            string base64Str = Convert.ToBase64String(bytesArr);

            Console.WriteLine("Base64 Encoded: " + base64Str);
            return base64Str;
        }

        public static string FromBase64Convert(string str, Encoding Encoding)
        {
            if (str == null)
                str = "Строка не может быть null.";

            byte[] bytesArr = Convert.FromBase64String(str);

            string fromBase64Str = Dec(bytesArr, Encoding);
  
            Console.WriteLine("Base64 Decoded: " + fromBase64Str);
            return fromBase64Str;
        }

        public static void ToHex(string str, Encoding Encoding)
        {
            if (str == null)
                str = "Строка не может быть null.";

            byte[] encodedBytes = Enc(str, Encoding);
            string hexCode = BitConverter.ToString(encodedBytes).Replace("-", " ");

            Console.Write("Hex-код: " + hexCode);
        }
        
    }
}
