using Accountash.Domain.Abstraction;
using Accountash.Domain.AppEntities;
using Accountash.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Accountash.Persistance.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(x => x.CreateDate).CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(x => x.UpdateDate).CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<AppDbContext>();
                builder.UseSqlServer("Data Source=DESKTOP-870I75N\\SQLEXPRESS;" +
                    "Initial Catalog=AccountashDb;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=30;" +
                    "Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False");
                return new AppDbContext(builder.Options);
            }
        }
    }
}
