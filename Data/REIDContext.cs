using Microsoft.EntityFrameworkCore;
using REID.Models;

namespace REID.Data
{
    public class REIDContext : DbContext
    {
        public REIDContext(DbContextOptions<REIDContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
