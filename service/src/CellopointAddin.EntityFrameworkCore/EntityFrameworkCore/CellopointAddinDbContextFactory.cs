using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CellopointAddin.Configuration;
using CellopointAddin.Web;

namespace CellopointAddin.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CellopointAddinDbContextFactory : IDesignTimeDbContextFactory<CellopointAddinDbContext>
    {
        public CellopointAddinDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CellopointAddinDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CellopointAddinDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CellopointAddinConsts.ConnectionStringName));

            return new CellopointAddinDbContext(builder.Options);
        }
    }
}
