using Accountash.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Domain.Repositories
{
    public interface IQueryRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetById(string id);
        Task<TEntity> GetFirstByExpression(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetFirst();
    }
}
