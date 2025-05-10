using Volo.Abp.Modularity;

namespace ToDo;

public abstract class ToDoApplicationTestBase<TStartupModule> : ToDoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
