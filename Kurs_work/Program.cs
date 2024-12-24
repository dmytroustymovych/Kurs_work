using System.Security.Cryptography.X509Certificates;
using Kurs_work.Data.Service.Interface;
using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Service;
using Kurs_work.Data;
using Kurs_work.Commands;
using ICommands = Kurs_work.Commands.Interface.ICommands;
class Program
{
    int list = 1;
    static void Main(string[] args)
    {
        var context = new DBContext();
        var userService = new UserService(context);
        var productService = new ProductService(context);
        var purchaseService = new PurchaseService(context);
        var userRegister = new UserRegister(userService);
        Program program = new Program();

        //10 продуктів
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000, Quantity = 5 },
            new Product { Name = "Mobile", Price = 500, Quantity = 10 },
            new Product { Name = "Tablet", Price = 300, Quantity = 15 },
            new Product { Name = "Monitor", Price = 200, Quantity = 20 },
            new Product { Name = "Keyboard", Price = 50, Quantity = 25 },
            new Product { Name = "Mouse", Price = 30, Quantity = 30 },
            new Product { Name = "Printer", Price = 150, Quantity = 35 },
            new Product { Name = "Scanner", Price = 120, Quantity = 40 },
            new Product { Name = "Speaker", Price = 80, Quantity = 45 },
            new Product { Name = "Headphones", Price = 60, Quantity = 50 }
        };

        foreach (var product in products)
        {
            productService.CreateProduct(product);
        }

        program.Run(userService, productService, purchaseService);
    }
        public void Run(UserService userService, ProductService productService, PurchaseService purchaseService)
        {
            ICommands[] commands =
            [
                new EndProgram(),
                new UserLogin(userService),
                new UserRegister(userService),
                new UserLogout(userService),
                new UserDelete(userService),
                new PurchaseProduct(purchaseService, productService, userService),
                new UserAddAccountBalance(userService),
                new UserPurchasesShowAll(userService),
                new ProductAddQuantity(productService),
                new UsersShowAll(userService),
                new ProductsShowAll(productService),
                new PurchasesShowAll(purchaseService),
            ];

            while (list != 0)
            {
            try
            {
                int index = 0;
                Console.WriteLine("------------------------------------------------");
                foreach (ICommands command in commands)
                {
                    try
                    {
                        command.GetInfo(index);
                        index++;
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                }

                list = int.Parse(Console.ReadLine());
                commands[list].Execute();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        }
    
}