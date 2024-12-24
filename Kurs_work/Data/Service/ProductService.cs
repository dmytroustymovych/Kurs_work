using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Repository;
using Kurs_work.Data.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Service
{
    internal class ProductService : IProductService
    {
        private readonly ProductRepository productRepository;
        public ProductService(DBContext context)
        {
            productRepository = new ProductRepository(context);
        }
        public void CreateProduct(Product product)
        {
            productRepository.CreateProduct(product);
        }

        public List<Product> ReadAllProducts()
        {
            return productRepository.ReadAll();
        }

        public Product ReadProductByID(int id)
        {
            return productRepository.ReadProductByID(id);
        }

        public void DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
        }

        public void UpdateProductName(Product product, string name)
        {
            productRepository.UpdateProductName(product, name);
        }

        public void UpdateProductPrice(Product product, int price)
        {
            productRepository.UpdateProductPrice(product, price);
        }

        public void UpdateProductQuantity(Product product, int quantity)
        {
            productRepository.UpdateProductQuantity(product, quantity);
        }
        public void DeductQuantity(Product product, int quantity)
        {
            int currentquantity = product.Quantity - quantity;
            UpdateProductQuantity(product, currentquantity);
        }
        public void AddQuantity(Product product, int quantity)
        {
            int currentquantity = product.Quantity + quantity;
            UpdateProductQuantity(product, currentquantity);
        }
    }
}
