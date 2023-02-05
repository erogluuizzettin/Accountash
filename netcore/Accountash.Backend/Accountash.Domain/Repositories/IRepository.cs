using Accountash.Domain.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Domain.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        void SetDbContextInstance(DbContext context);
        DbSet<TEntity> Entity { get; set; }
    }
}
