using Kurs_work.Data.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Repository.Interface
{
    internal interface IUserRepository
    {
        public void CreateUser(User user);
        public List<User> ReadAll();
        public User ReadUserByID(int id);
        public User ReadUserByNameAndPassword(string name, string password);
        public List<Purchase> ReadUserPurchases(User user);
        public void DeleteUser(int id);
        public void UpdateUserFullName(User user, string fullname);
        public void UpdateUserPassword(User user, string password);
        public void UpdateUserAccountBalance(User user, int newaccountbalance);
        public void UpdateUserIsActive(User user, bool active);
    }
}
