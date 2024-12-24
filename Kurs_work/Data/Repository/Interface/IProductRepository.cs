using Kurs_work.Data.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Repository.Interface
{
    internal interface IProductRepository
    {
        public void CreateProduct(Product product);
        public Product ReadProductByID(int id);
        public List<Product> ReadAll();
        public void DeleteProduct(int id);
        public void UpdateProductName(Product product, string name);
        public void UpdateProductPrice(Product product, int price);
        public void UpdateProductQuantity(Product product, int quantity);
    }
}
