using Entity_Layer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;



namespace DataAcessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OFFTGKG;database=techcareer;Integrated Security=True;");
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Squad> Squads { get; set; }

        public DbSet<Transport> Transports { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Rating> Ratings { get; set; }


    }
}
