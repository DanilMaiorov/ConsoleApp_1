namespace DZ_7_SimpleCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив с клавиатуры 
            int[] firstArray = new int[5];
            Console.WriteLine("Введите 5 чисел\n");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nПолучившийся массив\n");
            foreach (var item in firstArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();

            //Вывести массив в обратном порядке
            int[] reverseArray = new int[firstArray.Length];

            for (int i = reverseArray.Length; i > 0; i--)
            {
                reverseArray[reverseArray.Length - i] = firstArray[i - 1];
            }

            Console.WriteLine("\nРазвернутый массив\n");
            foreach (var item in reverseArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            //Найти сумму четных чисел в массиве
;
            SumArray(firstArray);

            //Сортировка пузырьком 

            BubbleSort(firstArray);

            //Заполнить массив с клавиатуры не зная сколько массив длиной
            int[] unknownArray = {};
            bool isNumber = true;

            while (isNumber)
            {
                Console.WriteLine();
                bool inputNumber = int.TryParse(Console.ReadLine(), out var result);
                if (inputNumber)
                {
                    int[] newArray = new int[unknownArray.Length + 1];
                    newArray[unknownArray.Length] = result;
                    for (int i = 0; i < unknownArray.Length; i++)
                    {
                        newArray[i] = unknownArray[i];
                    }
                    unknownArray = newArray;
                    Console.WriteLine("Итерации заполнения массива");
                    foreach (var item in unknownArray)
                        Console.Write($" {item} ");
                }
                else
                    isNumber = false;
            }

            Console.WriteLine("\nПо итогу получился такой массив\n");
            foreach (var item in unknownArray)
                Console.Write($" {item} ");

            BubbleSort(unknownArray);
            Console.WriteLine();
            SumArray(unknownArray);


            static void SumArray(int[] array)
            {
                int result = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                        result += array[i];
                }

                Console.WriteLine($"Сумма четных чисел {result}");
            }

            static void BubbleSort(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];

                            array[j] = array[j + 1];

                            array[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("\nОтсортировано пузырьком\n");
                foreach (var item in array)
                {
                    Console.Write($" {item} ");
                }
            }

            //int[] myArray = new int[1];

            //bool isNumber = true;

            //int counter = 0;

            //static int[] ArrayInsert(ref int[] array, ref int counter, bool isNum)
            //{
            //    if (isNum)
            //    {
            //        Console.WriteLine($"Элементы нового массива");
            //        foreach (var item in array)
            //            Console.Write($" {item} ");
            //        int[] myNewArray = new int[array.Length + 1];
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            myNewArray[i] = array[i];
            //        }
            //        array = myNewArray;
            //    }
            //    else
            //    {
            //        int[] totalArray = new int[array.Length - 1];
            //        for (int i = 0; i < array.Length - 1; i++)
            //        {
            //            totalArray[i] = array[i];
            //        }
            //        array = totalArray;
            //    }
            //    return array;
            //}
            //while (isNumber)
            //{
            //    Console.WriteLine();
            //    bool inputNumber = int.TryParse(Console.ReadLine(), out var result);

            //    if (inputNumber)
            //    {
            //        myArray[counter] = result;
            //        ArrayInsert(ref myArray, ref counter, inputNumber);
            //        counter++;
            //    }
            //    else
            //    {
            //        isNumber = false;
            //        ArrayInsert(ref myArray, ref counter, inputNumber);
            //    }
            //}
            //Console.WriteLine("По итогу получился такой массив\n");
            //foreach (var item in myArray)
            //    Console.Write($" {item} ");
        }
    }
}
