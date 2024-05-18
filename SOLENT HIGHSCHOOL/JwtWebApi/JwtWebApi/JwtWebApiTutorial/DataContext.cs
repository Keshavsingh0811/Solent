using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JwtWebApiTutorial
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
