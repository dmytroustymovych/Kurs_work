using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Repository;
using Kurs_work.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Service.Interface
{
    internal interface IPurchaseService
    {
        public void CreatePurchase(Purchase purchase);
        public Purchase ReadPurchaseByID(int id);
        public List<Purchase> ReadAllPurchases();
        public void DeletePurchase(int id);
        public void UpdatePurchasePrice(Purchase purchase, int price);
        public Purchase PurchaseProduct(User user, Product product, int quantity);
    }
}
