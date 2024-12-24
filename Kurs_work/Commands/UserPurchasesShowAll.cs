using Kurs_work.Commands.Interface;
using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Service;
using Kurs_work.Data.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Commands
{
    internal class UserPurchasesShowAll : ICommands
    {
        private readonly UserService userService;
        public UserPurchasesShowAll(UserService userservice)
        {
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter User ID:");
            int userID = int.Parse(Console.ReadLine());
            var user = userService.ReadUserByID(userID);
            List<Purchase> purchaseList = userService.ReadAllUserPurchases(user);
            foreach (Purchase purchase in purchaseList)
            {
                Console.WriteLine($"ID: {purchase.IDPurchase}, Name: {purchase.User.FullName}, {purchase.Product.Name}, Account Balance: {purchase.Quantity}, {purchase.Date}.");
            }
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Show all User Purchases");
        }
    }
}
