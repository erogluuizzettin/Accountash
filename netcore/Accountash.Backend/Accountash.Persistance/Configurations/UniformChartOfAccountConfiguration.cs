using Accountash.Domain.CompanyEntities;
using Accountash.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accountash.Persistance.Configurations;

public sealed class UniformChartOfAccountConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
{
    public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
    {
        builder.ToTable(TableNames.UniformChartOfAccounts);
        builder.HasKey(x => x.Id);
    }
}
