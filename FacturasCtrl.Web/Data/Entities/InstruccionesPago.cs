﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Instruccionespago
    {
        public int Id { get; set; }

        [Display(Name = "Concepto")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Concepto { get; set; }

        [Display(Name = "Código Fiduciaria")]
        public string Codigofidu { get; set; }


        //Relaciones

             
        public ICollection<Factura> Facturas { get; set; }

    }
}
