using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEvent
{
    public class EventArgDescendant: EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {

            return String.Format("Randomnum: {0}",new Random().Next());

        }


    }
}
