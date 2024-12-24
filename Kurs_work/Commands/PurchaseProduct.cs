using Kurs_work.Data.Service;
using Kurs_work.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Commands.Interface;
using Kurs_work.Data.Service.Interface;
using Kurs_work.Data.Base_Classes;

namespace Kurs_work.Commands
{
    internal class PurchaseProduct : ICommands
    {
        private readonly PurchaseService purchaseService;
        private readonly ProductService productService;
        private readonly UserService userService;
        public PurchaseProduct(PurchaseService purchaseservice, ProductService productservice, UserService userservice)
        {
            purchaseService = purchaseservice;
            productService = productservice;
            userService = userservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Product ID:");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int quantity = int.Parse(Console.ReadLine());
            var user = userService.ReadUserByNameAndPassword(username, password);
            var product = productService.ReadProductByID(productID);
            purchaseService.PurchaseProduct(user, product, quantity);
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Purchase Product");
        }
    }
}
