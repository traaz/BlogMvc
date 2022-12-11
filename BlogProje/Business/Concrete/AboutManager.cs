using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager
    {
        Repository<About> repo = new Repository<About>();
        public List<About> GetAll()
        {
            return repo.List();
        }
        public int updateAbout(About a)
        {
            About about = repo.Find(x => x.AboutId == a.AboutId);
            about.AboutContent1 = a.AboutContent1;
         
            about.AboutId= a.AboutId;
            return repo.Update(about);
        }
    }
}
