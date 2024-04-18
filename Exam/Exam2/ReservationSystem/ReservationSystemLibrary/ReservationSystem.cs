using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemLibrary
{
    public class ReservationSystem
    {
        private List<Reservation> reservations;
        public List<ValidationRule> Rules;

        public ReservationSystem()
        {
            reservations = new List<Reservation>();
            Rules = new List<ValidationRule>();

        }

        public bool CreateReservation(Reservation reservation)
        {
            bool allow = true;
            for (int i = 0; i < Rules.Count; i++)
            {
                if (!Rules[i](reservations, reservation))
                {
                    allow =  false;
                    break;
                }

            }
            OnReservation(allow);
            return allow;

        }

        public void Load()
        {
            reservations.Clear();
            using (StreamReader sr = new StreamReader("reservations.txt"))
            {
                while(!sr.EndOfStream)
                {
                    Reservation r = new Reservation();
                    string[] line = sr.ReadLine().Split(';');
                    r.From = Convert.ToDateTime(line[0]);
                    r.To = Convert.ToDateTime(line[1]);
                    r.Capacity = Convert.ToInt32(line[2]);
                    r.Name = line[3];
                    reservations.Add(r);
                }

            }

        }
        public void Print()
        {
            for (int i = 0; i < reservations.Count; i++)
            {
                Console.WriteLine("{0}:\t{1}",i,reservations[i]);

            }

        }
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter("reservations.txt"))
            {
                for (int i = 0; i < reservations.Count; i++)
                {
                    sw.WriteLine(reservations[i].ToString());
                }

            }

        }

        public event ReservationProcessed OnReservation;



    }
    public delegate bool ValidationRule(List<Reservation> existingReservations, Reservation newReservation);
    public delegate void ReservationProcessed(bool created);
}
