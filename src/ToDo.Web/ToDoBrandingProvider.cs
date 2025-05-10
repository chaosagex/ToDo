using Microsoft.Extensions.Localization;
using ToDo.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ToDo.Web;

[Dependency(ReplaceServices = true)]
public class ToDoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ToDoResource> _localizer;

    public ToDoBrandingProvider(IStringLocalizer<ToDoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
