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
    internal class ProductRepository : IProductRepository
    {
        private readonly DBContext _context; 
        public ProductRepository(DBContext context)
        {
            _context = context;
        }
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
        }
        public Product ReadProductByID(int id)
        {
            return _context.Products.FirstOrDefault(product => product.IDProduct == id);
        }
        public List<Product> ReadAll()
        {
            return _context.Products;
        }
        public void DeleteProduct(int id)
        {
            var Product = ReadProductByID(id);
            if (Product != null)
            {
                _context.Products.Remove(Product);
            }
        }
        public void UpdateProductName(Product product, string name)
        {
            var currentProduct = ReadProductByID(product.IDProduct);
            if (currentProduct != null)
            {
                currentProduct.Name = name;
            }
        }
        public void UpdateProductPrice(Product product, int price)
        {
            var currentProduct = ReadProductByID(product.IDProduct);
            if (currentProduct != null)
            {
                currentProduct.Price = price;
            }
        }
        public void UpdateProductQuantity(Product product, int quantity)
        {
            var currentProduct = ReadProductByID(product.IDProduct);
            if (currentProduct != null)
            {
                currentProduct.Quantity = quantity;
            }
        }
        
    }
}
