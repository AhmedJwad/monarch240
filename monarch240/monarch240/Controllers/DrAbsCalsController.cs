using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using monarch240.Models;


namespace monarch240.Controllers
{
    public class DrAbsCalsController : Controller
    {
        private readonly DbaccessContext _context;

        public DrAbsCalsController(DbaccessContext context)
        {
            _context = context;
        }

        // GET: DrAbsCals
        public async Task<IActionResult> Index(
                    string sortOrder,
                    string currentFilter,
                    string searchString,
                    int? pageNumber)
                {
                    ViewData["CurrentSort"] = sortOrder;
                    ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                    ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

                    if (searchString != null)
                    {
                        pageNumber = 1;
                    }
                    else
                    {
                        searchString = currentFilter;
                    }

                    ViewData["CurrentFilter"] = searchString;

                    var drAbsCals = from s in _context.DrAbsCals
                                   select s;
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        drAbsCals = drAbsCals.Where(s => s.TestName.Contains(searchString)
                                               || s.TestName.Contains(searchString));
                    }
                    switch (sortOrder)
                    {
                        case "name_desc":
                            drAbsCals = drAbsCals.OrderByDescending(s => s.TestName);
                            break;
                        case "Date":
                            drAbsCals = drAbsCals.OrderBy(s => s.TestDate);
                            break;
                        case "date_desc":
                            drAbsCals = drAbsCals.OrderByDescending(s => s.BackInt1);
                            break;
                        default:
                            drAbsCals = drAbsCals.OrderBy(s => s.BackStr2);
                            break;
                    }

                    int pageSize = 10;
                    return View(await PaginatedList<DrAbsCal>.CreateAsync(drAbsCals.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
       

        // GET: DrAbsCals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DrAbsCals == null)
            {
                return NotFound();
            }

            var drAbsCal = await _context.DrAbsCals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drAbsCal == null)
            {
                return NotFound();
            }

            return View(drAbsCal);
        }

        // GET: DrAbsCals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrAbsCals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( DrAbsCal drAbsCal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drAbsCal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drAbsCal);
        }

        // GET: DrAbsCals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DrAbsCals == null)
            {
                return NotFound();
            }

            var drAbsCal = await _context.DrAbsCals.FindAsync(id);
            if (drAbsCal == null)
            {
                return NotFound();
            }
            return View(drAbsCal);
        }

        // POST: DrAbsCals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TestId,TestName,TestCupNo,TestCyc,StdId,Count,AdWaveP,Pvalue,AdWaveS,Svalue,ValueFlag,TestDate,TestTime,BackStr1,BackStr2,BackInt1,BackInt2")] DrAbsCal drAbsCal)
        {
            if (id != drAbsCal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drAbsCal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrAbsCalExists(drAbsCal.Id))
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
            return View(drAbsCal);
        }

        // GET: DrAbsCals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DrAbsCals == null)
            {
                return NotFound();
            }

            var drAbsCal = await _context.DrAbsCals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drAbsCal == null)
            {
                return NotFound();
            }

            return View(drAbsCal);
        }

        // POST: DrAbsCals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DrAbsCals == null)
            {
                return Problem("Entity set 'DbaccessContext.DrAbsCals'  is null.");
            }
            var drAbsCal = await _context.DrAbsCals.FindAsync(id);
            if (drAbsCal != null)
            {
                _context.DrAbsCals.Remove(drAbsCal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrAbsCalExists(int id)
        {
          return (_context.DrAbsCals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
