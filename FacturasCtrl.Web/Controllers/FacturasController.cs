﻿using System;
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
    public class FacturasController : Controller
    {
        private readonly DataContext _context;

        public FacturasController(DataContext context)
        {
            _context = context;
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Facturas.Include(f => f.Instruccionespagos).Include(f => f.Prioridads).Include(f => f.Proveedors);
            return View(await dataContext.ToListAsync());
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas
                .Include(f => f.Instruccionespagos)
                .Include(f => f.Prioridads)
                .Include(f => f.Proveedors)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            ViewData["InstruccionespagoId"] = new SelectList(_context.Instruccionespagos, "Id", "Concepto");
            ViewData["PrioridadId"] = new SelectList(_context.Prioridads, "Id", "Descripcion");
            ViewData["ProveedorId"] = new SelectList(_context.Proveedors, "Id", "Pronombre");
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Facplanilla,FechaRecibido,NoFactura,ProveedorId,Facvalsiniva,ValorDocumento,Concepto,FechadePago,InstruccionespagoId,InstruccionesEspeciales,DocumentoAnexo,CuentaOrigen,PrioridadId,ObservacionesDTA,ObservacionesDF,FechaPago,Facpago,Facsucursal,Facperrecib,Facanticipo,Facimpto,Facnomina")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InstruccionespagoId"] = new SelectList(_context.Instruccionespagos, "Id", "Concepto", factura.InstruccionespagoId);
            ViewData["PrioridadId"] = new SelectList(_context.Prioridads, "Id", "Descripcion", factura.PrioridadId);
            ViewData["ProveedorId"] = new SelectList(_context.Proveedors, "Id", "Pronombre", factura.ProveedorId);
            return View(factura);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            ViewData["InstruccionespagoId"] = new SelectList(_context.Instruccionespagos, "Id", "Concepto", factura.InstruccionespagoId);
            ViewData["PrioridadId"] = new SelectList(_context.Prioridads, "Id", "Descripcion", factura.PrioridadId);
            ViewData["ProveedorId"] = new SelectList(_context.Proveedors, "Id", "Pronombre", factura.ProveedorId);
            return View(factura);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Facplanilla,FechaRecibido,NoFactura,ProveedorId,Facvalsiniva,ValorDocumento,Concepto,FechadePago,InstruccionespagoId,InstruccionesEspeciales,DocumentoAnexo,CuentaOrigen,PrioridadId,ObservacionesDTA,ObservacionesDF,FechaPago,Facpago,Facsucursal,Facperrecib,Facanticipo,Facimpto,Facnomina")] Factura factura)
        {
            if (id != factura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturaExists(factura.Id))
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
            ViewData["InstruccionespagoId"] = new SelectList(_context.Instruccionespagos, "Id", "Concepto", factura.InstruccionespagoId);
            ViewData["PrioridadId"] = new SelectList(_context.Prioridads, "Id", "Descripcion", factura.PrioridadId);
            ViewData["ProveedorId"] = new SelectList(_context.Proveedors, "Id", "Pronombre", factura.ProveedorId);
            return View(factura);
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas
                .Include(f => f.Instruccionespagos)
                .Include(f => f.Prioridads)
                .Include(f => f.Proveedors)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);
            _context.Facturas.Remove(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturaExists(int id)
        {
            return _context.Facturas.Any(e => e.Id == id);
        }
    }
}
