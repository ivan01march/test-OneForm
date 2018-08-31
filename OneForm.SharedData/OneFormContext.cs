using Microsoft.EntityFrameworkCore;
using OneForm.SharedData.Entities;

namespace OneForm.SharedData
{
    public class OneFormContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<User> Users { get; set; }

        public OneFormContext()
        {
        }

        public OneFormContext(DbContextOptions<OneFormContext> options)
            : base(options)
        {
        }
    }
}