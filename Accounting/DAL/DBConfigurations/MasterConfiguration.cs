using Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.DBConfigurations
{
    public class MasterConfiguration : IEntityTypeConfiguration<Master>
    {
        public void Configure(EntityTypeBuilder<Master> builder)
        {
            builder.ToTable("Master", "Cor");
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Account).WithMany().HasForeignKey(x => x.AccountId);
            builder.HasOne(x => x.Expense).WithMany().HasForeignKey(x => x.ExpenseId);
        }
    }
}
