using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Smartstore.Accounting.Data;
using Smartstore.Accounting.Services;
using Smartstore.Engine;
using Smartstore.Engine.Builders;

namespace Smartstore.Accounting
{
    internal class Startup : StarterBase
    {
        public override bool Matches(IApplicationContext appContext)
            => appContext.IsInstalled;

        public override void ConfigureServices(IServiceCollection services, IApplicationContext appContext)
        {
            services.AddDbContext<AccountingDbContext>(options =>
            {
                options.UseSqlServer(appContext.DataSettings.ConnectionString, sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(AccountingDbContext).Assembly.FullName);
                });
            });

            services.AddScoped<IAccountingService, AccountingService>();
        }

        public override void MapRoutes(EndpointRoutingBuilder builder)
        {
            builder.MapControllerRoute(
                name: "Accounting",
                pattern: "admin/accounting/{action=Index}/{id?}",
                defaults: new { controller = "Accounting", area = "Admin" });
        }
    }
}
