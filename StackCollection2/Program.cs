using System;

class Node
{
    public int Data;  // Данные
    public Node Next; // Ссылка на следующий элемент

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    public Node Head; // Первый элемент списка

    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode; // Если список пуст, то новый элемент становится головой
        }
        else
        {
            Node current = Head;
            while (current.Next != null) // Идём до последнего элемента
            {
                current = current.Next;
            }
            current.Next = newNode; // Добавляем новый элемент в конец
        }
    }

    public void Print()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        SinglyLinkedList list = new SinglyLinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);    

        list.Print(); // Вывод: 1 -> 2 -> 3 -> null
    }
}
