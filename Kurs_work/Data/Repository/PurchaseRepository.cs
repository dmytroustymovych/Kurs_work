using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Data.Base_Classes;
using Kurs_work.Data;
using Kurs_work.Data.Repository.Interface;

namespace Kurs_work.Data.Repository
{
    internal class PurchaseRepository : IPurchaseRepository
    {
        private readonly DBContext _context;
        public PurchaseRepository(DBContext context)
        {
            _context = context;
        }
        public void CreatePurchase(Purchase purchase)
        {
            var User = _context.Users.FirstOrDefault(user => user.IDUser == purchase.User.IDUser);
            if (User != null)
            {
                _context.Purchases.Add(purchase);
                User.UserPurchases.Add(purchase);
            }
        }
        public Purchase ReadPurchaseByID(int id)
        {
            return _context.Purchases.FirstOrDefault(purchase => purchase.IDPurchase == id);
        }
        public List<Purchase> ReadAll()
        {
            return _context.Purchases;
        }
        public void DeletePurchase(int id)
        {
            var Purchase = ReadPurchaseByID(id);
            
            if (Purchase != null)
            {
                var User = _context.Users.FirstOrDefault(user => user.IDUser == Purchase.User.IDUser);
                if (User != null) { 
                    _context.Purchases.Remove(Purchase);
                    User.UserPurchases.Remove(Purchase);
                }
            }
        }
        public void UpdatePurchase(Purchase purchase, int price)
        {
            var currentPurchase = ReadPurchaseByID(purchase.IDPurchase);
            if (currentPurchase != null)
            {
                currentPurchase.TotalPrice = price;
            }
        }
    }
}
