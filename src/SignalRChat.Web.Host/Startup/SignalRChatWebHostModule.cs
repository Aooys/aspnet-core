using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SignalRChat.Configuration;

namespace SignalRChat.Web.Host.Startup
{
    [DependsOn(
       typeof(SignalRChatWebCoreModule))]
    public class SignalRChatWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SignalRChatWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SignalRChatWebHostModule).GetAssembly());
        }
    }
}
