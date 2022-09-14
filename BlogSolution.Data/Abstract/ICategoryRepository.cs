using BlogSolution.Entities.Concrete;
using BlogSolution.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSolution.Data.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }
}
