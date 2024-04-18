using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structures;

namespace QueueStack
{
    class Program
    {
        static void Main(string[] args)
        {
            RQueue rq = new RQueue();
            rq.Push(30);
            Console.WriteLine(rq.Pop());
            Console.WriteLine(rq.Pop());

        }
    }
}
