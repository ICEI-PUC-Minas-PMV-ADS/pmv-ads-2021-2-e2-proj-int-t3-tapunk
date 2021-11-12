using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoAirSoft.Models;

namespace ProjetoAirSoft.Controllers
{
    public class EquipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Equipes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Equipes.ToListAsync());
        }

        // GET: Equipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipes == null)
            {
                return NotFound();
            }

            return View(equipes);
        }

        // GET: Equipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomedaEquipe,Pais,Uf,Cidade,Membro01,Membro02,Membro03,Membro04,Membro05,Membro06,HistoriadaEquipe")] Equipes equipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipes);
        }

        // GET: Equipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes.FindAsync(id);
            if (equipes == null)
            {
                return NotFound();
            }
            return View(equipes);
        }

        // POST: Equipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomedaEquipe,Pais,Uf,Cidade,Membro01,Membro02,Membro03,Membro04,Membro05,Membro06,HistoriadaEquipe")] Equipes equipes)
        {
            if (id != equipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipesExists(equipes.Id))
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
            return View(equipes);
        }

        // GET: Equipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipes == null)
            {
                return NotFound();
            }

            return View(equipes);
        }

        // POST: Equipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipes = await _context.Equipes.FindAsync(id);
            _context.Equipes.Remove(equipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipesExists(int id)
        {
            return _context.Equipes.Any(e => e.Id == id);
        }
    }
}
