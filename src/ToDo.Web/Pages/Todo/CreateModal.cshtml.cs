using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDo.ToDo;

namespace ToDo.Web.Pages.Todo
{
    public class CreateModalModel : ToDoPageModel
    {
        [BindProperty]
        public TodoTaskCreateUpdateDTO ToDoTask { get; set; }

        private readonly IToDoTaskAppService _TaskService;

        public CreateModalModel(IToDoTaskAppService TaskService)
        {
            _TaskService = TaskService;
        }

        public void OnGet()
        {
            ToDoTask = new TodoTaskCreateUpdateDTO();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _TaskService.CreateAsync(ToDoTask);
            }

            return NoContent();
        }
    }
}
