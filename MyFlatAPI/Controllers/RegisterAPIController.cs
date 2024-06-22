using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Account;

namespace MyFlatAPI.Controllers
{
    [ApiController]
    public class RegisterAPIController : Controller
    {
        private readonly DataManager _dataManager;

        public RegisterAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpPost("[controller]/CreateUser/{RegisterModel?}")]
        public Task<bool> CreateUser([FromBody] RegisterModel model)
        {
            return _dataManager.Accounts.CreateUser(model);
        }

        [HttpGet("[controller]/GetRoleNames")]
        public List<string> GetRoleNames()
        {
            return _dataManager.Accounts.GetRoleNames();
        }
    }
}
