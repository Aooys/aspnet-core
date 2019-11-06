using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SignalRChat.Controllers
{
    public abstract class SignalRChatControllerBase: AbpController
    {
        protected SignalRChatControllerBase()
        {
            LocalizationSourceName = SignalRChatConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
