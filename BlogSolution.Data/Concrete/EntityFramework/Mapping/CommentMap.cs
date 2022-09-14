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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Text).HasMaxLength(300).IsRequired();
            builder.Property(x => x.CreatedByName).HasMaxLength(70).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(70);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(250);

            builder.HasOne<Article>(y => y.Article).WithMany(a => a.Comments).HasForeignKey(y => y.ArticleId);

            builder.ToTable("Comments");
        }
    }
}
