namespace DZ_1_SimpleCode
{
    internal class Program
    {

        //Задание 1

        static double firstValue, secondValue;

        public static double Average(double a, double b)
        {
            Console.WriteLine("Введи первое число");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введи второе число");

            a = double.Parse(Console.ReadLine());

            double average = (a + b) / 2;

            return average;
        }

       
        static int[] values = new int[3];


        public static int[] Arr(int[] array)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введи " + (i + 1) + " число");
                var input = Console.ReadLine();

                bool result = int.TryParse(input, out int number);

                if (result)
                {
                    Console.WriteLine("Введённое число " + number + "\n");
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine("Введённое число не число, значит будет 5\n");
                    array[i] = 5;
                }
            }
            return array;
        }

       
        public static void SumMulty(int[] array)
        {
            Arr(array);

            int sum = 0;
            int mult = 1;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                mult *= array[i];
            }
            Console.WriteLine("Сумма значений равна " + sum + "\n\n");

            Console.WriteLine("Произведение значений равно " + mult + "\n\n");
        }


        public static void Converter()
        {
            Console.WriteLine("Введи количество валюты\n");

            var currencyValue = Console.ReadLine();

            var currencyAmount = double.Parse(currencyValue);

            double UsdToRUB = 95.87;
            double EuroToRUB = 101.33;

            Console.WriteLine(UsdToRUB + " долларов это " + (UsdToRUB * currencyAmount) + " рублей\n");
            Console.WriteLine(UsdToRUB + " евро это " + (EuroToRUB * currencyAmount) + " рублей\n");

        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\n");
            
            Console.WriteLine("Среднее арифметическое равно " + Average(firstValue, secondValue) + "\n\n");

            Console.WriteLine("Задание 2\n");

            //SumMulty(values);

            Console.WriteLine("Задание 3\n");

            

            Converter();

        }
    }
}
