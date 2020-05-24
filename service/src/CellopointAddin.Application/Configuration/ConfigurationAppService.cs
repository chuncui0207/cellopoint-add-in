using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CellopointAddin.Configuration.Dto;

namespace CellopointAddin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CellopointAddinAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
