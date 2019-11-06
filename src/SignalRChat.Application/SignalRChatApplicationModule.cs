using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SignalRChat.Authorization;

namespace SignalRChat
{
    [DependsOn(
        typeof(SignalRChatCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SignalRChatApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SignalRChatAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SignalRChatApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
