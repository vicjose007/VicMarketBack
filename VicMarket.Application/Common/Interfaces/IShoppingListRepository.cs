﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IShoppingListRepository
    {
        List<ShoppingList> GetAllShoppingLists();

        ShoppingList CreateShoppingList(ShoppingList shoppingList);

        ShoppingList DeleteShoppingList(ShoppingList shoppingListId);
    }
}
