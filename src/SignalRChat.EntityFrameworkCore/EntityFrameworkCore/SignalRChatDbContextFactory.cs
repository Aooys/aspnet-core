using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SignalRChat.Configuration;
using SignalRChat.Web;

namespace SignalRChat.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SignalRChatDbContextFactory : IDesignTimeDbContextFactory<SignalRChatDbContext>
    {
        public SignalRChatDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SignalRChatDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SignalRChatDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SignalRChatConsts.ConnectionStringName));

            return new SignalRChatDbContext(builder.Options);
        }
    }
}
