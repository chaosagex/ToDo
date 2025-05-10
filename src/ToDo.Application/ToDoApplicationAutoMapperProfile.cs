using AutoMapper;
using ToDo.ToDo;

namespace ToDo;

public class ToDoApplicationAutoMapperProfile : Profile
{
    public ToDoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<ToDoTask, TodoTaskDTO>();
        CreateMap<TodoTaskCreateUpdateDTO, ToDoTask>();
    }
}
