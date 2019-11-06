using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SignalRChat.MultiTenancy.Dto;

namespace SignalRChat.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

