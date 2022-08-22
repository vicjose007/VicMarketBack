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
    public class ShoppingListRepository : IShoppingListRepository
    {
        public static List<ShoppingList> shoppingLists = new List<ShoppingList>()
        {

        };
        private readonly VicMarketDbContext _shoppingListDbContext;

        public ShoppingListRepository(VicMarketDbContext shoppingListDbContext)
        {
            _shoppingListDbContext = shoppingListDbContext;
        }
        public ShoppingList CreateShoppingList(ShoppingList shoppingList)
        {
            _shoppingListDbContext.ShoppingLists.Add(shoppingList);
            _shoppingListDbContext.SaveChanges();
            return shoppingList;
        }

        public ShoppingList DeleteShoppingList(ShoppingList shoppingList)
        {
            _shoppingListDbContext.ShoppingLists.Remove(shoppingList);
            _shoppingListDbContext.SaveChanges();
            return null;
        }

        public List<ShoppingList> GetAllShoppingLists()
        {
            return _shoppingListDbContext.ShoppingLists.ToList();
        }
    }
}
