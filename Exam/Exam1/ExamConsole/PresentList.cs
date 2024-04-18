using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExamConsole
{
    public class PresentList<T> where T:IPresent
    {
        List<T> presents;

       public double TotalPrice
        {
            get
            {
                double total = 0;
                for (int i = 0; i < presents.Count(); i++)
                {

                    total += presents[i].Price == null ? 0 : presents[i].Price.Value;

                }
                return total;
            }
        }
        public PresentList()
        {
            presents =   new List<T>();
        }
        public void Add(T item)
        {
            presents.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < presents.Count(); i++)
            {

                sb.Append(String.Format("{0}: {1}\n",presents[i].Name, (presents[i].Price == null ? "" : presents[i].Price.Value.ToString())));

            }

            return sb.ToString();

        }

        

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.presents.Count())
                {
                    throw new ExamException();
                }
                return this.presents[index];
            }

            set
            {
                if (index < 0 || index >= this.presents.Count())
                {
                    throw new ExamException();
                }
                this.presents[index] = value;

            }

        }

    }
}
