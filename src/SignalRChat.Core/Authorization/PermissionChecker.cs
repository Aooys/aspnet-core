using Abp.Authorization;
using SignalRChat.Authorization.Roles;
using SignalRChat.Authorization.Users;

namespace SignalRChat.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
