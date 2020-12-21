using FacturasCtrl.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturasCtrl.Web.Helpers
{
    public class CombosHelper:ICombosHelper
    {
        private readonly DataContext _dataContext;

    public CombosHelper(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

   
        public IEnumerable<SelectListItem> GetComboTipprovees()
        {
            var list = _dataContext.Tipprovees.Select(p => new SelectListItem
            {
                Text = p.Tipnombre,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select an Type...)",
                Value = "0"
            });

            return list;
        }
    }
}
