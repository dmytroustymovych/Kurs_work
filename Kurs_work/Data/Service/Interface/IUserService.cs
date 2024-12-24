using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Repository;
using Kurs_work.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_work.Data.Service.Interface
{
    internal interface IUserService
    {
        public void CreateUser(User user);
        public User ReadUserByID(int id);
        public List<User> ReadAllUsers();
        public List<Purchase> ReadAllUserPurchases(User user);
        public User ReadUserByNameAndPassword(string name, string password);
        public void DeleteUser(int id);
        public void UpdateUserFullName(User user, string fullname);
        public void UpdateUserPassword(User user, string password);
        public void UpdateUserAccountBalance(User user, int accountBalance);
        public void UpdateUserIsActiveTrue(User user, bool active);
        public void UpdateUserIsActiveFalse(User user, bool active);
        public void IncreaseUserAccountBalance(User user, int accountBalance);
        public User PrepareUser(string name, string password);
        public User Login(string name, string password);
        public User Logout(string name, string password);
    }
}
