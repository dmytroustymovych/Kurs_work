using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Data.Service;
using Kurs_work.Commands.Interface;

namespace Kurs_work.Commands
{
    internal class UserRegister : ICommands
    {
        private readonly UserService userService;
        public UserRegister(UserService userservice)
        {
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Username:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            var user = userService.PrepareUser(name, password);
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Register user");
        }
    }
}
