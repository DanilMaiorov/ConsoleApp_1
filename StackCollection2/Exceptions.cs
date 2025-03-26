using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    internal class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Стек пустой") { }
    }
}
