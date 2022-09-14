using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSolution.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository ArticleRepository { get; } //unitofwork.Articles
        ICategoryRepository CategoryRepository { get; } //_unitofwork.Categories.AddAsync()
        ICommentRepository CommentRepository { get; } //_unitofwork.Comments.AddAsync()
        IRoleRepository RoleRepository { get; } ////_unitofwork.Roles.AddAsync()
        IUserRepository UserRepository { get; }


        Task<int> SaveAsync();
        

        //_unitofwork.SaveAsync()

    }
}
