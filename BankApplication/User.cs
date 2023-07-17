﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class User
    {
       
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string ContactNo { get; set; }
        public int RoleId { get; set; }
    }

    public class UserCRUD
    {
        private List<User> users;

        public UserCRUD()
        {
            users = new List<User>();
            users.Add(new User { UserId = 101, UserName = "admin", Password = "admin101", ContactNo = "2536495", RoleId = 1 });
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public int Login(int UserId, string Password)
        {
            int RoleId = 0;
            foreach (User user in users)
            {
                if (user.UserId == UserId && user.Password == Password)
                {
                    RoleId = user.RoleId;
                    break;

                }
            }
            return RoleId;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void Logout(User user)
        {
            user.UserId = user.UserId;

        }



    }
}
