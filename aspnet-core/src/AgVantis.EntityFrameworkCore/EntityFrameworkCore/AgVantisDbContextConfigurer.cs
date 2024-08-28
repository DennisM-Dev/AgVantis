using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AgVantis.EntityFrameworkCore
{
    public static class AgVantisDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgVantisDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgVantisDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
