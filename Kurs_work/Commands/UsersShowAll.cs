using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Commands.Interface;
using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Service;

namespace Kurs_work.Commands
{
    internal class UsersShowAll : ICommands
    {
        private readonly UserService userService;
        public UsersShowAll(UserService userservice)
        {
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            List<User> usersList = userService.ReadAllUsers();
            foreach (User user in usersList)
            {
                Console.WriteLine($"ID: {user.IDUser}, Name: {user.FullName}, {user.Password}, Account Balance: {user.AccountBalance}, Online: {user.IsActive}.");
            }
        }
        public void GetInfo(int index)
        {
        Console.WriteLine($"{index}. Show all Users");
        }
    
    
    }
}
