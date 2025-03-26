namespace Hitman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hitman hitman = new Hitman();

            hitman.SetNextTools();

            IClothSet clothSet = new Tuxedo();

            hitman.ChangeClothes(clothSet);

            hitman.ShootViaCurrentTool();
        }
    }
}

//3. Клиентский код:
//3.1 Создать экземпляр класса Hitman
//3.2 Сменить оружие на любое другое. Если currentTool пустое, то задать ему начальное значение
//3.3 Создать экземпляр одежды
//3.4 Сменить комплект одежды на созданный в п.3.3
//3.5 Выстрелить текущим оружием
