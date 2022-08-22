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
    public class ShoppingListService : EntityCRUDService<ShoppingList, ShoppingListDto>, IShoppingListService
    {
        private readonly IShoppingListRepository _shoppingListRepository;
        public ShoppingListService(IMapper mapper, IUnitOfWork<IVicMarketDbContext> uow, IShoppingListRepository shoppingListRepository) : base(mapper, uow)
        {
            _shoppingListRepository = shoppingListRepository;
        }
        public ShoppingList CreateShoppingList(ShoppingList shoppingList)
        {
            _shoppingListRepository.CreateShoppingList(shoppingList);
            return shoppingList;
        }

        public ShoppingList DeleteShoppingList(ShoppingList shoppingList)
        {
            _shoppingListRepository.DeleteShoppingList(shoppingList);
            return shoppingList;
        }

        public List<ShoppingList> GetAllShoppingLists()
        {
            var shoppingLists = _shoppingListRepository.GetAllShoppingLists();
            return shoppingLists;
        }
    }
}
