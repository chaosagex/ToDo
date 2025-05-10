using ToDo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ToDo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToDoEntityFrameworkCoreModule),
    typeof(ToDoApplicationContractsModule)
    )]
public class ToDoDbMigratorModule : AbpModule
{
}
