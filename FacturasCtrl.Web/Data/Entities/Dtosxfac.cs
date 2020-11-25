using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Dtosxfac
    {
        public int dtocodigo { get; set; }

        [Display(Name = "Factura")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int dtofaccod { get; set; }

        [Display(Name = "Concepto")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string dtoconcep { get; set; }

        [Display(Name = "Valor")]
        public double dtovalor { get; set; }


        //Relaciones




    }
}
