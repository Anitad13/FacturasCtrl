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
    public class TipodocumsController : Controller
    {
        private readonly DataContext _context;

        public TipodocumsController(DataContext context)
        {
            _context = context;
        }

        // GET: Tipodocums
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tipodocums.ToListAsync());
        }

        // GET: Tipodocums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipodocum = await _context.Tipodocums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipodocum == null)
            {
                return NotFound();
            }

            return View(tipodocum);
        }

        // GET: Tipodocums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipodocums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tdtipo,Tdcodfid")] Tipodocum tipodocum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipodocum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipodocum);
        }

        // GET: Tipodocums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipodocum = await _context.Tipodocums.FindAsync(id);
            if (tipodocum == null)
            {
                return NotFound();
            }
            return View(tipodocum);
        }

        // POST: Tipodocums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tdtipo,Tdcodfid")] Tipodocum tipodocum)
        {
            if (id != tipodocum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipodocum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipodocumExists(tipodocum.Id))
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
            return View(tipodocum);
        }

        // GET: Tipodocums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipodocum = await _context.Tipodocums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipodocum == null)
            {
                return NotFound();
            }

            return View(tipodocum);
        }

        // POST: Tipodocums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipodocum = await _context.Tipodocums.FindAsync(id);
            _context.Tipodocums.Remove(tipodocum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipodocumExists(int id)
        {
            return _context.Tipodocums.Any(e => e.Id == id);
        }
    }
}
