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
            var manager = await CheckUserAsync("1010", "Alicia", "Cortes", "aliscortes@hotmail.com", "350 634 2747", "Calle Luna Calle Sol", "Admin");
            var customer = await CheckUserAsync("2020", "Alicia", "Cortes", "aliscortes13@gmail.com", "350 634 2747", "Calle Luna Calle Sol", "Customer");


            await CheckBancosAsync();
            await CheckCiudadsAsync();
            await CheckTipproveesAsync();
            await CheckSucursalsAsync();
            await CheckTipoctasAsync();
            await CheckPrioridadsAsync();
            await CheckTipoDocumsAsync();
            await CheckEstadosAsync();
            await CheckClasesAsync();
            await CheckInstruccionesPagoAsync();
            await CheckProyectoAsync();
            await CheckCodigoPresupuestalAsync();

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
        
        private async Task CheckSucursalsAsync()
        {
            if (!_context.Sucursals.Any())
            {
                _context.Sucursals.Add(new Sucursal { Sucnombre = "Aeropueto", Succodfid = "035" });
                _context.Sucursals.Add(new Sucursal { Sucnombre = "Alto Prado", Succodfid = "476" });
                _context.Sucursals.Add(new Sucursal { Sucnombre = "Armenia ", Succodfid = "454" });
                _context.Sucursals.Add(new Sucursal { Sucnombre = "Av Pradilla", Succodfid = "001" });
                _context.Sucursals.Add(new Sucursal { Sucnombre = "B.E. Uni 15", Succodfid = "490" });


                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipproveesAsync()
        {
            if (!_context.Tipprovees.Any())
            {
                _context.Tipprovees.Add(new Tipprovee { Tipnombre = "Permanentes" });
                _context.Tipprovees.Add(new Tipprovee { Tipnombre = "Servicios Profesionales" });
                _context.Tipprovees.Add(new Tipprovee { Tipnombre = "Servicios de Obra" });
                _context.Tipprovees.Add(new Tipprovee { Tipnombre = "Infraestructura y equipos" });
                _context.Tipprovees.Add(new Tipprovee { Tipnombre = "Materiales" });


                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckTipoctasAsync()
        {
            if (!_context.Tipoctas.Any())
            {
                _context.Tipoctas.Add(new Tipocta { Tipnombre = "Cta de ahorros", Tipcodfidu = "2" });
                _context.Tipoctas.Add(new Tipocta { Tipnombre = "Cta Corriente", Tipcodfidu = "1" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckPrioridadsAsync()
        {
            if (!_context.Prioridads.Any())
            {
                _context.Prioridads.Add(new Prioridad { Descripcion = "Baja" });
                _context.Prioridads.Add(new Prioridad { Descripcion = "Media" });
                _context.Prioridads.Add(new Prioridad { Descripcion = "Alta" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTipoDocumsAsync()
        {
            if (!_context.Tipodocums.Any())
            {
                _context.Tipodocums.Add(new Tipodocum { Tdtipo = "Tarjeta de identidad", Tdcodfid = "TI" });
                _context.Tipodocums.Add(new Tipodocum { Tdtipo = "Cedula de ciudadania", Tdcodfid = "CC" });
                _context.Tipodocums.Add(new Tipodocum { Tdtipo = "Cedula de extranjeria", Tdcodfid = "CE" });
                _context.Tipodocums.Add(new Tipodocum { Tdtipo = "NIT", Tdcodfid = "NIT" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckEstadosAsync()
        {
            if (!_context.Estados.Any())
            {
                _context.Estados.Add(new Estado { Estnombre = "Activo" });
                _context.Estados.Add(new Estado { Estnombre = "Inactivo" });
           


                await _context.SaveChangesAsync();
            }
            // voy acá, no creo bien la bd no creo las tablas nuevas y sale error en tipprovee, 
            // será que lo cambio por tipop....volver a hacer drop
        }
        private async Task CheckClasesAsync()
        {
            if (!_context.Clases.Any())
            {
                _context.Clases.Add(new Clase { Clanombre = "Simplificado" });
                _context.Clases.Add(new Clase { Clanombre = "Común" });

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckInstruccionesPagoAsync()
        {
            if (!_context.Instruccionespagos.Any())
            {
                _context.Instruccionespagos.Add(new Instruccionespago { Concepto = "Ventanilla", Codigofidu = "1" });
                _context.Instruccionespagos.Add(new Instruccionespago { Concepto = "Ventanilla (Concesión)", Codigofidu = "2" });
                _context.Instruccionespagos.Add(new Instruccionespago { Concepto = "Consignar  (Domesa)", Codigofidu = "10" });
                _context.Instruccionespagos.Add(new Instruccionespago { Concepto = "Consignar (Concesión)", Codigofidu = "11" });
                _context.Instruccionespagos.Add(new Instruccionespago { Concepto = "Cheque de Gerencia", Codigofidu = "3" });
                _context.Instruccionespagos.Add(new Instruccionespago { Concepto = "Pago Masivo", Codigofidu = "12" });

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckProyectoAsync()
        {
            if (!_context.Proyectos.Any())
            {
                _context.Proyectos.Add(new Proyecto { Pronombre = "Santa Marta", Proinicial = "S" });
                _context.Proyectos.Add(new Proyecto { Pronombre = "Bosconia", Proinicial = "B" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCodigoPresupuestalAsync()
        {
            if (!_context.Codigopresupuestals.Any())
                _context.Codigopresupuestals.Add(new Codigopresupuestal { Codnumeral = "1", Codconcepto  = "GASTOS DE OPERACIÓN" , Codnivel="1,1", Codver=true});
                _context.Codigopresupuestals.Add(new Codigopresupuestal { Codnumeral = "1,1", Codconcepto = "Vigilancia", Codnivel = "1,1", Codver = true });
                _context.Codigopresupuestals.Add(new Codigopresupuestal { Codnumeral = "1,1", Codconcepto = "Transporte de valores", Codnivel = "1,1", Codver = true });
                _context.Codigopresupuestals.Add(new Codigopresupuestal { Codnumeral = "1,1", Codconcepto = "Transporte de Personal", Codnivel = "1,1", Codver = true });
                await _context.SaveChangesAsync();
            }
        }

    }

