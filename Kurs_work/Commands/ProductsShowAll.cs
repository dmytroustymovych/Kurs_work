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
    internal class ProductsShowAll : ICommands
    {
        private readonly ProductService productService;
        public ProductsShowAll(ProductService productservice)
        {
            productService = productservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            List<Product> productsList = productService.ReadAllProducts();
            foreach (Product product in productsList)
            {
                Console.WriteLine($"ID: {product.IDProduct}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Show all Products");
        }

    }
}
