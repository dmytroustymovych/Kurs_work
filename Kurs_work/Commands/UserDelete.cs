using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Commands.Interface;
using Kurs_work.Data.Service;

namespace Kurs_work.Commands
{
    internal class UserDelete : ICommands
    {
        private readonly UserService userService;
        public UserDelete(UserService userservice)
        {
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter User ID:");
            int userID = int.Parse(Console.ReadLine());
            userService.DeleteUser(userID);

        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Delete User");
        }
    }
}
