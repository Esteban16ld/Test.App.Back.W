using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Data.Configurations
{
    public class DriversConfiguration : IEntityTypeConfiguration<DriversModel>
    {
        public void Configure(EntityTypeBuilder<DriversModel> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Identification).IsRequired();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.LastName).IsRequired();
            builder.Property(c => c.IsOccupied).IsRequired();
        }
    }
}
