using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ToDo.ToDo
{
    public class ToDoTask : AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        //id createdate and Modified date is added by default by abp
        public void SetStatus(Status status)
        {
            Status = status;
            if (status == Status.Completed)
            {
                AddLocalEvent(new TodoCompletedEvent(this));
            }
        }
    }
}
