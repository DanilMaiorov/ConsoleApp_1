using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    internal class EmptyMergeStackException : Exception
    {
        public EmptyMergeStackException() : base("Попытка смержить пустой стек") { }
    }
}
