using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models
{
    [AllowAnonymous]
    public class LoginModel
    {
        public string EMail { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
