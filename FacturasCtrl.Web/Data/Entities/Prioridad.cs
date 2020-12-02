using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Prioridad
    {
        public int Id { get; set; }

        [Display(Name = "Prioridad")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Descripcion { get; set; }




        //Relaciones

        public ICollection<Factura> Facturas { get; set; }


    }
}
