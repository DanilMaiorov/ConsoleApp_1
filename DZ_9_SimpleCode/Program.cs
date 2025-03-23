using System.Linq;

namespace DZ_9_SimpleCode
{

    class OperatorException : Exception { 
        public OperatorException() : base()
        {
        }
        public OperatorException(string message) : base(message)
        {
        }
    };
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base()
        {
        }
        public NegativeNumberException(string message) : base(message)
        {
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classes_OTUS.Asd();

            //Описание: Напишите консольное приложение на C#, которое реализует игру “Быки и коровы”. 
            //В этой игре компьютер загадывает четырехзначное число с уникальными цифрами, а игрок пытается его угадать.
            //После каждой попытки программа сообщает количество “быков” (цифры на правильных позициях) и “коров” 
            //(цифры, которые есть в числе, но на неправильных позициях).

            //Требования:

            //Программа должна генерировать случайное четырехзначное число с уникальными цифрами.
            //Пользователь должен вводить свои догадки через консоль.
            //После каждой попытки программа должна сообщать количество “быков” и “коров”.
            //Программа должна продолжать работу до тех пор, пока пользователь не угадает число.
            //После угадывания числа программа должна поздравить пользователя и вывести количество попыток.


            //int bulls = 0;
            //int cows = 0;

            //string NumberGenerator()
            //{
            //    Random random = new Random();

            //    string str = "";

            //    for (int i = 0; i < 4; i++)
            //    {
            //        int number = random.Next(0, 10);

            //        if (str.Contains(number.ToString()))
            //            i--;
            //        str += number;
            //    }
            //    return str;
            //}

            //string genString = NumberGenerator();
            //Console.WriteLine($"Сгенерированное число {genString}");

            //Console.WriteLine("Введите число из 4 цифр");
            //string userInput = Console.ReadLine();

            //void NumberCheck()
            //{
            //    for (int i = 0; i < userInput.Length; i++)
            //    {
            //        if (userInput[i] == genString[i])
            //            bulls++;

            //        else if (genString.Contains(userInput[i]))
            //            cows++;
            //    }

            //    Console.WriteLine($"Количество быков {bulls}");
            //    Console.WriteLine($"Количество коров {cows}");
            //}

            //var list1 = new List<int>() { 3, 5, 7, 8, 9, 10, 91 };

            //var list2 = new List<int>() { 3, 4, 12, 13, 56, 699, 6985 };

            //var list3 = new List<int>();

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    for (int j = 0; j < list2.Count; j++)
            //    {
            //        if (list1[i] >= list2[0])
            //        {
            //            list3.Add(list2[0]);
            //            list2.RemoveAt(0);
            //            j--;
            //        }
            //    }
            //    list3.Add(list1[i]);
            //}
            //if (list2.Count > 0)
            //{
            //    for (int i = 0; i < list2.Count; i++)
            //    {
            //        list3.Add(list2[i]);
            //    }
            //}

            //foreach (var item in list3)
            //{
            //    Console.WriteLine(item);
            //}

            //int maxValue = list1[0];
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    if (list1[i] > maxValue)
            //        maxValue = list1[i];
            //}



            //int[] Exercise_3(int[] array1, int[] array2)
            //{
            //    int lengthResultArray = array1.Length + array2.Length;
            //    int lengthArray1 = array1.Length;
            //    int lengthArray2 = array2.Length;
            //    int k = 0;
            //    int j = 0;
            //    int[] resultArray = new int[lengthResultArray];

            //    for (int i = 0; i < lengthResultArray; i++)
            //    {
            //        if (array1[j] >= array2[k])
            //        {
            //            resultArray[i] = array2[k];
            //            k++;
            //        }
            //        else
            //        {
            //            resultArray[i] = array1[j];
            //            j++;
            //        }
            //        if (k == lengthArray2)
            //        {
            //            for (int b = j; j < lengthArray1; j++, i++)
            //                resultArray[i] = array2[j];
            //            break;
            //        }
            //        else if (j == lengthArray2)
            //        {
            //            for (int b = k; k < lengthArray2; k++, i++)
            //                resultArray[i] = array1[k];
            //            break;
            //        }

            //    }
            //    return resultArray;
            //}





            //формат, оператор, переполнение, деление на 0, на неправильный знак

            int result = 0;
            

            int Sum(int a, int b) {
                return checked(a + b);
            };
            int Multi(int a, int b) {
                return checked(a * b);
            };
            int Divide(int a, int b) {
                return a / b;
            };
            int Substr(int a, int b) {
                return a - b;
            };

            Console.WriteLine("Первое значение");
            if (!int.TryParse(Console.ReadLine(), out int firstValue))
            {
                Console.WriteLine("Не верный ввод");
                return;
            }
            Console.WriteLine("Второе значение");
            if (!int.TryParse(Console.ReadLine(), out int secondValue))
            {
                Console.WriteLine("Не верный ввод");
                return;
            }

            Console.WriteLine("Оператор");
            if (!char.TryParse(Console.ReadLine(), out char operChar))
            {
                Console.WriteLine("Не верный ввод оператора");
                return;
            }

            checked
            {
                try
                {
                    if (firstValue <= 0 || secondValue <= 0)
                        throw new NegativeNumberException();

                    switch (operChar)
                    {
                        case '+':
                            result = Sum(firstValue, secondValue);
                            break;
                        case '-':
                            result = Substr(firstValue, secondValue);
                            break;
                        case '/':
                            result = Divide(firstValue, secondValue);
                            break;
                        case '*':
                            result = Multi(firstValue, secondValue);
                            break;
                        default:
                            throw new OperatorException();
                    }
                    Console.WriteLine("Результат " + result);
                }
         
                catch (OperatorException)
                {
                    Console.WriteLine("Не верный оператор");
                    return;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль");
                    return;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Слишком большое число результата");
                    return;
                }
                catch (NegativeNumberException)
                {
                    Console.WriteLine("Отрицательное число");
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Случилось что-то непонятное");
                    return;
                }
            }




        }
    }
}




