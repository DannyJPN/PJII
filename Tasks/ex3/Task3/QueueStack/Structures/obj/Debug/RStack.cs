using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class RStack<T> : IStack<T>
    {
        private T[] stack;
        private int pointer;
        public RStack(int maxsize)
        {
            stack = new T[maxsize];
            pointer = -1;

        }
        public RStack() : this(20)
        {

        }
        public void Push(T element)
        {
            stack[++pointer] = element;
        }

        public void Clear()
        {
            pointer = -1;
        }

        public T Pop()
        {
            return stack[pointer--];
        }
        public T Top()
        {
            return stack[pointer];
        }

        public bool IsEmpty()
        {
            return pointer <0;
        }

        public bool IsFull()
        {
            return pointer >= stack.Length - 1;
        }


    }
}
