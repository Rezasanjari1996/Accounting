using Accounting.DAL.DBConfigurations;
using Accounting.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounting.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Master> Masters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguraion).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExpenseConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IncomeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MasterConfiguration).Assembly);
        }
    }
}
