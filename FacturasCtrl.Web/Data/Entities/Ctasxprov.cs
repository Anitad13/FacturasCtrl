using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Ctasxprov
    {
        public int Id { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int ProveedorId { get; set; }

        [Display(Name = "Tipo Cuenta")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int TipoctaId { get; set; }

        [Display(Name = "Banco")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int BancoId { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Cxpnum { get; set; }

        [Display(Name = "Sucursal")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int SucursalId { get; set; }


        //Relaciones

        public Banco Bancos { get; set; }

        public Sucursal Sucursals { get; set; }
        public Tipocta Tipoctas { get; set; }



    }
}