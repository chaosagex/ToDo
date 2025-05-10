using ToDo.Samples;
using Xunit;

namespace ToDo.EntityFrameworkCore.Domains;

[Collection(ToDoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ToDoEntityFrameworkCoreTestModule>
{

}
