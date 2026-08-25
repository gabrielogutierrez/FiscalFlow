using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FiscalFlow.Data;
using Volo.Abp.DependencyInjection;

namespace FiscalFlow.EntityFrameworkCore;

public class EntityFrameworkCoreFiscalFlowDbSchemaMigrator
    : IFiscalFlowDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFiscalFlowDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FiscalFlowDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FiscalFlowDbContext>()
            .Database
            .MigrateAsync();
    }
}
