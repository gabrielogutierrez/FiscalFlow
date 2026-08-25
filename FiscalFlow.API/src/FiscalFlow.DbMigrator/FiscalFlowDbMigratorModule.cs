using FiscalFlow.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FiscalFlow.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FiscalFlowEntityFrameworkCoreModule),
    typeof(FiscalFlowApplicationContractsModule)
)]
public class FiscalFlowDbMigratorModule : AbpModule
{
}
