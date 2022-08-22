using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Application.Dtos;
using VicMarket.Application.Extensions;
using VicMarket.Domain.Entities;

namespace VicMarket.Application.Mappings
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            this._CreateMap_WithConventions_FromAssemblies<User, UserDto>();
            this._CreateMap_WithConventions_FromAssemblies<Brand, BrandDto>();
            this._CreateMap_WithConventions_FromAssemblies<Market, MarketDto>();
            this._CreateMap_WithConventions_FromAssemblies<Product, ProductDto>();
            this._CreateMap_WithConventions_FromAssemblies<ShoppingList, ShoppingListDto>();
        }
    }
}
