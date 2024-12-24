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
    internal class PurchasesShowAll : ICommands
    {
        private readonly PurchaseService purchaseService;
        public PurchasesShowAll(PurchaseService purchaseservice)
        {
            purchaseService = purchaseservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            List<Purchase> purchaseList = purchaseService.ReadAllPurchases();
            foreach (Purchase purchase in purchaseList)
            {
                Console.WriteLine($"ID: {purchase.IDPurchase}, Name: {purchase.User.FullName}, {purchase.Product.Name}, Quantity: {purchase.Quantity}, Date: {purchase.Date}.");
            }
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Show all Purchases");
        }
    }
}
