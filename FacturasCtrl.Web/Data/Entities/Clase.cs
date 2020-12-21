using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Clase
    {
        public int Id { get; set; }

        [Display(Name = "Clase")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Clanombre { get; set; }



        //Relaciones


        public ICollection<Proveedor> Proveedors { get; set; }
    }
}
