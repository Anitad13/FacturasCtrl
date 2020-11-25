using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Tipodocum
    {
        public int tdcodigo { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string tdtipo { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string tdcodfid { get; set; }


        //Relaciones




    }
}

