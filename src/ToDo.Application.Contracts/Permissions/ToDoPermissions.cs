namespace ToDo.Permissions;

public static class ToDoPermissions
{
    public const string GroupName = "ToDo";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class ToDo
    {
        public const string Default = GroupName + ".Tasks";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Progress = Default + ".Progress";
    }
}
