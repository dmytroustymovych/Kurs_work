using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Commands.Interface;

namespace Kurs_work.Commands
{
    internal class EndProgram : ICommands
    {
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Program ended");
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. End Program");
        }
    }
}
