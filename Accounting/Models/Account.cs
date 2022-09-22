namespace Accounting.Models
{
    public class Account:Entity
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string AccountNumber { get; set; }
        public Double Amount { get; set; }
        public string Desc { get; set; }

    }
}
