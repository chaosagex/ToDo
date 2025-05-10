using Volo.Abp.Domain.Entities.Events;

namespace ToDo.ToDo
{
    public class TodoCompletedEvent : EntityEventData<ToDoTask>
    {
        public ToDoTask Task { get; set; }
        public TodoCompletedEvent(ToDoTask entity) : base(entity)
        {
            Task = entity;
        }
    }
}
