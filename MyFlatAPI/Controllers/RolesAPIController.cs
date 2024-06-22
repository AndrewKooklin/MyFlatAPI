using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;

namespace MyFlatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolesAPIController : Controller
    {
        private DataManager _dataManager;

        public RolesAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        [Route("[controller]/GetRoles")]
        public IEnumerable<IdentityRole> GetRoles()
        {
            var roles = _dataManager.Accounts.GetRoles();
            return roles;
        }

        [HttpPost("[controller]/CreateRole/{IdentityRole?}")]
        public bool CreateRole(IdentityRole role)
        {
            return _dataManager.Accounts.CreateRole(role).GetAwaiter().GetResult();
        }

        [HttpPost("[controller]/DeleteRole/{id?}")]
        public bool DeleteRole(string id)
        {
            return _dataManager.Accounts.DeleteRole(id).GetAwaiter().GetResult();
        }
    }
}
