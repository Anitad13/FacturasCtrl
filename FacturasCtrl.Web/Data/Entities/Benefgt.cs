using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Benefgt
    {
        public int Id { get; set; }

        [Display(Name = "Factura")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int FacturaId { get; set; }

        [Display(Name = "Beneficiario giro a terceros")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Bgtbenef { get; set; }

        [Display(Name = "Tipo de documento")]
        public int TipodocumId { get; set; }

        [Display(Name = "Cédula/Nit")]
        
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Bgtccnit { get; set; }

        [Display(Name = "Tipo de cuenta")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int TipoctaId { get; set; }

        [Display(Name = "Número de cuenta")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Bgtnumc { get; set; }

        [Display(Name = "Banco")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int BancoId { get; set; }

        [Display(Name = "Forma de pago")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Bgtformap { get; set; }

        [Display(Name = "Valor")]

        public double Bgtvalor { get; set; }


        [Display(Name = "Sucursal")]

        public int SucursalId { get; set; }


        //Relaciones

        public Banco Bancos { get; set; }
       
        public Factura Facturas { get; set; }

        public Tipocta Tipoctas { get; set; }

        public Sucursal Sucursals { get; set; }

            


    }
}
