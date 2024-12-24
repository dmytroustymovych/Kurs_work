using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs_work.Data.Base_Classes;
using Kurs_work.Data;
using Kurs_work.Data.Repository.Interface;

namespace Kurs_work.Data.Repository
{
    internal class UserRepository : IUserRepository
    {
        private readonly DBContext _context;

        public UserRepository (DBContext context)
        {
            _context = context;
        }
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
        }
        public List<User> ReadAll()
        {
            return _context.Users;
        }
        public User ReadUserByID(int id)
        {
            return _context.Users.FirstOrDefault(user => user.IDUser == id);
        }
        public User ReadUserByNameAndPassword(string name, string password)
        {
            return _context.Users.FirstOrDefault(user => user.FullName == name && user.Password == password);
        }
        public List<Purchase> ReadUserPurchases(User user)
        {
            return user.UserPurchases;
        }
        public void DeleteUser(int id)
        {
            var User = ReadUserByID(id);
            if (User != null)
            {
                _context.Users.Remove(User);
            }
        }
        public void UpdateUserFullName(User user, string fullname)
        {
            var currentUser = ReadUserByID(user.IDUser); 
            if (currentUser != null)
            {
                currentUser.FullName = fullname;
            }
        }
        public void UpdateUserPassword(User user, string password)
        {
            var currentUser = ReadUserByID(user.IDUser);
            if (currentUser != null)
            {
                currentUser.Password = password;
            }
        }
        public void UpdateUserAccountBalance(User user, int newaccountbalance)
        {
            var currentUser = ReadUserByID(user.IDUser);
            if (currentUser != null)
            {
                currentUser.AccountBalance = newaccountbalance;
            }
        }
        public void UpdateUserIsActive(User user, bool active)
        {
            var currentUser = ReadUserByID(user.IDUser);
            if (currentUser != null)
            {
                user.IsActive = active;
            }
            
        }

    }
}
