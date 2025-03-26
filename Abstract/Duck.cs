using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Duck : Animal, ISwiming, IWalking, IFlying
    {
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
        public void Swim()
        {
            throw new NotImplementedException();
        }
        public void Walk()
        {
            throw new NotImplementedException();
        }
        public void Fly() 
        {  
            throw new NotImplementedException(); 
        }
    }
}
