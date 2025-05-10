using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Localization;
using Volo.Abp.Application.Services;

namespace ToDo;

/* Inherit your application services from this class.
 */
public abstract class ToDoAppService : ApplicationService
{
    protected ToDoAppService()
    {
        LocalizationResource = typeof(ToDoResource);
    }
}
