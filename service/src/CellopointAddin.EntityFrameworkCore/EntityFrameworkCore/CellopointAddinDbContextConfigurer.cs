using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CellopointAddin.EntityFrameworkCore
{
    public static class CellopointAddinDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CellopointAddinDbContext> builder, string connectionString)
        {
            builder.UseSqlite(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CellopointAddinDbContext> builder, DbConnection connection)
        {
            builder.UseSqlite(connection);
        }
    }
}
