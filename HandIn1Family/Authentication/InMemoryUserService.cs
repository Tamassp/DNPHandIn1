using System;
using System.Collections.Generic;
using System.Linq;

namespace HandIn1Family.Authentication
{
    public class InMemoryUserService: IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                     Password = "123456",
                    SecurityLevel = 3, UserName = "Adam"
                },
                new User
                {
                     Password = "654321", 
                    SecurityLevel = 2, UserName = "Eve"
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}