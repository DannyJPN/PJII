using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEvent
{
    public class Calc
    {

        private int x, y;

        public event EventHandler<EventArgDescendant> OnSetXY;
        public event ComputeHandler OnCompute;


        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.OnSetXY(this, new EventArgDescendant()
            {
                X = this.x,
                Y = this.y
            });
            
        }

        public void Execute(Operation o)
        {
            int result = o(this.x, this.y);
            Console.WriteLine(result);
            this.OnCompute(result);
            //return value goes there
        }

        public void ReactToSet(object sender,EventArgDescendant dargs)
        {

            Console.WriteLine("Reaction to set triggered: {0} and {1}",dargs.X,dargs.Y);
        }

       
            
    }



}
