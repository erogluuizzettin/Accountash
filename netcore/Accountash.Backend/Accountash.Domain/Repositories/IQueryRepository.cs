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
        IQueryable<TEntity> GetAll(bool isTracking = true);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool isTracking = true);
        Task<TEntity> GetById(string id, bool isTracking = true); // burda compile query kullandık, bunlar cancellationtoken almazlar
        Task<TEntity> GetFirstByExpression(Expression<Func<TEntity, bool>> expression, bool isTracking = true); // burda compile query kullandık, bunlar cancellationtoken almazlar
        Task<TEntity> GetFirst(bool isTracking = true); // burda compile query kullandık, bunlar cancellationtoken almazlar
    }
}
