using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ToDo.ToDo;

namespace ToDo.Web.Pages.Todo
{
    public class EditModalModel : ToDoPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        [BindProperty]
        public TodoTaskCreateUpdateDTO ToDoTask { get; set; }

        private readonly IToDoTaskAppService _TaskService;

        public EditModalModel(IToDoTaskAppService TaskService)
        {
            _TaskService = TaskService;
        }

        public async Task OnGet()
        {
            var t = await _TaskService.GetAsync(Id);
            ToDoTask = ObjectMapper.Map<TodoTaskDTO, TodoTaskCreateUpdateDTO>(t);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
                await _TaskService.UpdateAsync(Id, ToDoTask);
            return NoContent();
        }
    }
}
