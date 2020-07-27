using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaraTIao.Data;
using ModelBaraTIao;

namespace BaraTIao.Controllers
{
    public class BairrosController : Controller
    {
        private readonly BaratiaoContext _context;

        public BairrosController(BaratiaoContext context)
        {
            _context = context;
        }

        // GET: Bairros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bairros.ToListAsync());
        }

        // GET: Bairros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bairro == null)
            {
                return NotFound();
            }

            return View(bairro);
        }

        // GET: Bairros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bairros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bairro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bairro);
        }

        // GET: Bairros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairros.FindAsync(id);
            if (bairro == null)
            {
                return NotFound();
            }
            return View(bairro);
        }

        // POST: Bairros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] Bairro bairro)
        {
            if (id != bairro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bairro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BairroExists(bairro.Id))
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
            return View(bairro);
        }

        // GET: Bairros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bairro = await _context.Bairros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bairro == null)
            {
                return NotFound();
            }

            return View(bairro);
        }

        // POST: Bairros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bairro = await _context.Bairros.FindAsync(id);
            _context.Bairros.Remove(bairro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BairroExists(int id)
        {
            return _context.Bairros.Any(e => e.Id == id);
        }
    }
}
