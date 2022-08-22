using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicMarket.Domain.BaseModel.BaseEntity;
using VicMarket.Domain.BaseModel.BaseEntityDto;

namespace VicMarket.Application.Common.Interfaces
{
    public interface IEntityCRUDService<TEntity, TEntityDto> where TEntity : class, IBaseEntity
       where TEntityDto : class, IBaseEntityDto
    {
        Task<TEntityDto> GetById(int id);
        Task<TEntityDto> Save(TEntityDto entityDto);
        Task<TEntityDto> Update(int id, TEntityDto entityDto);
        Task<TEntityDto> Delete(int id);
        IQueryable<TEntity> Get();
    }
}
