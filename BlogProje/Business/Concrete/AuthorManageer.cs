using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManageer
    {
        Repository<Author> repo = new Repository<Author>();
        public List<Author> GetAll()
        {
            return repo.List();
        }
        public int AddAuthor(Author author)
        {
            if(author.AuthorName == "" || author.AuthorMail == "" || author.AuthorImage == "")
            {
                return -1;
            }
            else{
                return repo.Insert(author); 
            }
        }
        public Author findAuthor(int id)
        {
            return repo.Find(x => x.AuthorId == id);
        }
        public int updateAuthor(Author a)
        {
            Author author = repo.Find(x => x.AuthorId == a.AuthorId);
            author.AuthorId= a.AuthorId;
            author.AuthorName = a.AuthorName;
            author.AuthorImage = a.AuthorImage;
            author.AuthorAbout = a.AuthorAbout;
            author.AuthorTitle = a.AuthorTitle;
            author.AuthorMail = a.AuthorMail;
            author.PhoneNumber = a.PhoneNumber;
            
            return repo.Update(author);
        }
    }
}
