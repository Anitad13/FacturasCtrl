using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Sucursal
    {
        public int Id { get; set; }

        [Display(Name = "Sucursal")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Sucnombre { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string Succodfid { get; set; }


        //Relaciones
        public ICollection<Ctasxprov> Ctasxprovs { get; set; }
      
        public ICollection<Benefgt> Benefgts { get; set; }

    }
}
