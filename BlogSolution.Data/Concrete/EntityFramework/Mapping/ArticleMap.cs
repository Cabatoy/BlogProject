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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.ReleaseDate).IsRequired();
            builder.Property(x => x.SeoAuthor).HasMaxLength(50).IsRequired();
            builder.Property(x => x.SeoDescription).HasMaxLength(250).IsRequired();
            builder.Property(x => x.SeoTags).HasMaxLength(170).IsRequired();

            builder.Property(x => x.ViewsCount).IsRequired();
            builder.Property(x => x.CommentCount).IsRequired();

            builder.Property(x => x.CreatedByName).HasMaxLength(70).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(70);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.ThumbNail).HasMaxLength(259).IsRequired();

            builder.Property(x => x.Note).HasMaxLength(250);

            builder.HasOne<Category>(x => x.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);

            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);


            builder.ToTable("Articles");
            builder.HasData(new Article
            {
                Id=1,
                SeoTags="",
                SeoAuthor="",
                SeoDescription="",
                CategoryId=1,

               
                Title="Lorem Ne Yapsam Ne etsem",
                Content= "\"But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?\"\"But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?",
                ThumbNail="Default.jpg",

                ReleaseDate=DateTime.UtcNow,
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Admin",
                ModifiedDate = DateTime.Now,
                CreatedByName = "Admin",
                Note = "Test",
                UserId=1
               
            },
                new Article
                {
                    Id = 2,
                    SeoTags = "",
                    SeoAuthor = "",
                    SeoDescription = "",
                    CategoryId = 2,


                    Title = "Lorem Ne Yapsam Ne etsem",
                    Content = "\"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?\"",
                    ThumbNail = "Default.jpg",

                    ReleaseDate = DateTime.UtcNow,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    ModifiedByName = "Admin",
                    ModifiedDate = DateTime.Now,
                    CreatedByName = "Admin",
                    Note = "Test",
                    UserId = 1

                });
        }
    }
}
