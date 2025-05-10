using Volo.Abp.Modularity;

namespace ToDo;

[DependsOn(
    typeof(ToDoDomainModule),
    typeof(ToDoTestBaseModule)
)]
public class ToDoDomainTestModule : AbpModule
{

}
