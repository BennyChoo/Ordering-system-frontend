using Microsoft.EntityFrameworkCore;

namespace QFD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        //public virtual DbSet<Menus> Menus { get; set; }

       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }



    }
}
