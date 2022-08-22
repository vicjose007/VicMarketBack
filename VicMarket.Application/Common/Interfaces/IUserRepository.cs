using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User CreateUser(User user);

        User DeleteUser(User userId);
    }
}
