using Xunit;

namespace ToDo.EntityFrameworkCore;

[CollectionDefinition(ToDoTestConsts.CollectionDefinitionName)]
public class ToDoEntityFrameworkCoreCollection : ICollectionFixture<ToDoEntityFrameworkCoreFixture>
{

}
