using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SignalRChat.Roles.Dto;
using SignalRChat.Users.Dto;

namespace SignalRChat.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
