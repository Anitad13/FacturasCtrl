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
            var manager = await CheckUserAsync("1010", "Juan", "Zuluaga", "aliscortes@hotmail.com", "350 634 2747", "Calle Luna Calle Sol", "Admin");
            var customer = await CheckUserAsync("2020", "Juan", "Zuluaga", "aliscortes13@gmail.com", "350 634 2747", "Calle Luna Calle Sol", "Customer");


            await CheckBancosAsync();
            await CheckCiudadsAsync();
          
            await CheckManagerAsync(manager);

        
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Customer");
        }

        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, string address, string role)
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
                    PhoneNumber = phone,
                    Address = address,
                    Document = document
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

        private async Task CheckBancosAsync()
        {
            if (!_context.Bancos.Any())
            {
                _context.Bancos.Add(new Banco { Bannombre = "BBVA", Bancodfid = "13" });
                _context.Bancos.Add(new Banco { Bannombre = "Banco AV Villas", Bancodfid = "52" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCiudadsAsync()
        {
            if (!_context.Ciudads.Any())
            {
                _context.Ciudads.Add(new Ciudad { Ciunombre = "Bogotá" });
                _context.Ciudads.Add(new Ciudad { Ciunombre = "Barranquilla" });
                await _context.SaveChangesAsync();
            }
        }



    }
}
