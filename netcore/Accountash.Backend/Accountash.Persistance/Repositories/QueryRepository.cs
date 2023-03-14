using Accountash.Domain.Abstraction;
using Accountash.Domain.Repositories;
using Accountash.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Accountash.Persistance.Repositories;

public class QueryRepository<TEntity> : IQueryRepository<TEntity>
    where TEntity : BaseEntity, new()
{
    private static readonly Func<CompanyDbContext, string, bool, Task<TEntity>> GetByIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id, bool isTracking) => 
        isTracking ? context.Set<TEntity>().FirstOrDefault(x => x.Id == id) : context.Set<TEntity>().AsNoTracking().FirstOrDefault(x => x.Id == id));

    private static readonly Func<CompanyDbContext, bool, Task<TEntity>> GetFirstCompiled = EF.CompileAsyncQuery((CompanyDbContext context, bool isTracking) => 
        isTracking ? context.Set<TEntity>().FirstOrDefault() : context.Set<TEntity>().AsNoTracking().FirstOrDefault());

    private static readonly Func<CompanyDbContext, Expression<Func<TEntity, bool>>, bool, Task<TEntity>> GetFirsByExpressionCompiled = EF.CompileAsyncQuery((CompanyDbContext context, Expression<Func<TEntity, bool>> expression, bool isTracking) =>
        isTracking ? context.Set<TEntity>().FirstOrDefault(expression) : context.Set<TEntity>().AsNoTracking().FirstOrDefault(expression));

    private CompanyDbContext _context;
    public DbSet<TEntity> Entity { get; set; }

    public void SetDbContextInstance(DbContext context)
    {
        _context = (CompanyDbContext)context;
        Entity = _context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll(bool isTracking = true)
    {
        var result = Entity.AsQueryable();
        if (!isTracking) result.AsNoTracking();
        return result;
    }

    public async Task<TEntity> GetById(string id, bool isTracking = true)
    {
        return await GetByIdCompiled(_context, id, isTracking);
    }

    public async Task<TEntity> GetFirst(bool isTracking = true)
    {
        return await GetFirstCompiled(_context, isTracking);
    }

    public async Task<TEntity> GetFirstByExpression(Expression<Func<TEntity, bool>> expression, bool isTracking = true)
    {
        return await GetFirsByExpressionCompiled(_context, expression, isTracking);
    }

    public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool isTracking = true)
    {
        var result = Entity.Where(expression);
        if (!isTracking) result.AsNoTracking();
        return result;
    }
}

