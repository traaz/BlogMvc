using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repo = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return repo.List();
        }
     public List<Blog> GetBlogById(int id)
        {
            return repo.List(x => x.BlogId== id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repo.List(x => x.AuthorId == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return repo.List(x => x.CategoryId == id);
        }
    }
}
