using System.Threading.Tasks;
using Abp.Application.Services;
using SignalRChat.Authorization.Accounts.Dto;

namespace SignalRChat.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
