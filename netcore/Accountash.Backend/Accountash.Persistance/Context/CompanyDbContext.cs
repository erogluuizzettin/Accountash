using Accountash.Domain.Abstraction;
using Accountash.Domain.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string _connectionString;

        public CompanyDbContext(Company company = null)
        {
            if (company == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(company.DbUserId)) 
            { 
                _connectionString= $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DatabaseName};" +
                    $"Integrated Security=True;" +
                    $"Connect Timeout=30;" +
                    $"Encrypt=False;" +
                    $"TrustServerCertificate=False;" +
                    $"ApplicationIntent=ReadWrite;" +
                    $"MultiSubnetFailover=False";
            } 
            else 
            {
                _connectionString = $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DatabaseName};" +
                    $"User Id={company.DbUserId};" +
                    $"Password={company.DbPassword};" +
                    $"Integrated Security=True;" +
                    $"Connect Timeout=30;" +
                    $"Encrypt=False;" +
                    $"TrustServerCertificate=False;" +
                    $"ApplicationIntent=ReadWrite;" +
                    $"MultiSubnetFailover=False";
            }  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly); // burada dbsetleri tek tek eklememize gerek bırakmayacak.

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext(null);
            }
        }

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
    }
}
