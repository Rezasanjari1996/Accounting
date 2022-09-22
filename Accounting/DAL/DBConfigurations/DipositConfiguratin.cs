using Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.DBConfigurations
{
    public class DipositConfiguratin : IEntityTypeConfiguration<Diposit>
    {
        public void Configure(EntityTypeBuilder<Diposit> builder)
        {
            builder.ToTable("Diposits", "Cor");
            builder.HasOne(x => x.Account).WithMany().HasForeignKey(x => x.AccountId);
            builder.HasOne(x => x.Income).WithMany().HasForeignKey(x => x.IncomeId);
        }
    }
}
