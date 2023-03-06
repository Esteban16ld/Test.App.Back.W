using Microsoft.EntityFrameworkCore;
using Test.App.Back.W.Data.Configurations;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<RidersModel> Riders { get; set; }
        public DbSet<DriversModel> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DriversConfiguration());
            builder.ApplyConfiguration(new RidersConfiguration());
        }

    }
}
