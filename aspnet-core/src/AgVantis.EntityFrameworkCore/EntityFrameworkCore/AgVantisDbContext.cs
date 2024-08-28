using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AgVantis.Authorization.Roles;
using AgVantis.Authorization.Users;
using AgVantis.MultiTenancy;
using AgVantis.Association;

namespace AgVantis.EntityFrameworkCore
{
    public class AgVantisDbContext : AbpZeroDbContext<Tenant, Role, User, AgVantisDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AgVantisDbContext(DbContextOptions<AgVantisDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Associations> associations { get; set; }
    }
}
