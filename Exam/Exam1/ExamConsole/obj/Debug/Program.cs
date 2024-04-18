using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentList<IPresent> presents = new PresentList<IPresent>();

            presents.Add(new PhysicalPresent("Kolo",16990));
            presents.Add(new PhysicalPresent("Notebook",34999) );
            presents.Add(new VirtualPresent("Voucher",156));
            presents.Add(new VirtualPresent("Úklid",null));

            Console.WriteLine("Celková cena: " + presents.TotalPrice);
            Console.WriteLine();
            Console.WriteLine("Položky\n-------------\n");
            Console.WriteLine(presents);

            Console.WriteLine("Druhá položka: " + presents[1].Name);


        }
    }
}
