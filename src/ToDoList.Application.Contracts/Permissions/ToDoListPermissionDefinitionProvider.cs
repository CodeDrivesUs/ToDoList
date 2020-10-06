using ToDoList.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ToDoList.Permissions
{
    public class ToDoListPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ToDoListPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ToDoListPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ToDoListResource>(name);
        }
    }
}
