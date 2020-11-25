using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Ciudad
    {
        public int Ciucodigo { get; set; }

        [Display(Name = "Nombre")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Ciunombre { get; set; }

       

        //Relaciones




    }
}
