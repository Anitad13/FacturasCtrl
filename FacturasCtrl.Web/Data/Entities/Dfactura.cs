using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Dfactura
    {
        public int Id { get; set; }

        [Display(Name = "Factura")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string FacturaId { get; set; }

        [Display(Name = "Proyecto")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ProyectoId { get; set; }

        [Display(Name = "Cód. Presupuestal")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int CodigopresupuestalId { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public double Valor { get; set; }



        //Relaciones

       
        public Codigopresupuestal Codigopresupuestals { get; set; }

        public Factura Facturas { get; set; }

        public Proyecto Proyectos { get; set; }
    }
}
