using System.Threading.Tasks;
using Abp.Application.Services;
using SignalRChat.Sessions.Dto;

namespace SignalRChat.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
