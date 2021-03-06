using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleDeFuncionariosMVC.Data;
using ControleDeFuncionariosMVC.Models;

namespace ControleDeFuncionariosMVC.Controllers
{
    public class CargoesController : Controller
    {
        private readonly Contexto _context;

        public CargoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Cargoes
        public async Task<IActionResult> Index()
        {
              return _context.Cargo != null ? 
                          View(await _context.Cargo.ToListAsync()) :
                          Problem("Entity set 'Contexto.Cargo'  is null.");
        }

        // GET: Cargoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cargo == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargo
                .FirstOrDefaultAsync(m => m.CargoId == id);
            if (cargo == null)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // GET: Cargoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cargoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CargoId,NomeCargo,Situacao")] Cargo cargo)
        {           
                _context.Add(cargo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        
                return View(cargo);
        }

        // GET: Cargoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cargo == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargo.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }
            return View(cargo);
        }

        // POST: Cargoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CargoId,NomeCargo,Situacao")] Cargo cargo)
        {
            if (id != cargo.CargoId)
            {
                return NotFound();
            }

           // if (ModelState.IsValid)
           // {
                try
                {
                    _context.Update(cargo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargoExists(cargo.CargoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
           // }
            return View(cargo);
        }

        // GET: Cargoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cargo == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargo
                .FirstOrDefaultAsync(m => m.CargoId == id);
            if (cargo == null)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // POST: Cargoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cargo == null)
            {
                return Problem("Entity set 'Contexto.Cargo'  is null.");
            }
            var cargo = await _context.Cargo.FindAsync(id);
            if (cargo != null)
            {
                _context.Cargo.Remove(cargo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CargoExists(int id)
        {
          return (_context.Cargo?.Any(e => e.CargoId == id)).GetValueOrDefault();
        }
    }
}
