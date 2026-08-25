using System.Threading.Tasks;

namespace FiscalFlow.Data;

public interface IFiscalFlowDbSchemaMigrator
{
    Task MigrateAsync();
}
