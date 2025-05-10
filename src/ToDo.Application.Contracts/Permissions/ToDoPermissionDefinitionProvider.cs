using ToDo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ToDo.Permissions;

public class ToDoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ToDoPermissions.MyPermission1, L("Permission:MyPermission1"));
        var bookStoreGroup = context.AddGroup(ToDoPermissions.GroupName, L("Permission:ToDo"));

        var booksPermission = bookStoreGroup.AddPermission(ToDoPermissions.ToDo.Default, L("Permission:ToDoTasks"));
        booksPermission.AddChild(ToDoPermissions.ToDo.Create, L("Permission:Todo.Create"));
        booksPermission.AddChild(ToDoPermissions.ToDo.Edit, L("Permission:Todo.Edit"));
        booksPermission.AddChild(ToDoPermissions.ToDo.Delete, L("Permission:Todo.Delete"));
        booksPermission.AddChild(ToDoPermissions.ToDo.Progress, L("Permission:Todo.Progress"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ToDoResource>(name);
    }
}
