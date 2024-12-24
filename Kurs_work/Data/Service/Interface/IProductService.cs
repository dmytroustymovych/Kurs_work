using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Service.Interface
{
    internal interface IProductService
    {
        public void CreateProduct(Product product);
        public List<Product> ReadAllProducts();
        public Product ReadProductByID(int id);
        public void DeleteProduct(int id);
        public void UpdateProductName(Product product, string name);
        public void UpdateProductPrice(Product product, int price);
        public void UpdateProductQuantity(Product product, int quantity);
        public void DeductQuantity(Product product, int quantity);
        public void AddQuantity(Product product, int quantity);
    }
}
