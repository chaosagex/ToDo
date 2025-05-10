using Volo.Abp.Modularity;

namespace ToDo;

/* Inherit from this class for your domain layer tests. */
public abstract class ToDoDomainTestBase<TStartupModule> : ToDoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
