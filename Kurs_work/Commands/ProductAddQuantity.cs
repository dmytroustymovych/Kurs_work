using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Commands.Interface;
using Kurs_work.Data.Service;

namespace Kurs_work.Commands
{
    internal class ProductAddQuantity : ICommands
    {
        private readonly ProductService productService;
        public ProductAddQuantity(ProductService productservice)
        {
            productService = productservice;
        }
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter Product ID:");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int quantity = int.Parse(Console.ReadLine());
            var product = productService.ReadProductByID(productID);
            productService.AddQuantity(product, quantity);

        }
        public void GetInfo(int index)
        {
            Console.WriteLine($"{index}. Add Product Quantity");
        }
    }
}
