using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FiscalFlow.Data;

/* This is used if database provider does't define
 * IFiscalFlowDbSchemaMigrator implementation.
 */
public class NullFiscalFlowDbSchemaMigrator : IFiscalFlowDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
