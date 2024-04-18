using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsole
{
    public class ExamException : ApplicationException
    {
        public override string StackTrace
        {
            get
            {
                return "Present list exception thrown";
            }
        }
    
    }
}
