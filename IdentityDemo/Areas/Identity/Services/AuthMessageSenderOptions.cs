﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDemo.Areas.Identity.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }

        public string SendGridKey { get; set; }
    }
}
