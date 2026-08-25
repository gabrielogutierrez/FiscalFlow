using FiscalFlow.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FiscalFlow.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FiscalFlowController : AbpControllerBase
{
    protected FiscalFlowController()
    {
        LocalizationResource = typeof(FiscalFlowResource);
    }
}
