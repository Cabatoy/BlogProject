using BlogSolution.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogSolution.Data.Concrete.EntityFramework.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(270).IsRequired(true);
            builder.Property(x => x.CreatedByName).HasMaxLength(70).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(70);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(250);



            builder.ToTable("Categories");
            builder.HasData(new Category
            {
                Id = 1,
                Name = "Ilk Kategori",
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Admin",
                ModifiedDate = DateTime.Now,
                CreatedByName = "Admin",
                Description = "Ilk Kategori Test",
                Note = "Test"
            },
                new Category
                {
                    Id = 2,
                    Name = "Ikinci Kategori",
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    ModifiedByName = "Admin",
                    ModifiedDate = DateTime.Now,
                    CreatedByName = "Admin",
                    Description = "Ikinci Kategori Test",
                    Note = "Test"
                });
        }
    }
}
