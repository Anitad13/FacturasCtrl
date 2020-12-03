using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Dtosxfac
    {
        public int Id { get; set; }

        [Display(Name = "Factura")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int FacturaId { get; set; }

        [Display(Name = "Concepto")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Concepto { get; set; }

        [Display(Name = "Valor")]
        public double Valor { get; set; }


        //Relaciones

        public Factura Facturas { get; set; }


    }
}
