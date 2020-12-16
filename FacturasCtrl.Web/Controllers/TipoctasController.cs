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
    public class TipoctasController : Controller
    {
        private readonly DataContext _context;

        public TipoctasController(DataContext context)
        {
            _context = context;
        }

        // GET: Tipoctas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tipoctas.ToListAsync());
        }

        // GET: Tipoctas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipocta = await _context.Tipoctas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipocta == null)
            {
                return NotFound();
            }

            return View(tipocta);
        }

        // GET: Tipoctas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipoctas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipnombre,Tipcodfidu")] Tipocta tipocta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipocta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipocta);
        }

        // GET: Tipoctas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipocta = await _context.Tipoctas.FindAsync(id);
            if (tipocta == null)
            {
                return NotFound();
            }
            return View(tipocta);
        }

        // POST: Tipoctas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipnombre,Tipcodfidu")] Tipocta tipocta)
        {
            if (id != tipocta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipocta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoctaExists(tipocta.Id))
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
            return View(tipocta);
        }

        // GET: Tipoctas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipocta = await _context.Tipoctas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipocta == null)
            {
                return NotFound();
            }

            return View(tipocta);
        }

        // POST: Tipoctas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipocta = await _context.Tipoctas.FindAsync(id);
            _context.Tipoctas.Remove(tipocta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoctaExists(int id)
        {
            return _context.Tipoctas.Any(e => e.Id == id);
        }
    }
}
