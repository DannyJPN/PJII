using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class RStack : IStack
    {
        private int[] stack;
        private int pointer;
        public RStack(int maxsize)
        {
            stack = new int[maxsize];
            pointer = -1;

        }
        public RStack() : this(20)
        {

        }
        public void Add(int number)
        {
            stack[++pointer] = number;
        }

        public void Clear()
        {
            pointer = -1;
        }

        public int Get()
        {
            return stack[pointer--];
        }

        public bool IsEmpty()
        {
            return stack.Length == 0;
        }

        public bool IsFull()
        {
            return pointer >= stack.Length - 1;
        }
    }
}
