﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamConsole
{
    public interface IPresent
    {
         string Name { get; set; }
         double? Price { get; set; } 
    }
}
