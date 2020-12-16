using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Tipprovee
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Tipnombre { get; set; }

      
        //Relaciones

        public ICollection<Proveedor> Proveedors { get; set; }

     




    }
}
