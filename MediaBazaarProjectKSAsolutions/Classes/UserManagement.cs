using MediaBazaarProjectKSAsolutions.DAL;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    
    class UserManagement
    {
        UserDAL userDAL = new UserDAL();
        
        public UserManagement()
        {
        }
        public int GetNumberOfUsers()
        {
            int NumberOfUsers = userDAL.GetNumberOfUsers();
            return NumberOfUsers;
        }

        public int AddUser(User user)
        {
            int u = userDAL.AddUser(user);
            return u;
        }

        public void AssignContractToUser(Contract contract,int userId)
        {
            userDAL.AssignContractToUser(contract, userId);
        }

        public Contract GetContract(int id)
        {
            Contract contract = userDAL.GetContract(id);
            return contract;
        }
        public User GetUser(int id)
        {
            User user = userDAL.GetUser(id);
            return user;
        }
        public Contract EditContract(Contract contract)
        {
            Contract c = userDAL.EditContract(contract);
            return c;
        }

        public User EditUser(User u)
        {

            User user = userDAL.EditUser(u);
            return user;
        }
        public List<User> GetInactiveUsers()
        {
            List<User> inactiveUsers = new List<User>();
            foreach (var iu in userDAL.GetInactiveUsers())
            {
                inactiveUsers.Add(iu);
            }
            return inactiveUsers;
        }
        public List<User> GetAwayUsers()
        {
            List<User> awayUsers = new List<User>();
            foreach (var au in userDAL.GetAwayUsers())
            {
                awayUsers.Add(au);
            }
            return awayUsers;
        }
        public List<User> GetUsers()
        {
            List<User> activeUsers = new List<User>();
            foreach (var u in userDAL.GetUsers())
            {
                activeUsers.Add(u);
            }
            return activeUsers;
        }
        public void SetUserStatusToInactive(User user)
        {
            user.Status = Status.INACTIVE;
            EditUser(user);
        }
        public void SetUserStatusToAway(User user, double days)
        {            

                user.Status = Status.AWAY;
                EditUser(user);
        }
        public void SetUserStatusToActive(User user)
        {
            user.Status = Status.ACTIVE;
            EditUser(user);
        }
        public bool CheckIfUserAlreadyExist(string username,string email,int bsn)
        {
            bool userAlreadyExist = false;
            userAlreadyExist = userDAL.CheckIfUserAlreadyExist(username, email, bsn);
            return userAlreadyExist;
        }
    }
} 
