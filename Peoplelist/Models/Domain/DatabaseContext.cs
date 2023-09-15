using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Peoplelist.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
    }
}