using InternshipTask.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternshipTask.Persistence.Configrations
{
    public class UserConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                .HasMaxLength(254)
                .IsRequired();

            builder.Property(u => u.UserName)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}