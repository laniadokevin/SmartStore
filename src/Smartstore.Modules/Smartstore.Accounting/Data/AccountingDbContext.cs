using Microsoft.EntityFrameworkCore;
using Smartstore.Core.Data;
using Smartstore.Accounting.Models;

namespace Smartstore.Accounting.Data
{
    public class AccountingDbContext : SmartDbContext
    {
        public AccountingDbContext(DbContextOptions<SmartDbContext> options)
            : base(options)
        {
        }

        public DbSet<AccountingEntry> AccountingEntries { get; set; }
    }
}
