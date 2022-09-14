using BlogSolution.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSolution.Entities.Concrete;

namespace BlogSolution.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {

    }
}
