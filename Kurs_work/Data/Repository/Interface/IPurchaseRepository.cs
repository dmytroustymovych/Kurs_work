using Kurs_work.Data.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Repository.Interface
{
    internal interface IPurchaseRepository
    {
        public void CreatePurchase(Purchase purchase);
        public Purchase ReadPurchaseByID(int id);
        public List<Purchase> ReadAll();
        public void DeletePurchase(int id);
        public void UpdatePurchase(Purchase purchase, int price);
    }
}
