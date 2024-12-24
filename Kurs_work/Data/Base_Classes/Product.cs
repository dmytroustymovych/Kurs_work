using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Base_Classes
{
    internal class Product
    {
        public int IDProduct { get; set; }

        private static int ProductID = 1;
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Product()
        {
            IDProduct = ProductID++;
        }

    }
}
