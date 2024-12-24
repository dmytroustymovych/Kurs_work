using Kurs_work.Commands.Interface;
using Kurs_work.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Commands
{
    internal class UserAddAccountBalance : ICommands
    {
        private readonly UserService userService;
        public UserAddAccountBalance(UserService userservice)
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
            Console.WriteLine("Enter Account Balance:");
            int accountbalance = int.Parse(Console.ReadLine());
            var user = userService.ReadUserByNameAndPassword(name, password);
            userService.IncreaseUserAccountBalance(user, accountbalance);
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Add Account Balance");
        }
    }
}
