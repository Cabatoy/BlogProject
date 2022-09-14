using BlogSolution.Shared.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSolution.Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {

      //  public override DateTime CreatedDate { get => base.CreatedDate; set => base.CreatedDate = value; }

      public string Name { get; set; }
      public string Description { get; set; }
     
      public ICollection<Article> Articles { get; set; }

    }
}
