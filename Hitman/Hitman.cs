using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitman
{
    internal class Hitman
    {
        private ITool currentTool;

        private IClothSet currentClothSet;

        public IClothSet CurrentClothSet
        {
            get { return currentClothSet; }
            set { currentClothSet = value; }
        }

        public void SetNextTools()
        {
            if (currentTool == null)
            {
                currentTool = new M16();
            }
            else
            {
                currentTool = new AK47();
            }
        }

        public void ChangeClothes(IClothSet clothSet)
        {
        }

        private List<ITool> allTools = new List<ITool>()
        {
            new AK47(),
            new M16()
        };

        public void ShootViaCurrentTool()
        {
            currentTool.Shoot();
        }


    }
}
//1.Описать класс Hitman

//1.1 Добавить в класс Hitman поле c currentTool типа ITool (интерфейс)
//1.2 Добавить в класс Hitman поле и свойство currentClothSet типа 
//IClothSet (интерфейс)
//1.3 Добавить метод SetNextTools()
//1.4 Добавить метод ChangeClothes(IClothset clothSet)
//1.5 Добавить в класс Hitman поле allTools типа List<ITool>. + инициализировать
//1.6 Добавить в класс Hitman метод ShootViaCurrentTool()
//2. Описать интерфейсы
//2.1 Описать интерфейс ITool
//2.1.1 Добавить метод Shoot() без реализации
//2.1.2 Создать >=2 любых реализаций интерйейса.
//2.2 Описать интерфейс IClothset
//2.2.1 При желании можно добавить пару методов
//2.2.2 Создать >=2 любых реализаций интерйейса.
//3. Клиентский код:
//3.1 Создать экземпляр класса Hitman
//3.2 Сменить оружие на любое другое. Если currentTool пустое, то задать ему начальное значение
//3.3 Создать экземпляр одежды
//3.4 Сменить комплект одежды на созданный в п.3.3
//3.5 Выстрелить текущим оружием