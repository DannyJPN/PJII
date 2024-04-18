using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib1;


namespace Cons1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Insert whole number 1");
            string n1 = Console.ReadLine();
            Console.WriteLine("Insert whole number 2");
            string n2 = Console.ReadLine();


            Console.WriteLine(n1 + n2);
            Console.WriteLine(Convert.ToInt32(n1) + Convert.ToInt32(n2));
            Console.WriteLine(int.Parse(n1) + int.Parse(n2));

            Console.WriteLine("Insert decimal number 1");
            string d1 = Console.ReadLine();
            Console.WriteLine("Insert decimal number 2");
            string d2 = Console.ReadLine();

            //ISO639-2
            Console.WriteLine(d1 + d2);
            Console.WriteLine(Convert.ToInt32(d1, CultureInfo.GetCultureInfo("en-GB")) + Convert.ToInt32(d2, CultureInfo.GetCultureInfo("en-GB")));
            Console.WriteLine(int.Parse(d1,CultureInfo.GetCultureInfo("en-GB")) + int.Parse(d2, CultureInfo.GetCultureInfo("en-GB")));
            //Thread.CurrentThread.CurrentCulture = ...
            */
            /*
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                sum += Convert.ToInt32(args[i]);                
            }
            Console.WriteLine(sum);
            */

            string txt = "Já chci domů";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.Contains("xxx"));
            Console.WriteLine(txt.Contains("dom"));
            Console.WriteLine(txt.IndexOf("xxx"));
            Console.WriteLine(txt.IndexOf("dom"));

            string[] splitar = txt.Split(" ".ToCharArray());
            foreach (string item in splitar)
            {
                Console.WriteLine(item);
            }

            Person.Greet("Dan");


        }
    }


   
}
