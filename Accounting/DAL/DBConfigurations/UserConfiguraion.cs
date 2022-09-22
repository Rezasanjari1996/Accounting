using Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.DBConfigurations
{
    public class UserConfiguraion : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users","Cor");
            builder.Property(x=>x.Password).HasMaxLength(128);
            builder.Property<string>(x=>x.Email).HasMaxLength(128).IsRequired(false).IsUnicode(true);
        
            builder.Property(x=>x.Mobile).HasMaxLength(11).IsRequired(false).IsUnicode(true);
            builder.Property(x=>x.UserName).IsUnicode(true);
        }
    }
}
