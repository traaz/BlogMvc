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
        public List<Author> GetAuthorByMail(string mail)
        {
            return repoAuthor.List(x=>x.AuthorMail == mail);
        }
    }
}
