using ToDo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ToDo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ToDoPageModel : AbpPageModel
{
    protected ToDoPageModel()
    {
        LocalizationResourceType = typeof(ToDoResource);
    }
}
