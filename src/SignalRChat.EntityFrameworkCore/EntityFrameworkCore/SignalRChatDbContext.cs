using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SignalRChat.Authorization.Roles;
using SignalRChat.Authorization.Users;
using SignalRChat.MultiTenancy;

namespace SignalRChat.EntityFrameworkCore
{
    public class SignalRChatDbContext : AbpZeroDbContext<Tenant, Role, User, SignalRChatDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SignalRChatDbContext(DbContextOptions<SignalRChatDbContext> options)
            : base(options)
        {
        }
    }
}
