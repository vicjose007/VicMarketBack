using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IShoppingListService : IEntityCRUDService<ShoppingList, ShoppingListDto>
    {
        List<ShoppingList> GetAllShoppingLists();

        ShoppingList CreateShoppingList(ShoppingList shoppingList);

        ShoppingList DeleteShoppingList(ShoppingList shoppingListId);
    }
}
