using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsole
{
    public class VirtualPresent : IPresent
    {
        public string Name { get ; set ; }
        public double? Price { get; set; }

        public VirtualPresent(string name, double? price)
        {
            Name = name;
            Price = price;


        }
    }
}
