using Kurs_work.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Data.Service;
using Kurs_work.Commands.Interface;

namespace Kurs_work.Commands
{
    internal class UserLogin : ICommands
    {
        private readonly UserService userService;
        public UserLogin(UserService userservice)
        {
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            userService.Login(name, password);
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Login user");
        }
    }
}
