using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacturasCtrl.Web.Data.Entities
{
    public class Proveedor
    {
        public int procodigo { get; set; }

        [Display(Name = "Tipo de documento")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public int protipdoc { get; set; }

        [Display(Name = "Céudla o Nit")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string pronticel { get; set; }

        [Display(Name = "Digito de verificación")]

        public int prondigv { get; set; }

        [Display(Name = "Nombre")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string pronombre { get; set; }

        [Display(Name = "Dirección")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string prodirec { get; set; }

        [Display(Name = "Ciudad")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int prociudad { get; set; }

        [Display(Name = "Teléfono")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string protel1 { get; set; }


        [Display(Name = "Teléfono2")]

        public string protel2 { get; set; }


       
        [Display(Name = "Mail")]

        public string promail { get; set; }


        [Display(Name = "Contacto")]

        public string procontac { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int protipo { get; set; }

        //1;Activo;2;Inactivo
        [Display(Name = "Estado")]

        public int proestad { get; set; }

        //1;Simplificado;2;Común
        [Display(Name = "Clase")]

        public int proclase { get; set; }

        
        [Display(Name = "Soporte RUT")]

        public bool prorut { get; set; }

        [Display(Name = "Gran contribuyente")]

        public bool progran { get; set; }

        [Display(Name = "Autoretenedor")]

        public bool proauto { get; set; }

        //para los proveedores permanentes
        [Display(Name = "Mes de renovación de contrato")]

        public int profemes { get; set; }

        [Display(Name = "Día de renovación de contrato")]

        public int profedia { get; set; }

        [Display(Name = "Proceso que ingresa el proveedor")]

        public int proingre { get; set; }

        //Relaciones




    }
}