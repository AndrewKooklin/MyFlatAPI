using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Account;

namespace MyFlatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginAPIController : Controller
    {
        private readonly DataManager _dataManager;

        public LoginAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpPost("[controller]/CheckUserToDB/{LoginModel?}")]
        public Task<bool> CheckUserToDB([FromBody] LoginModel model)
        {
            return _dataManager.Accounts.CheckUserToDB(model);
        }

        [HttpPost("[controller]/GetUserFromDB/{LoginModel?}")]
        public Task<IdentityUser> GetUserFromDB([FromBody] LoginModel model)
        {
            return _dataManager.Accounts.GetUser(model);
        }

        [HttpPost("[controller]/GetUserRoles/{LoginModel?}")]
        public Task<List<string>> GetUserRoles([FromBody] LoginModel model)
        {
            return _dataManager.Accounts.GetUserRoles(model);
        }
    }
}
