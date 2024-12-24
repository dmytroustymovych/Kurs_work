using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Kurs_work.Data.Base_Classes;
using Kurs_work.Data.Repository;
using Kurs_work.Data.Service.Interface;

namespace Kurs_work.Data.Service
{
    internal class UserService : IUserService
    {
        private readonly UserRepository userRepository;
        public UserService(DBContext context)
        {
            userRepository = new UserRepository(context);
        }
        public void CreateUser(User user)
        {
            userRepository.CreateUser(user);
        }
        public User ReadUserByID(int id)
        {
            return userRepository.ReadUserByID(id);
        }
        public List<User> ReadAllUsers()
        {
            return userRepository.ReadAll();
        }
        public List<Purchase> ReadAllUserPurchases(User user)
        {
            userRepository.ReadUserByID(user.IDUser);
            if (user != null)
            {
                return userRepository.ReadUserPurchases(user);
            }
            else
            {
                throw new InvalidOperationException("Invalid ID.");
            }
            
        }
        public User ReadUserByNameAndPassword(string name, string password)
        {
            return userRepository.ReadUserByNameAndPassword(name, password);
        }
        public void DeleteUser(int id)
        {
            
            var user = userRepository.ReadUserByID(id);
            if (user != null)
            {
                userRepository.DeleteUser(id);
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
        }
        public void UpdateUserFullName(User user, string name)
        {
            
            var User = userRepository.ReadUserByID(user.IDUser);
            if (User != null)
            {
                userRepository.UpdateUserFullName(user, name);
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
        }

        public void UpdateUserPassword(User user, string password)
        {
            var User = userRepository.ReadUserByID(user.IDUser);
            if (User != null)
            {
                userRepository.UpdateUserPassword(user, password);
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
            
        }

        public void UpdateUserAccountBalance(User user, int accountBalance)
        {
            var User = userRepository.ReadUserByID(user.IDUser);
            if (User != null)
            {
                userRepository.UpdateUserAccountBalance(user, accountBalance);
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
        }
        public void UpdateUserIsActiveTrue(User user, bool active)
        {
            var currentUser = ReadUserByID(user.IDUser);
            if (currentUser != null)
            {
                userRepository.UpdateUserIsActive(user, active);
            }
        }
        public void UpdateUserIsActiveFalse(User user, bool active)
        {
            var currentUser = ReadUserByID(user.IDUser);
            if (currentUser != null)
            {
                userRepository.UpdateUserIsActive(user, active);
            }
        }
        public void IncreaseUserAccountBalance(User user, int accountBalance)
        {
            int newaccountbalance = user.AccountBalance + accountBalance;
            if (user.IsActive == true) { 
                userRepository.UpdateUserAccountBalance(user, newaccountbalance);
            }
            else
            {
                throw new InvalidOperationException("User is not Logged In.");
            }
        }
        public User PrepareUser(string name, string password)
        {
            if (name != string.Empty && password != string.Empty) { 
                var user = new User
                {
                    FullName = name,
                    Password = password,
                };
                CreateUser(user);
                return user;
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
        }
        public User Login(string name, string password)
        {
            bool active = true;
            var user = userRepository.ReadUserByNameAndPassword(name, password);
            if (user != null)
            {
                UpdateUserIsActiveTrue(user, active);
                return user;
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
        }

        public User Logout(string name, string password)
        {
            bool active = false;
            var user = userRepository.ReadUserByNameAndPassword(name, password);
            if (user != null)
            {
                UpdateUserIsActiveFalse(user, active);
                return user;
            }
            else
            {
                throw new InvalidOperationException("Invalid Data.");
            }
        }

    }
}
