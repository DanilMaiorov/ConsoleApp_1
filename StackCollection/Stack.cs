using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    public class Stack
    {
        //хранилище строк
        private List<string> list = new List<string>();

        //свойство 
        public string LastListElement
        {
            get 
            { 
                if (list.Count > 0)
                    return list[list.Count - 1];
                
                return null;
            }
        }
            
        //свойство Size
        public int Size
        {
            get { return list.Count; }
        }

        //свойство Top
        public string Top
        {
            get 
            {
                return list.FindLast(res => LastListElement != null); 
            }
        }

        //метод добавления в конец Stack
        public void Add(string str)
        {
            list.Add(str);
            Console.WriteLine($"В стек добавлен элемент: {str}");
        }
        //метод удаления последнего эелемента Stack
        public string Pop()
        {
            //проверка на размер
            if (list.Count <= 0)
                throw new EmptyStackException();

            //присваивание значения последнего элемента
            string result = LastListElement;

            //удаление последнего элемента
            list.RemoveAt(list.Count - 1);

            //сообщение об удалённом элементе
            Console.WriteLine($"Из стека удален последний элемент: {result}. Количество элементов в стеке равно: {Size}");

            return result;
        }

        //статический метод Concat
        public static Stack Concat(params Stack[] args)
        {
            //объект для хранения и его же возвращаю
            Stack concatedStack = new Stack();

            //проверка на пустоту переданных Stack и не выполнение дальнейшего кода
            if (args.Length == 0)
                return concatedStack;

            //в переборе использую написанный экстеншн метод Merge с каждый item
            foreach (var item in args)
                concatedStack.Merge(item);
            
            return concatedStack;
        }

        //конструктор
        public Stack(params string[] args)
        {
            list.AddRange(args);
        }
    }
}


