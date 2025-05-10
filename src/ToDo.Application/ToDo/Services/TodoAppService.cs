using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace ToDo.ToDo.Services
{
    public class TodoAppService :
        CrudAppService<
            ToDoTask
            , TodoTaskDTO
            , Guid
            , TaskFilterAndSortDto
            , TodoTaskCreateUpdateDTO>
        , IToDoTaskAppService
    {

        public TodoAppService(IRepository<ToDoTask, Guid> repository) : base(repository)
        {
            GetPolicyName = ToDoPermissions.ToDo.Default;
            GetListPolicyName = ToDoPermissions.ToDo.Default;
            CreatePolicyName = ToDoPermissions.ToDo.Create;
            UpdatePolicyName = ToDoPermissions.ToDo.Edit;
            DeletePolicyName = ToDoPermissions.ToDo.Delete;
        }
        public async override Task<PagedResultDto<TodoTaskDTO>> GetListAsync(TaskFilterAndSortDto input)
        {
            await CheckGetListPolicyAsync();

            var query = await CreateFilteredQueryAsync(input);
            query = query
                .WhereIf(input.Status != null, q => q.Status == input.Status)
                .WhereIf(input.priority != null, q => q.Priority == input.priority)
                .WhereIf(input.From != null, q => q.DueDate >= input.From)
                .WhereIf(input.To != null, q => q.DueDate <= input.To);
            var totalCount = await AsyncExecuter.CountAsync(query);

            List<ToDoTask>? entities = new List<ToDoTask>();
            List<TodoTaskDTO>? entityDtos = new List<TodoTaskDTO>();

            if (totalCount > 0)
            {
                query = ApplySorting(query, input);
                query = ApplyPaging(query, input);

                entities = await AsyncExecuter.ToListAsync(query);
                entityDtos = await MapToGetListOutputDtosAsync(entities);
            }

            return new PagedResultDto<TodoTaskDTO>(
                totalCount,
                entityDtos
            );
        }
        public async Task UpdateStatus(Guid id, Status status)
        {
            var task = await Repository.GetAsync(id);
            task.SetStatus(status);
            await Repository.UpdateAsync(task);
        }
    }

}
