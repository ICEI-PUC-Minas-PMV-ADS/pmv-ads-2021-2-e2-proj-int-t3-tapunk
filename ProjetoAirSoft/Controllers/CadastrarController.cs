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
    public class CadastrarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastrarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cadastrar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cadastrar.ToListAsync());
        }

        // GET: Cadastrar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastrar = await _context.Cadastrar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastrar == null)
            {
                return NotFound();
            }

            return View(cadastrar);
        }

        // GET: Cadastrar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadastrar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Apelido,Idade,Email,Senha,Cidade,UF")] Cadastrar cadastrar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastrar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastrar);
        }

        // GET: Cadastrar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastrar = await _context.Cadastrar.FindAsync(id);
            if (cadastrar == null)
            {
                return NotFound();
            }
            return View(cadastrar);
        }

        // POST: Cadastrar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Apelido,Idade,Email,Senha,Cidade,UF")] Cadastrar cadastrar)
        {
            if (id != cadastrar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastrar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastrarExists(cadastrar.Id))
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
            return View(cadastrar);
        }

        // GET: Cadastrar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastrar = await _context.Cadastrar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastrar == null)
            {
                return NotFound();
            }

            return View(cadastrar);
        }

        // POST: Cadastrar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastrar = await _context.Cadastrar.FindAsync(id);
            _context.Cadastrar.Remove(cadastrar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastrarExists(int id)
        {
            return _context.Cadastrar.Any(e => e.Id == id);
        }
    }
}
