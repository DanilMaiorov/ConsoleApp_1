namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack newStack = new Stack("яблоко", "книга", "солнце", "музыка", "ветер", "гора", "река", "цветок", "звезда", "птица");


            var s = Stack.Concat();

            s.Pop();
            Console.WriteLine("");

            newStack.Merge(new Stack());
            newStack.Merge(new Stack("1", "2", "3", "4", "5"));

            Console.WriteLine(newStack.Size);
            var deletedItem1 = newStack.Pop();
            var deletedItem2 = newStack.Pop();
            var deletedItem3 = newStack.Pop();
            Console.WriteLine(newStack.Size);
            var deletedItem4 = newStack.Pop();
            var deletedItem5 = newStack.Pop();
            Console.WriteLine($"size = {newStack.Size}, Top = {(newStack.Top == null ? "null" : newStack.Top)}");
            var deletedItem6 = newStack.Pop();
            var deletedItem7 = newStack.Pop();
            var deletedItem8 = newStack.Pop();
            Console.WriteLine(newStack.Size);
            var deletedItem9 = newStack.Pop();
            var deletedItem10 = newStack.Pop();
            Console.WriteLine($"size = {newStack.Size}, Top = {(newStack.Top == null ? "null" : newStack.Top)}");
            var deletedItem11 = newStack.Pop();
            Console.WriteLine($"size = {newStack.Size}, Top = {(newStack.Top == null ? "null" : newStack.Top)}");
            var deletedItem12 = newStack.Pop();
            Console.WriteLine($"size = {newStack.Size}, Top = {(newStack.Top == null ? "null" : newStack.Top)}");
            var deletedItem13 = newStack.Pop();
            Console.WriteLine($"size = {newStack.Size}, Top = {(newStack.Top == null ? "null" : newStack.Top)}");





            Console.WriteLine("то ещё 1 экземпляр");
            Stack newStack1 = new Stack();
            Console.WriteLine($"size = {newStack1.Size}, Top = {(newStack1.Top == null ? "null" : newStack1.Top)}");
            Console.WriteLine();
        }
    }
}
