using System.Net.NetworkInformation;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Animal[] animals = new Animal[] 
            {
                new Duck(), 
                new Cat()
            };
        }
    }
}


//Абстракция.
//1.Описать абстрактный класс Animal
//1.1 Добавить поле name
//1.2 Добавить неабстрактный метод GetName()
//1.3 Добавить абстрактный метод MakeSound()

//2. Описать интерфейсы 
//2.1 Описать интерфейс IFlying
//2.1.1 Добавить метод Fly(лететь)
//2.2	Описать интерфейс IWalking
//2.2.1 Добавить метод Walk(ходить)
//2.3 Описать интерфейс ISwiming
//2.3.1 Добавить метод Swim(плавать)
//2.4 При желании добавить свойства: крылья(wings), ноги(legs), (плавники)fins.

//3.Описать классы с наследованием от необходимых интерфейсов:
//3.1 Cat
//3.2 Eagle
//3.3 Fish
//3.4 Duck
//3.5 Создать массив объектов классов из п.3.1 – 3.4