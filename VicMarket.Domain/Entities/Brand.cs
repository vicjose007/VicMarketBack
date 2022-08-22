using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntity;

namespace VicMarket.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }

        public string Details { get; set; }

        //Relacion Uno a Muchos

        public List<ShoppingList> ShoppingList { get; set; }
    }
}
