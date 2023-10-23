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
    public class DrAbsDatumsController : Controller
    {
        private readonly DbaccessContext _context;

        public DrAbsDatumsController(DbaccessContext context)
        {
            _context = context;
        }

        // GET: DrAbsDatums
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

            var drAbsData = from s in _context.DrAbsData
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                drAbsData = drAbsData.Where(s => s.TestName.Contains(searchString)
                                       || s.TestName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    drAbsData = drAbsData.OrderByDescending(s => s.TestName);
                    break;
                case "Date":
                    drAbsData = drAbsData.OrderBy(s => s.TestDate);
                    break;
                case "date_desc":
                    drAbsData = drAbsData.OrderByDescending(s => s.BackInt1);
                    break;
                default:
                    drAbsData = drAbsData.OrderBy(s => s.BackStr2);
                    break;
            }

            int pageSize = 10;
            return View(await PaginatedList<DrAbsDatum>.CreateAsync(drAbsData.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        // GET: DrAbsDatums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DrAbsData == null)
            {
                return NotFound();
            }

            var drAbsDatum = await _context.DrAbsData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drAbsDatum == null)
            {
                return NotFound();
            }

            return View(drAbsDatum);
        }

        // GET: DrAbsDatums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrAbsDatums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TestId,TestNo,TestName,TestCupNo,TestCyc,AdWaveP,Pvalue,AdWaveS,Svalue,ValueFlag,TestDate,TestTime,TestName1,SerumFlag,BackStr1,BackStr2,BackInt1,BackInt2,SsmaTimeStamp")] DrAbsDatum drAbsDatum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drAbsDatum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drAbsDatum);
        }

        // GET: DrAbsDatums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DrAbsData == null)
            {
                return NotFound();
            }

            var drAbsDatum = await _context.DrAbsData.FindAsync(id);
            if (drAbsDatum == null)
            {
                return NotFound();
            }
            return View(drAbsDatum);
        }

        // POST: DrAbsDatums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TestId,TestNo,TestName,TestCupNo,TestCyc,AdWaveP,Pvalue,AdWaveS,Svalue,ValueFlag,TestDate,TestTime,TestName1,SerumFlag,BackStr1,BackStr2,BackInt1,BackInt2,SsmaTimeStamp")] DrAbsDatum drAbsDatum)
        {
            if (id != drAbsDatum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drAbsDatum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrAbsDatumExists(drAbsDatum.Id))
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
            return View(drAbsDatum);
        }

        // GET: DrAbsDatums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DrAbsData == null)
            {
                return NotFound();
            }

            var drAbsDatum = await _context.DrAbsData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drAbsDatum == null)
            {
                return NotFound();
            }

            return View(drAbsDatum);
        }

        // POST: DrAbsDatums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DrAbsData == null)
            {
                return Problem("Entity set 'DbaccessContext.DrAbsData'  is null.");
            }
            var drAbsDatum = await _context.DrAbsData.FindAsync(id);
            if (drAbsDatum != null)
            {
                _context.DrAbsData.Remove(drAbsDatum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrAbsDatumExists(int id)
        {
          return (_context.DrAbsData?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
