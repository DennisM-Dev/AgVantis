using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AgVantis.Configuration.Dto;

namespace AgVantis.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgVantisAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
