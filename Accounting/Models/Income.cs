namespace Accounting.Models
{
    public class Income:Entity  
    {
        public string Name { get; set; }
        public int? IncomeId { get; set; }
        public Income Parent { get; set; }
        public virtual List<Income> Incomes { get; set; }
    }
}
