namespace Accounting.Models
{
    public class Diposit:Entity
    {
        public double Amount { get; set; }
        public string Date { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public int IncomeId { get; set; }
        public virtual Income Income { get; set; }
    }
}
