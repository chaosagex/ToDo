using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
namespace ToDo.ToDo
{
    public class TodoTaskCompletedEventHandler : ILocalEventHandler<TodoCompletedEvent>, ITransientDependency
    {
        public Task HandleEventAsync(TodoCompletedEvent eventData)
        {

            Console.WriteLine($"Todo task {eventData.Entity.Id}\n completed: {eventData.Entity.Title}");
            return Task.CompletedTask;
        }
    }

}
