using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Dfactura
    {
        public int dfacodigo { get; set; }

        [Display(Name = "Factura")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string dfafaccod { get; set; }

        [Display(Name = "Proyecto")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int dfaprocod { get; set; }

        [Display(Name = "Cód. Presupuestal")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int dfacodpre { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public double dfavalor { get; set; }



        //Relaciones




    }
}
