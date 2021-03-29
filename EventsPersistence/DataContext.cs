using Microsoft.EntityFrameworkCore;
using EventsDomain;

namespace EventsPersistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Activity> Activities {get;set;}

    }
}
