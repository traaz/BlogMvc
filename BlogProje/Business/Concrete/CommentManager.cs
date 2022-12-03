using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repo = new Repository<Comment>();   
        public List<Comment> CommentList(int id)
        {
            return repo.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repo.List(x=>x.BlogId == id);
        }
        public int CommnetAdd(Comment c)
        {
            if(c.CommentText.Length<4 || c.CommentText.Length >301)
            {
                return 1;
            }
            else
            {

                return repo.Insert(c);
            }
        }
    }
}
