using Volo.Abp.Settings;

namespace FiscalFlow.Settings;

public class FiscalFlowSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FiscalFlowSettings.MySetting1));
    }
}
