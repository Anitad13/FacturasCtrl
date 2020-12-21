using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Estado
    {
        public int Id { get; set; }

        [Display(Name = "Estado")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Estnombre { get; set; }



        //Relaciones


        public ICollection<Proveedor> Proveedors { get; set; }
    }
}
