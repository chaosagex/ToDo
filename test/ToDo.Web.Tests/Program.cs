using Microsoft.AspNetCore.Builder;
using ToDo;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ToDoWebTestModule>();

public partial class Program
{
}
