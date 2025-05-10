using System;
using Volo.Abp.Application.Dtos;

namespace ToDo.ToDo
{
    public class TaskFilterAndSortDto : PagedAndSortedResultRequestDto
    {
        public Status? Status { get; set; }
        public Priority? priority { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
