using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Tipocta
    {
        public int Id { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Tipnombre { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string Tipcodfidu { get; set; }


        //Relaciones  

        public ICollection<Ctasxprov> Ctasxprovs { get; set; }

        public ICollection<Benefgt> benefgts { get; set; }

       

    }
}

