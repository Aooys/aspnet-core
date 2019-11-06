using Microsoft.AspNetCore.Antiforgery;
using SignalRChat.Controllers;

namespace SignalRChat.Web.Host.Controllers
{
    public class AntiForgeryController : SignalRChatControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
