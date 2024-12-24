using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kurs_work.Data.Base_Classes
{
    internal class Purchase
    {
        public int IDPurchase { get; set; }
        private static int PurchaseID = 1;
        
        public User User { get; set; }
        
        public Product Product { get; set; }
        
        public DateTime Date { get; set; }
        
        public int Quantity { get; set; }
        
        public int TotalPrice { get; set; }
        public Purchase()
        {
            IDPurchase = PurchaseID++;
        }
        

    }
}
