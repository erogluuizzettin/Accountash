using Accountash.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Domain.Repositories
{
    public interface ICommandRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        Task RemoveById(string id); // burda compile query kullandık, bunlar cancellationtoken almazlar
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
