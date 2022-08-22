using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Common.Interfaces;
using VicMarket.Domain.Entities;
using VicMarket.Infrastructure.Contexts.VicMarket;

namespace VicMarket.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>()
        {

        };
        private readonly VicMarketDbContext _userDbContext;

        public UserRepository(VicMarketDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public User CreateUser(User user)
        {
            _userDbContext.Users.Add(user);
            _userDbContext.SaveChanges();
            return user;
        }

        public User DeleteUser(User user)
        {
            _userDbContext.Users.Remove(user);
            _userDbContext.SaveChanges();
            return null;
        }

        public List<User> GetAllUsers()
        {
            return _userDbContext.Users.ToList();
        }
    }
}
