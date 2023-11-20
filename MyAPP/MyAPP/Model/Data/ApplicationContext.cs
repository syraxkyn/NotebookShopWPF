using Microsoft.EntityFrameworkCore;

namespace MyAPP.Model.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Notebook>? Notebooks { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Image>? Images { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Support>? SupportList { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ManageAppDBLAST1;Trusted_Connection=True;");
        }
    }
}
