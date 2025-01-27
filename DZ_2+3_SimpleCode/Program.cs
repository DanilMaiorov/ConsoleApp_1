namespace DZ_2_3_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДЗ_2\n");

            Console.WriteLine("Проверка числа на чётность, введи число\n");

            int userValue = int.Parse(Console.ReadLine());

            if (userValue % 2 == 0)
            {
                Console.WriteLine("Введено четное число " + userValue);
            } else
            {
                Console.WriteLine("Введено нечетное число " + userValue);
            }
        }
    }
}
