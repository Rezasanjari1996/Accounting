using Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.DBConfigurations
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable("Expenses", "Cor");
            builder
      .HasOne<Expense>(s => s.Parent)
      .WithMany(g => g.Expenses)
      .HasForeignKey(s => s.ExpenseId).IsRequired(false);

        }
    }
}
