using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ToDo.ToDo
{
    public interface IToDoTaskAppService :
        ICrudAppService<
            TodoTaskDTO,
            Guid,
            TaskFilterAndSortDto,
            TodoTaskCreateUpdateDTO>
    {
        public Task UpdateStatus(Guid id, Status status);
        //public Task<List<TodoTaskDTO>> Filter();

    }
}

