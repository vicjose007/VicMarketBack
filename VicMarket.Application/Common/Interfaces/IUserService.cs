using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IUserService : IEntityCRUDService<User, UserDto>
    {
        List<User> GetAllUsers();

        User CreateUser(User user);

        User DeleteUser(User userId);
    }
}
