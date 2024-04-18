using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class RQueue : IQueue
    {
        private int[] queue;
        private int insertpointer;
        private int removepointer;

        //implement getsetter
        public RQueue(int maxsize)
        {
            queue = new int [maxsize];
            removepointer = -1;
            insertpointer = -1;
        }
        public RQueue():this(20)
        {
            
        }

        public void Clear()
        {
            removepointer = -1;
            insertpointer = -1;
        }

        public bool IsEmpty()
        {
            return insertpointer == removepointer;
        }

        public bool IsFull()
        {
            return removepointer>=queue.Length-1;
        }

        public int Pop()
        {
            return queue[++removepointer];
            
        }

        public void Push(int number)
        {
            queue[++insertpointer] = number;
            
        }

        public int Top()
        {
            return queue[removepointer];
        }
    }
}
