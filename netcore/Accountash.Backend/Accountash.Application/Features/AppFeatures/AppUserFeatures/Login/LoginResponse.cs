﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginResponse
    {
        public string Token { get; set; }
        public string EMail { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
    }
}
