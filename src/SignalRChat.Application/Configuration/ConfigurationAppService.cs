using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SignalRChat.Configuration.Dto;

namespace SignalRChat.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SignalRChatAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
