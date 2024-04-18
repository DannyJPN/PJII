using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEvent
{
    class Program
    {



      /*  private static Func<int,int> Apply(int x)
        {

            return (int y) => x + y;

        }*/
        static void Main(string[] args)
        {
            Calc c = new Calc();
            c.OnSetXY += c.ReactToSet;
            c.OnCompute += (int r) => { Console.WriteLine("Result {0}", r); };
            c.SetXY(7, 5);
            
            c.Execute(Mult);
            c.Execute(Pow);
            c.Execute((x, y) => { return x + y; });
           
        }

       

        private static int Mult(int x, int y)
        {
            return x * y;

        }
        private static int Pow(int x, int y)
        {
            return Convert.ToInt32(Math.Pow(Convert.ToDouble(x),Convert.ToDouble(y)));

        }


    }

    public delegate int Operation(int x, int y);
    public delegate void ComputeHandler(int result);

}
