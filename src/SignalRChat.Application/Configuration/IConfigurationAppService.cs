using System.Threading.Tasks;
using SignalRChat.Configuration.Dto;

namespace SignalRChat.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
