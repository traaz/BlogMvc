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
        public int AddCategory(Category category)
        {
            if (category.CategoryName == "")
            {
                return -1;
            }
            else
            {
                return repo.Insert(category);
            }
        }
        public int deleteCategory(int id)
        {
            Category category = repo.GetById(id);
            return repo.Delete(category);
        }
    }
}
