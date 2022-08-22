using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntity;

namespace VicMarket.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }

        public float Price { get; set; }

        //Relacion Uno a Muchos

        public List<ShoppingList> ShoppingList { get; set; }
    }
}
