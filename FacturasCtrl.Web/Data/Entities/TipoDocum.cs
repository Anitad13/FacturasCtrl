using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Tipodocum
    {
        public int Id { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Tdtipo { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string Tdcodfid { get; set; }


        //Relaciones

        public ICollection<Benefgt> Benefgts { get; set; }
        public ICollection<Proveedor> Proveedors { get; set; }


    }
}

