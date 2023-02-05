using Accountash.Domain.Abstraction;
using Accountash.Domain.Repositories;
using Accountash.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Accountash.Persistance.Repositories
{
    public class CommandRepository<TEntity> : ICommandRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        private static readonly Func<CompanyDbContext, string, Task<TEntity>> GetByIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id) => context.Set<TEntity>().FirstOrDefault(x => x.Id == id));

        private CompanyDbContext _context;
        public DbSet<TEntity> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
            Entity = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await Entity.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await Entity.AddRangeAsync(entities);
        }

        public void Remove(TEntity entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            TEntity entity = await GetByIdCompiled(_context, id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Entity.RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            Entity.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            Entity.UpdateRange(entities);
        }
    }
}
