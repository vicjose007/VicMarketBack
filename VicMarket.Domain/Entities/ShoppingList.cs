using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntity;

namespace VicMarket.Domain.Entities
{
    public class ShoppingList : BaseEntity
    {
        //Relacion Uno a Mucho

        public User User { get; set; }

        public int UserId { get; set; }

        //Relacion Uno a Mucho

        public Brand Brand { get; set; }

        public int BrandId { get; set; }

        //Relacion Uno a Mucho

        public Market Market { get; set; }

        public int MarketId { get; set; }

        //Relacion Uno a Mucho

        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}
