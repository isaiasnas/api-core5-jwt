using Api2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Email = "123", Senha = "123", Role = "admin" });
            users.Add(new User { Id = 2, Email = "132", Senha = "123", Role = "admin" });
            return users
                .Where(x => x.Email.ToLower() == username.ToLower() && x.Senha == x.Senha)
                .FirstOrDefault();
        }
    }
}