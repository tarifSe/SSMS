using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SSMS.DatabaseContext;
using SSMS.Models;

namespace SSMS.Controllers
{
    public class MyTestModelsController : Controller
    {
        private readonly SSMSDbContext _context;

        public MyTestModelsController(SSMSDbContext context)
        {
            _context = context;
        }

        // GET: MyTestModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.myTestModels.ToListAsync());
        }

        // GET: MyTestModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myTestModel = await _context.myTestModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myTestModel == null)
            {
                return NotFound();
            }

            return View(myTestModel);
        }

        // GET: MyTestModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyTestModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Roll,Class")] MyTestModel myTestModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myTestModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myTestModel);
        }

        // GET: MyTestModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myTestModel = await _context.myTestModels.FindAsync(id);
            if (myTestModel == null)
            {
                return NotFound();
            }
            return View(myTestModel);
        }

        // POST: MyTestModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Roll,Class")] MyTestModel myTestModel)
        {
            if (id != myTestModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myTestModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyTestModelExists(myTestModel.Id))
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
            return View(myTestModel);
        }

        // GET: MyTestModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myTestModel = await _context.myTestModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myTestModel == null)
            {
                return NotFound();
            }

            return View(myTestModel);
        }

        // POST: MyTestModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myTestModel = await _context.myTestModels.FindAsync(id);
            _context.myTestModels.Remove(myTestModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyTestModelExists(int id)
        {
            return _context.myTestModels.Any(e => e.Id == id);
        }
    }
}
