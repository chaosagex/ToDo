using ToDo.Samples;
using Xunit;

namespace ToDo.EntityFrameworkCore.Applications;

[Collection(ToDoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ToDoEntityFrameworkCoreTestModule>
{

}
