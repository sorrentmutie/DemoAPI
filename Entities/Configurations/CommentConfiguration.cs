using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAPI.Entities.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(c => c.Text)
            .IsRequired().HasMaxLength(300);
    }
}
