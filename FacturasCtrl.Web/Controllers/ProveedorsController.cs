using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FacturasCtrl.Web.Data;
using FacturasCtrl.Web.Data.Entities;

namespace FacturasCtrl.Web.Controllers
{
    public class ProveedorsController : Controller
    {
        private readonly DataContext _context;

        public ProveedorsController(DataContext context)
        {
            _context = context;
        }

        // GET: Proveedors
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Proveedors.Include(p => p.Ciudads).Include(p => p.Tipodocums);
            return View(await dataContext.ToListAsync());
        }

        // GET: Proveedors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = await _context.Proveedors
                .Include(p => p.Ciudads)
                .Include(p => p.Tipodocums)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        // GET: Proveedors/Create
        public IActionResult Create()
        {
            ViewData["CiudadId"] = new SelectList(_context.Ciudads, "Id", "Ciunombre");
            ViewData["TipoDocumId"] = new SelectList(_context.Tipodocums, "Id", "Tdtipo");
            return View();
        }

        // POST: Proveedors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipoDocumId,Pronticel,Prondigv,Pronombre,Prodirec,CiudadId,Protel1,Protel2,Promail,Procontac,Protipo,Proestad,Proclase,Prorut,Progran,Proauto,Profemes,Profedia,Proingre")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proveedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CiudadId"] = new SelectList(_context.Ciudads, "Id", "Ciunombre", proveedor.CiudadId);
            ViewData["TipoDocumId"] = new SelectList(_context.Tipodocums, "Id", "Tdtipo", proveedor.TipoDocumId);
            return View(proveedor);
        }

        // GET: Proveedors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = await _context.Proveedors.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }
            ViewData["CiudadId"] = new SelectList(_context.Ciudads, "Id", "Ciunombre", proveedor.CiudadId);
            ViewData["TipoDocumId"] = new SelectList(_context.Tipodocums, "Id", "Tdtipo", proveedor.TipoDocumId);
            return View(proveedor);
        }

        // POST: Proveedors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoDocumId,Pronticel,Prondigv,Pronombre,Prodirec,CiudadId,Protel1,Protel2,Promail,Procontac,Protipo,Proestad,Proclase,Prorut,Progran,Proauto,Profemes,Profedia,Proingre")] Proveedor proveedor)
        {
            if (id != proveedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proveedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProveedorExists(proveedor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CiudadId"] = new SelectList(_context.Ciudads, "Id", "Ciunombre", proveedor.CiudadId);
            ViewData["TipoDocumId"] = new SelectList(_context.Tipodocums, "Id", "Tdtipo", proveedor.TipoDocumId);
            return View(proveedor);
        }

        // GET: Proveedors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = await _context.Proveedors
                .Include(p => p.Ciudads)
                .Include(p => p.Tipodocums)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        // POST: Proveedors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proveedor = await _context.Proveedors.FindAsync(id);
            _context.Proveedors.Remove(proveedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProveedorExists(int id)
        {
            return _context.Proveedors.Any(e => e.Id == id);
        }
    }
}
