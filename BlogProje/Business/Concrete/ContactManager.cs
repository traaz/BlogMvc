using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repo = new Repository<Contact>();
        public int ContactAdd(Contact c)
        {
            return repo.Insert(c);
        }
        public List<Contact> GetAll()
        {
            return repo.List();
        }
        public Contact GetContactDetails(int id)
        {
            return repo.Find(x=>x.ContactId== id);  

        }
    }
}
