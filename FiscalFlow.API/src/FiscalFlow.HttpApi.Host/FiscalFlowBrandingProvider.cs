using Microsoft.Extensions.Localization;
using FiscalFlow.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FiscalFlow;

[Dependency(ReplaceServices = true)]
public class FiscalFlowBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FiscalFlowResource> _localizer;

    public FiscalFlowBrandingProvider(IStringLocalizer<FiscalFlowResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
