using System;
using Volo.Abp.Application.Dtos;

namespace ToDo.ToDo
{
    public class TodoTaskDTO : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
    }

}
