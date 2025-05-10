using AutoMapper;
using ToDo.ToDo;

namespace ToDo.Web;

public class ToDoWebAutoMapperProfile : Profile
{
    public ToDoWebAutoMapperProfile()
    {
        CreateMap<TodoTaskDTO, TodoTaskCreateUpdateDTO>();
        //Define your AutoMapper configuration here for the Web project.
    }
}
