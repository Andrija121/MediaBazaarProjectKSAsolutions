using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class UserManagement
    {
        List<User> users = new List<User>();

        public UserManagement()
        {

        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User GetUser(int id)
        {
            foreach (var user in users)
            {
                if(user.Id==id)
                {
                    return user;
                }
            }
            return null;
        }
        public List<User> GetUsers()
        {
            return users;
        }
        public void RemoveUserAtIndex(int uIndex)
        {
            users.RemoveAt(uIndex);
        }
    }
}
