using StackCollection2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    public class Stack
    {



        private class StackItem
        {
            //создаем первый элемент списка
            public StackNode Head; // Первый элемент списка

            private void Add(string str)
            {
                //создаю экземпляр элемента Стека
                StackNode newStackNode = new StackNode(str);
                if (Head == null)
                {
                    Head = newStackNode;
                }

            }


        }


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

        //метод добавления 
        public void Add(string str)
        {
            list.Add(str);
            Console.WriteLine($"В стек добавлен элемент: {str}");
        }
        //метод удаления
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


    //Вместо коллекции - создать класс StackItem, который

    //доступен только для класс Stack (отдельно объект класса StackItem вне Stack создать нельзя)

    //хранит текущее значение элемента стека
    //ссылку на предыдущий элемент в стеке
    //Методы, описанные в основном задании переделаны под работу со StackItem
}
