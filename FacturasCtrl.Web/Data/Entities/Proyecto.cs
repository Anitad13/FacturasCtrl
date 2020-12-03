using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Proyecto
    {
        public int Id { get; set; }

        [Display(Name = "Proyecto")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Pronombre { get; set; }

        [Display(Name = "Letra inicial")]
        public string Proinicial { get; set; }


        //Relaciones

        public ICollection<Dfactura> Dfacturas { get; set; }


    }
}
