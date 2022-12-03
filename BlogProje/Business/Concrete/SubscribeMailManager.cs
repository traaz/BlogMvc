using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public  class SubscribeMailManager
    {
        Repository<SubscribeMail> repo = new Repository<SubscribeMail>();
        public int BlAdd(SubscribeMail sM)
        {
            if(sM.Mail.Length<=10 || sM.Mail.Length >= 61)
            {
                return -1;
            } 
            return repo.Insert(sM);
        }
    }
}
