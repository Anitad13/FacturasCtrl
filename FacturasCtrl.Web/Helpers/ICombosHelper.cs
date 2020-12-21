using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FacturasCtrl.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboTipprovees();
    }
}