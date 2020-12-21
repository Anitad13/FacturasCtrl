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

        [Display(Name = "Cédula o Nit")]

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
      
        public int TipproveeId { get; set; }


        //1;Activo;2;Inactivo
        [Display(Name = "Estado")]

        public int EstadoId { get; set; }

        //1;Simplificado;2;Común
        [Display(Name = "Clase")]

        public int ClaseId { get; set; }

        
        [Display(Name = "Soporte RUT")]

        public bool Prorut { get; set; }

        [Display(Name = "Gran contribuyente")]

        public bool Progran { get; set; }

        [Display(Name = "Autoretenedor")]

        public bool Proauto { get; set; }

        //para los proveedores permanentes
        [Display(Name = "Mes de renovación")]

        public int Profemes { get; set; }

        [Display(Name = "Día de renovación")]

        public int Profedia { get; set; }

        [Display(Name = "Proceso que ingresa el proveedor")]

        public string Proingre { get; set; }

        //Relaciones

       
        public Ciudad Ciudads { get; set; }
       
        public Tipodocum Tipodocums { get; set; }

        public Tipprovee Tipprovees { get; set; }

        public Estado Estados { get; set; }

        public Clase Clases { get; set; }

        public ICollection<Factura> Facturas { get; set; }

    }
}