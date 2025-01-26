using System.Collections.Generic;
using Smartstore.Accounting.Models;

namespace Smartstore.Accounting.Services
{
    public interface IAccountingService
    {
        void AddEntry(AccountingEntry entry);
        IEnumerable<AccountingEntry> GetEntries();
    }
}
}