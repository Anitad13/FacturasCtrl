using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Factura
    {
        public int Id { get; set; }

       
        [Display(Name = "Planilla")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int Facplanilla { get; set; }

        [Display(Name = "Date*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaRecibido { get; set; }

        [Display(Name = "No de factura")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NoFactura { get; set; }


        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int ProveedorId { get; set; }

        [Display(Name = "Valor sin IVA")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Double Facvalsiniva { get; set; }

        [Display(Name = "Valor Documento")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public Double ValorDocumento { get; set; }

        [Display(Name = "Concepto")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Concepto { get; set; }


        [Display(Name = "Fecha de Pago")]
     
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechadePago { get; set; }

        [Display(Name = "Instrucciones Pago")]
       
        public int InstruccionespagoId { get; set; }

        [Display(Name = "Instrucciones especiales")]
      
        public string InstruccionesEspeciales { get; set; }

        [Display(Name = "Documento Anexo")]

        public string DocumentoAnexo { get; set; }

        [Display(Name = "Cuenta Origen")]

        public string CuentaOrigen { get; set; }

        [Display(Name = "Prioridad")]

        public int PrioridadId { get; set; }

        [Display(Name = "Observaciones DTA")]

        public string ObservacionesDTA { get; set; }

        [Display(Name = "Observaciones DF")]

        public string ObservacionesDF { get; set; }

        
        [Display(Name = "Fecha Pago")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaPago { get; set; }


        [Display(Name = "Realiza el pago")]

        public string Facpago { get; set; }

        [Display(Name = "Sucursal")]

        public string Facsucursal { get; set; }

        [Display(Name = "Persona que recibe")]

        public string Facperrecib { get; set; }

        [Display(Name = "¿Anticipo?")]

        public bool Facanticipo { get; set; }

        [Display(Name = "¿Impuesto?")]

        public bool Facimpto { get; set; }

        [Display(Name = "¿Nómina?")]

        public bool Facnomina { get; set; }





        //Relaciones
        public ICollection<Benefgt> Benefgts { get; set; }
          

        public ICollection<Dtosxfac> Dtosxfacs { get; set; }

     
        public Instruccionespago Instruccionespagos { get; set; }

     
        public ICollection<Dfactura> Dfacturas { get; set; }

        public Proveedor Proveedors { get; set; }

        public Prioridad Prioridads { get; set; }

        //voy aqui faltaria relacion con proveedores y cambiar a ProveedorId

    }
}