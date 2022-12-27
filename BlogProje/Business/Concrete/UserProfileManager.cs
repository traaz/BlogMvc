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

    }
}
