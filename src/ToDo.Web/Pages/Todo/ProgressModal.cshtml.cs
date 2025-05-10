using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ToDo.ToDo;

namespace ToDo.Web.Pages.Todo
{
    public class ProgressModalModel : ToDoPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        [BindProperty]
        public Status Status { get; set; }

        private readonly IToDoTaskAppService _TaskService;

        public ProgressModalModel(IToDoTaskAppService TaskService)
        {
            _TaskService = TaskService;
        }

        public async Task OnGet()
        {
            var t = await _TaskService.GetAsync(Id);
            Status = t.Status;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var ToDoTask = await _TaskService.GetAsync(Id);
            if (ToDoTask == null)
            {
                return NotFound();
            }

            await _TaskService.UpdateStatus(Id, Status);
            return NoContent();
        }
    }
}
