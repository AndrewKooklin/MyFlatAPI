using Microsoft.AspNetCore.Identity;
using MyFlatAPI.Data.Models;
using MyFlatAPI.Data.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Repositories.Abstract
{
    public interface IAccountRepositoryAPI
    {
        Task<bool> CheckUserToDB(LoginModel model);

        void LogoutUser();

        Task<bool> CreateUser(RegisterModel model);

        Task<bool> AddNewUser(AddUserModel model);

        Task<IdentityUser> GetUser(LoginModel model);

        Task<List<string>> GetUserRoles(LoginModel model);

        List<string> GetRoleNames();

        IEnumerable<IdentityRole> GetRoles();

        Task<bool> CreateRole(IdentityRole role);

        Task<bool> DeleteRole(string id);

        List<IdentityUser> GetUsers();

        UserWithRolesModel GetUserWithRoles(string id);

        List<UserWithRolesModel> GetUsersWithRoles();

        Task<bool> AddRoleToUser(RoleUserModel model);

        Task<bool> DeleteRoleUser(RoleUserModel model);

        Task<bool> DeleteRolesUser(string userId);

        Task<bool> DeleteUser(string id);
    }
}
