using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection2
{
    internal class StackNode
    {
        public string Data;

        public StackNode Next;

        public StackNode(string str) 
        {
            Data = str;
            Next = null;
        }



    }
}
