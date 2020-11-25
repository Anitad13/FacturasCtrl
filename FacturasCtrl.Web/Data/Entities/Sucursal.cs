using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Sucursal
    {
        public int Succodigo { get; set; }

        [Display(Name = "Sucursal")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string sucnombre { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string succodfid { get; set; }


        //Relaciones




    }
}
