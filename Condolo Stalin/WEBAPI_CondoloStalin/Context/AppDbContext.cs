using Microsoft.EntityFrameworkCore;
using WEBAPI_CondoloStalin.Models;

namespace WEBAPI_CondoloStalin.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
            {
            }
        public DbSet<Cliente> cliente { get; set; }
    }
}
