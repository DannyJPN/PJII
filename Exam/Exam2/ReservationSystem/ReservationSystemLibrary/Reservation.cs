using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemLibrary
{
    public class Reservation
    {
        public int Capacity { get; set; }
        public DateTime From { get; set; }
        public string Name { get; set; }
        public DateTime To { get; set; }

        public override string ToString()
        {
            return String.Format("{0};{1};{2};{3}",From,To,Capacity,Name);
        }

    }
}
