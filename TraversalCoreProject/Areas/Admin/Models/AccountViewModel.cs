﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }

        public decimal Amount { get; set; }

       
    }
}
