using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ToDo.Pages;

public class Index_Tests : ToDoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
