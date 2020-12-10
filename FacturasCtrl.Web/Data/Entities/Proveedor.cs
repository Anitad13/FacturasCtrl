using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de documento")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int TipoDocumId { get; set; }

        [Display(Name = "Céudla o Nit")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Pronticel { get; set; }

        [Display(Name = "Digito de verificación")]

        public int Prondigv { get; set; }

        [Display(Name = "Nombre")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Pronombre { get; set; }

        [Display(Name = "Dirección")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Prodirec { get; set; }

        [Display(Name = "Ciudad")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int CiudadId { get; set; }

        [Display(Name = "Teléfono")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Protel1 { get; set; }


        [Display(Name = "Teléfono2")]

        public string Protel2 { get; set; }


       
        [Display(Name = "Mail")]

        public string Promail { get; set; }


        [Display(Name = "Contacto")]

        public string Procontac { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Protipo { get; set; }

        //1;Activo;2;Inactivo
        [Display(Name = "Estado")]

        public int Proestad { get; set; }

        //1;Simplificado;2;Común
        [Display(Name = "Clase")]

        public int Proclase { get; set; }

        
        [Display(Name = "Soporte RUT")]

        public bool Prorut { get; set; }

        [Display(Name = "Gran contribuyente")]

        public bool Progran { get; set; }

        [Display(Name = "Autoretenedor")]

        public bool Proauto { get; set; }

        //para los proveedores permanentes
        [Display(Name = "Mes de renovación de contrato")]

        public int Profemes { get; set; }

        [Display(Name = "Día de renovación de contrato")]

        public int Profedia { get; set; }

        [Display(Name = "Proceso que ingresa el proveedor")]

        public int Proingre { get; set; }

        //Relaciones

       
        public Ciudad Ciudads { get; set; }
        public Factura Facturas { get; set; }

        public Tipodocum Tipodocums { get; set; }


    }
}