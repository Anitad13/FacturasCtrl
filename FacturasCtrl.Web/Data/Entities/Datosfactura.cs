using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Datosfactura
    {
        public int cxpcodigo { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int cxpprocod { get; set; }

        [Display(Name = "Tipo Cuenta")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int cxptipo { get; set; }

        [Display(Name = "Banco")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Banco { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string cxpnum { get; set; }

        [Display(Name = "Sucursal")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int cxpsucursal { get; set; }


        //Relaciones




    }
}