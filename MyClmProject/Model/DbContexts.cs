using Microsoft.EntityFrameworkCore;

namespace MyClmProject.Model
{
    public class DbContexts:DbContext
    {
        public DbContexts()
        {

        }
        public DbContexts(DbContextOptions<DbContexts> options) : base(options)
        {

        }
        public virtual DbSet<Registration> AddProductAsync { get; set; }

        public virtual DbSet<SubPart> SubParts { get; set; }    
    }
}
