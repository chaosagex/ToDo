using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.ToDo
{
    public class TodoTaskCreateUpdateDTO
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]

        public DateTime? DueDate { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public Priority Priority { get; set; }
    }

}
