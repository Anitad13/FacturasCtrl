using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class CodigoPresupuestal
    {
        public int Id { get; set; }

        [Display(Name = "Numeral")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Codnumeral { get; set; }

        [Display(Name = "Concepto")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Codconcepto { get; set; }

       [Display(Name = "Ver")]
        public bool Codver { get; set; }

        [Display(Name = "Nivel")]
        public string Codnivel { get; set; }

        //Relaciones

        public ICollection<Dfactura> Dfacturas { get; set; }


    }
}