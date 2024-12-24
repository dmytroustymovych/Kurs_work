using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Repository;
using Kurs_work.Data.Repository.Interface;
using Kurs_work.Data.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Service
{
    internal class PurchaseService : IPurchaseService
    {
        private readonly PurchaseRepository purchaseRepository;
        private readonly ProductService productService;
        private readonly UserService userService;
        public PurchaseService(DBContext context)
        {
            purchaseRepository = new PurchaseRepository(context);
            productService = new ProductService(context);
            userService = new UserService(context);
        }
        public void CreatePurchase(Purchase purchase)
        {
            purchaseRepository.CreatePurchase(purchase);
        }
        public Purchase ReadPurchaseByID(int id)
        {
            return purchaseRepository.ReadPurchaseByID(id);
        }

        public List<Purchase> ReadAllPurchases()
        {
            return purchaseRepository.ReadAll();
        }

        public void DeletePurchase(int id)
        {
            purchaseRepository.DeletePurchase(id);
        }

        public void UpdatePurchasePrice(Purchase purchase, int price)
        {
            purchaseRepository.UpdatePurchase(purchase, price);
        }
        public Purchase PurchaseProduct(User user, Product product, int quantity)
        {
            var User = userService.ReadUserByID(user.IDUser);
            var Product = productService.ReadProductByID(product.IDProduct);
            int totalprice = product.Price * quantity;
            if (User != null && Product != null)
            {
                if (User.IsActive == true) { 
                    if (user.AccountBalance >= totalprice)
                    {
                        var purchase = new Purchase
                        {
                            User = user,
                            Product = product,
                            Date = DateTime.Now,
                            Quantity = quantity,
                            TotalPrice = totalprice
                        };
                        CreatePurchase(purchase);
                        int newaccountbalance = user.AccountBalance - totalprice;
                        userService.UpdateUserAccountBalance(user, newaccountbalance);
                        productService.DeductQuantity(product, quantity);
                        var createdPurchase = ReadPurchaseByID(purchase.IDPurchase);
                        return createdPurchase;
                    }
                    else
                    {
                        throw new InvalidOperationException("Insufficient funds.");

                    }
                } 
                else
                {
                    throw new InvalidOperationException("User is not Logged In.");
                }
            }
            else
            {
                throw new InvalidOperationException("User or Product not found.");
            }
        }
    }
}
