using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Banco
    {
        public int Bancodigo { get; set; }

        [Display(Name = "Nombre")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

       public string Bannombre { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string Bancodfid { get; set; }

     
        //Relaciones


      

    }
}
