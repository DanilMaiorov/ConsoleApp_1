namespace DZ_6_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Рисование треугольников

            Console.WriteLine("Введи высоту треугольника");
            int triangleHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 0; i < triangleHeight; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            for (int i = 0; i < triangleHeight; i++)
            {
                for (int j = triangleHeight; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            for (int i = 0; i < triangleHeight; i++)
            {
                for (int j = triangleHeight - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int i = 0; i < triangleHeight; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = triangleHeight; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            //Таблица умножения

            Console.WriteLine("Таблица умножения от 0 до 9:");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine("");
            }

            //Простые числа от 2 от 100

            for (int i = 2; i < 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{i} простое число");
                }
            }

            //Вывод чисел в виде таблицы от 1 до 25

            int counter = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = counter; j < counter + 5; j++)
                {
                    Console.Write($" {j} ");
                }
                counter = counter + 5;
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int number = (i - 1) * 5 + j;
                    Console.Write($" {number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
