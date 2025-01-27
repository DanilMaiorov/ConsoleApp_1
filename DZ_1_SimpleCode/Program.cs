namespace DZ_1_SimpleCode
{
    internal class Program
    {

        //Задание 1

        public static double Average(int a, int b)
        {
            double result = (double)(a + b) / 2;
            return result;
        }

       
        static int[] nums = new int[3];


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
            Console.WriteLine("Введи валюту\n");
            string currentCurrency = Console.ReadLine();

            Console.WriteLine("Выбрана валюта " + currentCurrency + "\n");
            Console.WriteLine("Введи количество валюты\n");

            var currencyValue = Console.ReadLine();

            bool result = double.TryParse(currencyValue, out double currencyAmount);

            double dollar = 55.5;
            double euro = 65.5;

            double sum = 0;

            if (currentCurrency == "доллар")
            {
                sum = dollar * currencyAmount;

                Console.WriteLine("Получается вот столько " + sum + " рублей из долларов");
            } else if (currentCurrency == "евро")
            {
                sum = euro * currencyAmount;

                Console.WriteLine("Получается вот столько " + sum + " рублей из евро");
            } else
            {
                Console.WriteLine("Это конвертируется");
            }

        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Среднее арифметическое равно " + Average(3, 6) + "\n\n");

            Console.WriteLine("Задание 2\n");

            //SumMulty(nums);

            Console.WriteLine("Задание 3\n");

            

            Converter();

        }
    }
}
