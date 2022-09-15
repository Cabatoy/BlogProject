using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSolution.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogSolution.Data.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Email).IsRequired().HasMaxLength(40);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Email).HasColumnName("USER_EMAIL");

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(150);
            builder.HasIndex(x => x.UserName).IsUnique();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(150);

            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("VARBINARY(500)");
            builder.Property(x => x.Description).HasMaxLength(500);


            builder.Property(x => x.CreatedByName).HasMaxLength(70).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(70);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();

            builder.HasOne<Role>(x => x.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);

            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Cahatay",
                LastName = "Ozdemir",
                Email = "ahaozde@dfds.com",
                UserName = "Scaramucci",
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Admin",
                ModifiedDate = DateTime.Now,
                CreatedByName = "Admin",
                Description = "ilk Kullanici",
                Note = "Test",
                Picture = "https://www.donanimhaber.com/images/images/haber/150460/1400x1050yeni-terminator-oyunu-duyuruldu.jpg",
                PasswordHash = Encoding.ASCII.GetBytes("085481314207ef178e84a59227d2f960")

            });


        }
    }
}
