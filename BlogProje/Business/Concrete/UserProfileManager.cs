using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repoAuthor = new Repository<Author>();
        Repository<Blog> repoUser = new Repository<Blog>();
        Repository<Comment> repoComment = new Repository<Comment>();

        public List<Author> GetAuthorByMail(string mail)
        {
            return repoAuthor.List(x=>x.AuthorMail == mail);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoUser.List(x => x.AuthorId == id);
        }
        public int updateAuthor(Author a)
        {
            Author author = repoAuthor.Find(x => x.AuthorId == a.AuthorId);
            author.AuthorId = a.AuthorId;
            author.AuthorName = a.AuthorName;
            author.AuthorMail = a.AuthorMail;
            author.AuthorTitle = a.AuthorTitle;

            author.PhoneNumber = a.PhoneNumber;
            author.AuthorImage = a.AuthorImage;
            author.AuthorPassword = a.AuthorPassword;
            author.AuthorAbout = a.AuthorAbout;
          
           

            return repoAuthor.Update(author);
        }

   /*    public List<Comment> GetCommentByAuthor(int id)
        {
            Context context = new Context();
            var query = ("Select CommentText From Comments where BlogId IN (Select BlogId From Blogs where AuthorId=@id)").ToList();
            context.Database.ExecuteSqlCommand(query, @id);
            return query;


          //  return repoComment.List(x => x.AuthorId == id);
        }
   */
    }
}
