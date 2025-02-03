namespace DZ_4_5_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentValue;
            int limit;

            int evenResult = 0;
            int oddResult = 0;

            Random random = new Random();

            try
            {
                Console.WriteLine("Введите первое число диапазона");
                currentValue = int.Parse(Console.ReadLine());
                Console.WriteLine(currentValue + " первое введённое число");
            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное число, будет выбрано случайное");
                currentValue = random.Next(1, 100);
                Console.WriteLine(currentValue + " первое случайное число");
            }

            try
            {
                Console.WriteLine("Введите второе число диапазона");
                limit = int.Parse(Console.ReadLine());

                while (currentValue > limit)
                {
                    Console.WriteLine("Второе введённое число меньше первого, введите заново");
                    limit = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(limit + " второе введённое число");

            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное число, будет выбрано случайное");
                limit = random.Next(1, 100);

                while (currentValue > limit)
                {
                    Console.WriteLine("второе случайное число меньше первого, повторяем рандом");
                    limit = random.Next(1, 100);
                }
                Console.WriteLine(currentValue + " второе случайное число");
            }

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
