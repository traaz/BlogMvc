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
        public List<Comment> CommentList()
        {
            return repo.List();
        }
     
        public List<Comment> CommentByBlog(int id)
        {
            return repo.List(x=>x.BlogId == id && x.CommentStatus == true);
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
        public List<Comment> CommentStatusTrue( )
        {
            return repo.List(x => x.CommentStatus == true);
        }
        public int changeCommnetStatusFalse(int id)
        {
            Comment comment = repo.Find(x => x.CommentId == id);
            comment.CommentStatus = false;
            return repo.Update(comment);
        }
    }
}
