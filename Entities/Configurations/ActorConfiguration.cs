using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAPI.Entities.Configurations;

public class ActorConfiguration: IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.Property(a => a.Name).IsRequired().HasMaxLength(120);
        builder.Property(a => a.Salary).HasColumnType("decimal(18,2)");
    }
}
