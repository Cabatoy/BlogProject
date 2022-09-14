using BlogSolution.Entities.Concrete;
using BlogSolution.Shared.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogSolution.Data.Concrete.EntityFramework.Mapping
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            builder.Property(x => x.CreatedByName).HasMaxLength(70).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(70);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();

            builder.ToTable("Roles");
            builder.HasData(new Role
            {
                CreatedByName = "Admin",
                CreatedDate = DateTime.Now,
                Description = "Admin Rolu Default Tanimli ve Tum Yetkilere Sahiptir.",
                Id = 1,
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Admin",
                ModifiedDate = DateTime.Now,
                Name = "Admin",
                Note = ""
            });
        }
    }
}
