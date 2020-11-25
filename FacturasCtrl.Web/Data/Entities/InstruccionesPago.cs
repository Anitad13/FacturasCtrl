using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class InstruccionesPago
    {
        public int Codigo { get; set; }

        [Display(Name = "Concepto")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Concepto { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string codigofidu { get; set; }


        //Relaciones




    }
}
