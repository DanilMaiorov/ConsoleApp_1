using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Cat : Animal, IWalking
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Walk()
        {
            Console.WriteLine("Гуляет");
        }

    }
}
