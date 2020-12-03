using FacturasCtrl.Web.Data.Entities;
using FacturasCtrl.Web.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FacturasCtrl.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await CheckRoles();
            var manager = await CheckUserAsync("1010", "Alicia", "Cortés", "aliscortes@hotmail.com", "Calle 5 No 2-24", "Admin");
            var customer = await CheckUserAsync("2020", "Juan", "Zuluaga", "aliscortes13@gmail.com", "Calle 5 No 2-24", "Customer");

        
            await CheckMypersonsAsync(customer);
            await CheckManagerAsync(manager);
          

        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Customer");
        }

        private async Task<User> CheckUserAsync(
              string document,
              string firstName,
              string lastName,
              string email,
              string address,
              string role         )

        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    Address = address,
                    Document = document,
                

                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }


        private async Task CheckManagerAsync(User user)
        {
            if (!_context.Managers.Any())
            {
                _context.Managers.Add(new Manager { User = user });
                await _context.SaveChangesAsync();
            }
        }



        private async Task CheckMypersonsAsync(User user)
        {

            {
                if (!_context.Personals.Any())
                {
                    _context.Personals.Add(new Personal { User = user });
                    await _context.SaveChangesAsync();
                }
            }
        }



    }
}