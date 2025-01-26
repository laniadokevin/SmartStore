using System;

namespace Smartstore.Accounting.Models
{
    public class AccountingEntry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CustomerId { get; set; }
    }
}
