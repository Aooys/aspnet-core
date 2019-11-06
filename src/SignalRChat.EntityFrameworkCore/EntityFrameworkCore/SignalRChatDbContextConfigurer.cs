using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SignalRChat.EntityFrameworkCore
{
    public static class SignalRChatDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SignalRChatDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SignalRChatDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
