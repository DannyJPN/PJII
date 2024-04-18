using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Structures
{
    public interface IStack<T>:IADT
    {
        void Push(T element);
        T Pop();
    }
}
