using BlogSolution.Data.Abstract;
using BlogSolution.Data.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSolution.Data.Concrete.EntityFramework.Repositories;

namespace BlogSolution.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly BlogSolutionContext _context;
        private EfArticleRepository _efArticleRepository;
        private EfCategoryRepository _efCategoryRepository;
        private EfCommentRepository _efCommentRepository;
        private EfRoleRepository _efRoleRepository;
        private EfUserRepository _efUserRepository;

        public UnitOfWork(BlogSolutionContext blogSolutionContext)
        {
            _context = blogSolutionContext;
        }
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }


        public IArticleRepository ArticleRepository => _efArticleRepository ?? new EfArticleRepository(_context);
        public ICategoryRepository CategoryRepository => _efCategoryRepository ?? new EfCategoryRepository(_context);
        public ICommentRepository CommentRepository => _efCommentRepository ?? new EfCommentRepository(_context);
        public IRoleRepository RoleRepository => _efRoleRepository ?? new EfRoleRepository(_context);
        public IUserRepository UserRepository => _efUserRepository ?? new EfUserRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        
    }
}
