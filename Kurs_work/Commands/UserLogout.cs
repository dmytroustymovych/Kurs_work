using Kurs_work.Commands.Interface;
using Kurs_work.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Commands
{
    internal class UserLogout : ICommands
    {
        private readonly UserService userService;
        public UserLogout(UserService userservice)
        {
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            userService.Logout(name, password);
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Logout user");
        }
    }
}
