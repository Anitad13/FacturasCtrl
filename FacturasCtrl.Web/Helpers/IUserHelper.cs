using Microsoft.AspNetCore.Identity;
using FacturasCtrl.Web.Data.Entities;
using System.Threading.Tasks;
using FacturasCtrl.Web.Models;

namespace FacturasCtrl.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
