using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FacturasCtrl.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturasCtrl.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Manager> Managers { get; set; }

        public DbSet<Banco> Bancos { get; set; }

        public DbSet<Benefgt> Benefgts { get; set; }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<CodigoPresupuestal> CodigoPresupuestals { get; set; }

        public DbSet<Conceptospago> Conceptospagos { get; set; }

        public DbSet<Ctasxprov> Ctasxprovs { get; set; }
     
        public DbSet<Datosfactura> Datosfacturas { get; set; }
        
        public DbSet<Dfactura> Dfacturas { get; set; }

        public DbSet<Dtosxfac> Dtosxfacs { get; set; }

        public DbSet<InstruccionesPago> InstruccionesPagos { get; set; }

        public DbSet<Prioridad> Prioridads { get; set; }

        public DbSet<Proveedor> Proveedors { get; set; }

        public DbSet<Proyecto> Proyectos { get; set; }

        public DbSet<Sucursal> Sucursals { get; set; }

        public DbSet<Tipocta> Tipoctas { get; set; }

        public DbSet<Tipodocum> Tipodocums { get; set; }

    }

    }

