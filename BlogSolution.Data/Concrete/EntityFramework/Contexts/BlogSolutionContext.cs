using Microsoft.EntityFrameworkCore;
using BlogSolution.Entities.Concrete;
using BlogSolution.Data.Concrete.EntityFramework.Mapping;

namespace BlogSolution.Data.Concrete.EntityFramework.Contexts
{
    public class BlogSolutionContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TRIST-LPF2RZWAY;Database=BlogSolution;Trusted_Connection=True;;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());


        }
    }
}
