using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repo = new Repository<Category>();
        public List<Category> GetAll()
        {
           return repo.List();
        }
    }
}
