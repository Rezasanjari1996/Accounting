using Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.DBConfigurations
{
    public class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.ToTable("Incomes", "Cor");

               builder.HasOne<Income>(s => s.Parent)
      .WithMany(g => g.Incomes)
      .HasForeignKey(s => s.IncomeId).IsRequired(false);
        }
    }
}
