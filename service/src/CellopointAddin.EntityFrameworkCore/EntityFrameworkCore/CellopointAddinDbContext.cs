using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CellopointAddin.Authorization.Roles;
using CellopointAddin.Authorization.Users;
using CellopointAddin.MultiTenancy;

namespace CellopointAddin.EntityFrameworkCore
{
    public class CellopointAddinDbContext : AbpZeroDbContext<Tenant, Role, User, CellopointAddinDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CellopointAddinDbContext(DbContextOptions<CellopointAddinDbContext> options)
            : base(options)
        {
        }
    }
}
