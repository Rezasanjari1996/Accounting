namespace Accounting.Models
{
    public class Expense:Entity
    {
        public string Name { get; set; }
        public int? ExpenseId { get; set; }
        public Expense Parent { get; set; }
        public virtual List<Expense> Expenses { get; set; }
    }
}
