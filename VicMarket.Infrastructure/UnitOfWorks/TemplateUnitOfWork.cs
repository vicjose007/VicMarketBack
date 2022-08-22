using VicMarket.Domain.BaseModel.BaseEntity;
using VicMarket.Infrastructure.Contexts.VicMarket;
using VicMarket.Infrastructure.Repositories;

namespace VicMarket.Infrastructure.UnitOfWorks
{
    public class VicMarketUnitOfWork : IUnitOfWork<IVicMarketDbContext>
    {
        public IVicMarketDbContext context { get; set; }
        public readonly IServiceProvider _serviceProvider;

        public VicMarketUnitOfWork(IServiceProvider serviceProvider, IVicMarketDbContext context)
        {
            _serviceProvider = serviceProvider;
            this.context = context;
        }

        public async Task<int> Commit()
        {
            var result = await context.SaveChangesAsync();
            return result;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity
        {
            return (_serviceProvider.GetService(typeof(TEntity)) ?? new BaseRepository<TEntity>(this)) as IRepository<TEntity>;
        }
    }
}
