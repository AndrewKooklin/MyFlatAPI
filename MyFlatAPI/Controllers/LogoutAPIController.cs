using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;

namespace MyFlatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogoutAPIController : Controller
    {
        private readonly DataManager _dataManager;

        public LogoutAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpPost("[controller]/LogoutUser")]
        public void LogoutUser()
        {
            _dataManager.Accounts.LogoutUser();
        }
    }
}
