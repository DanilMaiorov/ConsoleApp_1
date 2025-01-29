namespace DZ_2_3_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ДЗ_2\n");

            //Console.WriteLine("Проверка числа на чётность, введи число\n");

            //int userValue = int.Parse(Console.ReadLine());

            //if (userValue % 2 == 0)
            //{
            //    Console.WriteLine("Введено четное число " + userValue);
            //} else
            //{
            //    Console.WriteLine("Введено нечетное число " + userValue);
            //}

            Console.WriteLine("ДЗ_3\n");

            bool finish = true;

            bool CalculatorSwitchCase()
            {
                Console.Clear();
                Console.WriteLine("Введи первое число");
                double firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введи второе число");
                double secondValue = double.Parse(Console.ReadLine());

                double result;
                Console.WriteLine("А теперь математическую операцию: '+', '-', '*', '/'");

                ConsoleKey key = Console.ReadKey().Key;

                switch (key) {
                    case ConsoleKey.Subtract:
                        Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их вычитания равен");
                        result = firstValue - secondValue;
                        Console.WriteLine(result);
                        break;
                    case ConsoleKey.Add:
                        Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их сложения равен");
                        result = firstValue + secondValue;
                        Console.WriteLine(result);
                        break;
                    case ConsoleKey.Multiply:
                        Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их умножения равен");
                        result = firstValue * secondValue;
                        Console.WriteLine(result);
                        break;
                    case ConsoleKey.Divide:
                        Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их деления равен");
                        if (secondValue == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        } else
                        {
                            result = firstValue / secondValue;
                            Console.WriteLine(result);
                        }
                        break;
                    default:
                        Console.WriteLine("Введена не ок операция");
                        Console.WriteLine("Хотите считать ещё?");
                        ConsoleKey newKey = Console.ReadKey().Key;
                        switch (newKey)
                        {
                            case ConsoleKey.Escape:
                                Console.WriteLine("Пока");
                                finish = false;
                                break;
                            default:
                                finish = true;
                                break;
                        }
                        break;
                        
                }
                Console.WriteLine("Хотите считать ещё?");
                ConsoleKey newKey_1 = Console.ReadKey().Key;
                switch (newKey_1)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("Пока");
                        finish = false;
                        break;
                    default:
                        finish = true;
                        break;
                }

                return finish;
            }

            //while (CalculatorSwitchCase()) ;

            bool CalculatorIfElse()
            {
                Console.Clear();
                Console.WriteLine("Введи первое число");
                double firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введи второе число");
                double secondValue = double.Parse(Console.ReadLine());

                double result;
                Console.WriteLine("А теперь математическую операцию: '+', '-', '*', '/'");

                ConsoleKey key = Console.ReadKey().Key;
                
                if (key == ConsoleKey.Subtract)
                {
                    Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их вычитания равен");
                    result = firstValue - secondValue;
                    Console.WriteLine(result);
                    finish = true;
                } 
                else if (key == ConsoleKey.Add)
                {
                    Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их сложения равен");
                    result = firstValue + secondValue;
                    Console.WriteLine(result);
                    finish = true;
                } 
                else if (key == ConsoleKey.Multiply)
                {
                    Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их умножения равен");
                    result = firstValue * secondValue;
                    Console.WriteLine(result);
                    finish = true;
                } 
                else if (key == ConsoleKey.Divide)
                {
                    Console.WriteLine($"Введены значения {firstValue} и {secondValue} и результат их деления равен");

                    if (secondValue == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        finish = true;
                    }
                    else
                    {
                        result = firstValue / secondValue;
                        Console.WriteLine(result);
                        finish = true;
                    }
                } 
                else
                {
                    Console.WriteLine("Введена не ок операция");
                    Console.WriteLine("Хотите считать ещё?");
                    ConsoleKey newKey = Console.ReadKey().Key;
                    if(newKey != ConsoleKey.Escape)
                    {
                        finish = true;
                    } 
                    else
                    {
                        Console.WriteLine("Пока");
                        finish = false;
                    }
                }
                Console.WriteLine("Хотите считать ещё?");
                ConsoleKey newKey_2 = Console.ReadKey().Key;
                if (newKey_2 != ConsoleKey.Escape)
                {
                    finish = true;
                }
                else
                {
                    Console.WriteLine("Пока");
                    finish = false;
                }
                return finish;
            }
            while (CalculatorIfElse()) ;

        }
    }
}
