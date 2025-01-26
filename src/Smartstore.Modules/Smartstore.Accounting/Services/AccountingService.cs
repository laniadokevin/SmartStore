using System.Collections.Generic;
using System.Linq;
using Smartstore.Accounting.Data;
using Smartstore.Accounting.Models;

namespace Smartstore.Accounting.Services
{
    public class AccountingService : IAccountingService
    {
        private readonly AccountingDbContext _dbContext;

        public AccountingService(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEntry(AccountingEntry entry)
        {
            _dbContext.AccountingEntries.Add(entry);
            _dbContext.SaveChanges();
        }

        public IEnumerable<AccountingEntry> GetEntries()
        {
            return _dbContext.AccountingEntries.ToList();
        }
    }
}
{
    _dbContext.AccountingEntries.Add(entry);
                _dbContext.SaveChanges();
            }

            public IEnumerable<AccountingEntry> GetEntries()
            {
                return _dbContext.AccountingEntries.ToList();
            }
        }
    }

}
