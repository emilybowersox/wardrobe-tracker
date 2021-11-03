using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WardrobeTracker.Data;
using WardrobeTracker.Models;

namespace WardrobeTracker.Controllers
{
    public class WardrobeItemsController : Controller
    {
        private readonly WardrobeDbContext _context;

        public WardrobeItemsController(WardrobeDbContext context)
        {
            _context = context;
        }

        // GET: WardrobeItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.WardrobeItem.ToListAsync());
        }

        // GET: WardrobeItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wardrobeItem = await _context.WardrobeItem
                .FirstOrDefaultAsync(m => m.ID == id);
            if (wardrobeItem == null)
            {
                return NotFound();
            }

            return View(wardrobeItem);
        }

        // GET: WardrobeItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WardrobeItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Type,LifestyleCategory,Store,Secondhand,Brand,PricePaid,RetailPrice,Fabric,PrimaryColor,DateBought")] WardrobeItem wardrobeItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wardrobeItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wardrobeItem);
        }

        // GET: WardrobeItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wardrobeItem = await _context.WardrobeItem.FindAsync(id);
            if (wardrobeItem == null)
            {
                return NotFound();
            }
            return View(wardrobeItem);
        }

        // POST: WardrobeItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Type,LifestyleCategory,Store,Secondhand,Brand,PricePaid,RetailPrice,Fabric,PrimaryColor,DateBought")] WardrobeItem wardrobeItem)
        {
            if (id != wardrobeItem.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wardrobeItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WardrobeItemExists(wardrobeItem.ID))
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
            return View(wardrobeItem);
        }

        // GET: WardrobeItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wardrobeItem = await _context.WardrobeItem
                .FirstOrDefaultAsync(m => m.ID == id);
            if (wardrobeItem == null)
            {
                return NotFound();
            }

            return View(wardrobeItem);
        }

        // POST: WardrobeItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wardrobeItem = await _context.WardrobeItem.FindAsync(id);
            _context.WardrobeItem.Remove(wardrobeItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WardrobeItemExists(int id)
        {
            return _context.WardrobeItem.Any(e => e.ID == id);
        }
    }
}
