using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Proyecto
    {
        public int procodigo { get; set; }

        [Display(Name = "Proyecto")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string pronombre { get; set; }

        [Display(Name = "Letra inicial")]
        public string proinicial { get; set; }


        //Relaciones




    }
}
