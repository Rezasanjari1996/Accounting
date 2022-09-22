namespace Accounting.Models
{
    public class Master:Entity
    {
        public double Amount { get; set; }
        public string Desc { get; set; }
        public string Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ExpenseId { get; set; }
        public virtual Expense Expense { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
