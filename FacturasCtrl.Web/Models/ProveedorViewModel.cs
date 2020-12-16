using FacturasCtrl.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace FacturasCtrl.Web.Models
{
    public class ProveedorViewModel: Proveedor
    {
        public int FacturaId { get; set; }

        [Display(Name = "Tipo")]

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int TipproveesId { get; set; }

        public IEnumerable<SelectListItem> Tipprovee { get; set; }


    }
}
