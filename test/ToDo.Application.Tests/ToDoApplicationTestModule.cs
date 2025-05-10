using Volo.Abp.Modularity;

namespace ToDo;

[DependsOn(
    typeof(ToDoApplicationModule),
    typeof(ToDoDomainTestModule)
)]
public class ToDoApplicationTestModule : AbpModule
{

}
