﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Commands.Interface
{
    internal interface ICommands
    {
        public void Execute();
        public void GetInfo(int index);
    }
}
