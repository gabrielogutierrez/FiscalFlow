using FiscalFlow.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace FiscalFlow.Permissions;

public class FiscalFlowPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FiscalFlowPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(FiscalFlowPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FiscalFlowResource>(name);
    }
}
