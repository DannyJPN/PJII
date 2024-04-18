using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public interface IQueue:IADT
    {
        void Push(int number);
        int Pop();
        int Top();

    }
}
