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
        public int AddBlog(Blog b)
        {
            if(b.BlogTitle == "" || b.BlogContent == "" || b.BlogImage == "")
            {
                return -1;
            }
            else
            {
                return repo.Insert(b);
            }
        }
        public int DeleteBlog(int id)
        {
            Blog blog = repo.Find(x => x.BlogId == id);
            return repo.Delete(blog);
        }
        public Blog findBlog(int id)
        {
            return repo.Find(x => x.BlogId == id);
        }
        public int updateBlog(Blog b)
        {
            Blog blog = repo.Find(x=>x.BlogId== b.BlogId);
            blog.BlogTitle = b.BlogTitle;
            blog.BlogContent = b.BlogContent;
            blog.BlogDate = b.BlogDate;
            blog.BlogImage = b.BlogImage;
            blog.BlogContent = b.BlogContent;
            blog.AuthorId = b.AuthorId;
            blog.CategoryId = b.CategoryId;
            return repo.Update(b);
        }
    }
}
