using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAPI.Entities.Configurations;

public class MovieConfiguration :
    IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> modelBuilder)
    {
        modelBuilder.Property(m => m.Title)
           .IsRequired().HasMaxLength(300);
        modelBuilder.Property(m => m.ReleaseDate)
            .IsRequired()
            .HasColumnType("date");


    }
}
