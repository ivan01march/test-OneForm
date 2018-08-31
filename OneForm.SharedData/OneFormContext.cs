using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkProvider
{
    public class OneFormContext : DbContext
    {
        public OneFormContext()
        {
        }

        public OneFormContext(DbContextOptions<OneFormContext> options)
            : base(options)
        {
        }
    }
}