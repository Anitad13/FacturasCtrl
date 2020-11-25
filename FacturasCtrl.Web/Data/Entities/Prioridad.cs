using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Prioridad
    {
        public int Codigo { get; set; }

        [Display(Name = "Prioridad")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Descripcion { get; set; }

       


        //Relaciones




    }
}
