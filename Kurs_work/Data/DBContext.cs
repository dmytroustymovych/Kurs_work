using Kurs_work.Data.Base_Classes;

namespace Kurs_work.Data
{
    internal class DBContext
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<Purchase> Purchases { get; set; }

        public DBContext()
        {
            Users = new List<User>();
            Products = new List<Product>();
            Purchases = new List<Purchase>();
        }
    }
}
