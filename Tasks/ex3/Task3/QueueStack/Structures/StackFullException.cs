using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class StackFullException:Exception
    {
        public StackFullException(string msg) : base(msg)
        { }
    }
}
