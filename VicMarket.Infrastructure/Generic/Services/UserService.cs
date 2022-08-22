using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Common.Interfaces;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;
using VicMarket.Infrastructure.Contexts.VicMarket;
using VicMarket.Infrastructure.UnitOfWorks;

namespace VicMarket.Infrastructure.Generic.Services
{
    public class UserService : EntityCRUDService<User, UserDto>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUnitOfWork<IVicMarketDbContext> uow, IUserRepository userRepository): base(mapper, uow)
        {
            _userRepository = userRepository;
        }
        public User CreateUser(User user)
        {
            _userRepository.CreateUser(user);
            return user;
        }

        public User DeleteUser(User user)
        {
            _userRepository.DeleteUser(user);
            return user;
        }

        public List<User> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return users;
        }
    }
}
