using Accountash.Domain.Abstraction;
using Accountash.Domain.Repositories;
using Accountash.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;

namespace Accountash.Persistance.Repositories
{
    public class QueryRepository<TEntity> : IQueryRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        private static readonly Func<CompanyDbContext, string, Task<TEntity>> GetByIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id) => context.Set<TEntity>().FirstOrDefault(x => x.Id == id));

        private static readonly Func<CompanyDbContext, Task<TEntity>> GetFirstCompiled = EF.CompileAsyncQuery((CompanyDbContext context) => context.Set<TEntity>().FirstOrDefault());

        private static readonly Func<CompanyDbContext, Expression<Func<TEntity, bool>>, Task<TEntity>> GetFirsByExpressionCompiled = EF.CompileAsyncQuery((CompanyDbContext context, Expression<Func<TEntity, bool>> expression) => context.Set<TEntity>().FirstOrDefault(expression));

        private CompanyDbContext _context;
        public DbSet<TEntity> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
            Entity = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<TEntity> GetById(string id)
        {
            return await GetByIdCompiled(_context, id);
        }

        public async Task<TEntity> GetFirst()
        {
            return await GetFirstCompiled(_context);
        }

        public async Task<TEntity> GetFirstByExpression(Expression<Func<TEntity, bool>> expression)
        {
            return await GetFirsByExpressionCompiled(_context, expression);
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}
