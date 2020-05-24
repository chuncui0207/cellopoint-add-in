using System.Threading.Tasks;
using CellopointAddin.Configuration.Dto;

namespace CellopointAddin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
