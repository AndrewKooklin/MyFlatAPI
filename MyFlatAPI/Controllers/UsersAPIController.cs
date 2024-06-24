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
    public class UsersAPIController : Controller
    {
        private DataManager _dataManager;

        public UsersAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet("[controller]/GetUsers")]
        public List<IdentityUser> GetUsers()
        {
            return _dataManager.Accounts.GetUsers();
        }

        [HttpGet("[controller]/GetUserWithRoles/{id?}")]
        public UserWithRolesModel GetUserWithRoles(string id)
        {
            return _dataManager.Accounts.GetUserWithRoles(id);
        }

        [HttpGet("[controller]/GetUsersWithRoles")]
        public List<UserWithRolesModel> GetUsersWithRoles()
        {
            return _dataManager.Accounts.GetUsersWithRoles();
        }

        [HttpPost("[controller]/AddRoleToUser/{RoleUserModel?}")]
        public bool AddRoleToUser(RoleUserModel model)
        {
            return _dataManager.Accounts.AddRoleToUser(model).GetAwaiter().GetResult();
        }

        [HttpPost("[controller]/DeleteRoleUser/{RoleUserModel?}")]
        public bool DeleteRoleUser(RoleUserModel model)
        {
            return _dataManager.Accounts.DeleteRoleUser(model).GetAwaiter().GetResult();
        }

        [HttpPost("[controller]/DeleteRolesUser/{id?}")]
        public bool DeleteRolesUser(string id)
        {
            return _dataManager.Accounts.DeleteRolesUser(id).GetAwaiter().GetResult();
        }

        [HttpPost("[controller]/DeleteUser/{id?}")]
        public bool DeleteUser(string id)
        {
            return _dataManager.Accounts.DeleteUser(id).GetAwaiter().GetResult();
        }

        [HttpPost("[controller]/AddNewUser/{AddUserModel?}")]
        public bool AddNewUser([FromBody] AddUserModel model)
        {
            return _dataManager.Accounts.AddNewUser(model).GetAwaiter().GetResult();
        }
    }
}
