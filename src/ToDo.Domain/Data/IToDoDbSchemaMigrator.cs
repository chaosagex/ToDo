using System.Threading.Tasks;

namespace ToDo.Data;

public interface IToDoDbSchemaMigrator
{
    Task MigrateAsync();
}
