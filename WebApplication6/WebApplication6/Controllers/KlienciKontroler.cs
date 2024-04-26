using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using NuGet.DependencyResolver;
using WebApplication6.Context;
using WebApplication6.Models;
using Dapper;

namespace WebApplication6.Controllers
{
    public class KlienciKontroler : Controller
    {
        private readonly ApplicationDbContext _context;

        public KlienciKontroler(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KlienciKontroler
        public async Task<IActionResult> Index()
        {
            return _context.Klient != null ?
                        View(await _context.Klient.ToListAsync()) :
                        Problem("Entity set 'Polaczenie.Klienci'  is null.");
        }

        // GET: KlienciKontroler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var tabela = await _context.Klient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabela == null)
            {
                return NotFound();
            }

            return View(tabela);
        }

        // GET: KlienciKontroler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KlienciKontroler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Pesel,BirthYear,Płeć")] Klienci tabela)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabela);
        }

        // GET: KlienciKontroler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var tabela = await _context.Klient.FindAsync(id);
            if (tabela == null)
            {
                return NotFound();
            }
            return View(tabela);
        }

        // POST: KlienciKontroler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Pesel,BirthYear,Płeć")] Klienci tabela)
        {
            if (id != tabela.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelaExists(tabela.Id))
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
            return View(tabela);
        }

        // GET: KlienciKontroler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var tabela = await _context.Klient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabela == null)
            {
                return NotFound();
            }

            return View(tabela);
        }

        // POST: KlienciKontroler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Klient == null)
            {
                return Problem("Entity set 'Polaczenie.Klienci'  is null.");
            }
            var tabela = await _context.Klient.FindAsync(id);
            if (tabela != null)
            {
                _context.Klient.Remove(tabela);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelaExists(int id)
        {
            return (_context.Klient?.Any(e => e.Id == id)).GetValueOrDefault();
        }

       
        }


    }
    

