﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SubscribeMail
    {
        [Key]
        public int MailId { get; set; }
        [StringLength(61)]
        public string Mail { get; set; }
    }
}
