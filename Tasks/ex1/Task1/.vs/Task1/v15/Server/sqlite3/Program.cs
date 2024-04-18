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
            RStack<string> texts = new RStack<string>();
            texts.Push("abcd");
            texts.Push("ja su string");
            texts.Push("ja chci domu");

            while (!texts.IsEmpty())
            {
                Console.WriteLine(texts.Pop());
            };


            Console.WriteLine("________________________");
            RStack<int> nums = new RStack<int>();
            nums.Push(10);
            nums.Push(13);
            nums.Push(131);

            while (!nums.IsEmpty())
            {
                Console.WriteLine(nums.Pop());
            };

            Console.WriteLine("________________________");

            RStack<double?> nullrealnums = new RStack<double?>();
            nullrealnums.Push(10.45);
            nullrealnums.Push(13/4521);
            nullrealnums.Push(15.5 * 87 / 5);
            nullrealnums.Push(null);
            nullrealnums.Push(546*6*8*5*48/6);


            while (!nullrealnums.IsEmpty())
            {
                Console.WriteLine(nullrealnums.Pop());
            };

            Console.WriteLine("________________________");

            int s;
            int? refer = 2;
            DynamicArray dynam = new DynamicArray();
            dynam[0] = 6;
            Console.WriteLine(dynam.Length);
            dynam[27] = null;
            Console.WriteLine(dynam.Length);
            dynam[35] = 106;
            Console.WriteLine(dynam.Length);
            Console.WriteLine(dynam.ToString());
            dynam.Length = 50;
            Console.WriteLine(dynam.Length);
            Console.WriteLine(dynam.ToString());
            //dynam.Length = 10;
            //Console.WriteLine(dynam.Length);
            //Console.WriteLine(dynam.ToString());
            dynam.Sum(out s);
            Console.WriteLine("Sum = {0}",s);
            dynam.Add(ref refer,0);
            Console.WriteLine("Ref = {0}", refer);
            Console.WriteLine("State = {0}", dynam.State);


        }
    }
}
