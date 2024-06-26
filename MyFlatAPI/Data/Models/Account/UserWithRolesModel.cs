﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MyFlatAPI.Data.Models.Account
{
    public class UserWithRolesModel
    {
        public IdentityUser User { get; set; }

        public List<string> Roles { get; set; }
    }
}
