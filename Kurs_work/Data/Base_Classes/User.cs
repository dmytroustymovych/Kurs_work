using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Base_Classes
{
    class User
    {
        public int IDUser { get; set; }
        private static int UserID = 1;
        public string FullName { get; set; }
        public string Password { get; set; }
        public int AccountBalance { get; set; }
        public bool IsActive { get; set; }
        public List<Purchase> UserPurchases { get; set; } 
        public User()
        {
            IDUser = UserID++;
            AccountBalance = 0;
            IsActive = false;
            UserPurchases = new List<Purchase>();
        }

    }
}
