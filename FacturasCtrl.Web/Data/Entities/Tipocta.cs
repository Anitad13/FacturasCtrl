using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Tipocta
    {
        public int tipcodigo { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string tipnombre { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string tipcodfidu { get; set; }


        //Relaciones




    }
}

