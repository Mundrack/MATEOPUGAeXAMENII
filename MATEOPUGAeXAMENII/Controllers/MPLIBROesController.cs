using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MATEOPUGAeXAMENII.Data;
using MATEOPUGAeXAMENII.Models;

namespace MATEOPUGAeXAMENII.Controllers
{
    public class MPLIBROesController : Controller
    {
        private readonly MATEOPUGAeXAMENIIContext _context;

        public MPLIBROesController(MATEOPUGAeXAMENIIContext context)
        {
            _context = context;
        }

        // GET: MPLIBROes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MPLIBRO.ToListAsync());
        }

        // GET: MPLIBROes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mPLIBRO = await _context.MPLIBRO
                .FirstOrDefaultAsync(m => m.MP_LibroID == id);
            if (mPLIBRO == null)
            {
                return NotFound();
            }

            return View(mPLIBRO);
        }

        // GET: MPLIBROes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MPLIBROes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MP_LibroID,MP_NombreLibro,MP_Autor,MP_HoraAgregacion,MP_FechaPublicacion,MP_Nuevo")] MPLIBRO mPLIBRO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mPLIBRO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mPLIBRO);
        }

        // GET: MPLIBROes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mPLIBRO = await _context.MPLIBRO.FindAsync(id);
            if (mPLIBRO == null)
            {
                return NotFound();
            }
            return View(mPLIBRO);
        }

        // POST: MPLIBROes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MP_LibroID,MP_NombreLibro,MP_Autor,MP_HoraAgregacion,MP_FechaPublicacion,MP_Nuevo")] MPLIBRO mPLIBRO)
        {
            if (id != mPLIBRO.MP_LibroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mPLIBRO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MPLIBROExists(mPLIBRO.MP_LibroID))
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
            return View(mPLIBRO);
        }

        // GET: MPLIBROes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mPLIBRO = await _context.MPLIBRO
                .FirstOrDefaultAsync(m => m.MP_LibroID == id);
            if (mPLIBRO == null)
            {
                return NotFound();
            }

            return View(mPLIBRO);
        }

        // POST: MPLIBROes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mPLIBRO = await _context.MPLIBRO.FindAsync(id);
            if (mPLIBRO != null)
            {
                _context.MPLIBRO.Remove(mPLIBRO);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MPLIBROExists(int id)
        {
            return _context.MPLIBRO.Any(e => e.MP_LibroID == id);
        }
    }
}
