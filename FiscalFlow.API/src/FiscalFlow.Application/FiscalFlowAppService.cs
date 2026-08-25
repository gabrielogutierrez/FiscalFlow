using FiscalFlow.Localization;
using Volo.Abp.Application.Services;

namespace FiscalFlow;

/* Inherit your application services from this class.
 */
public abstract class FiscalFlowAppService : ApplicationService
{
    protected FiscalFlowAppService()
    {
        LocalizationResource = typeof(FiscalFlowResource);
    }
}
