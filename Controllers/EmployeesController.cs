using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JakeDemoSite1.Data;
using JakeDemoSite1.Models;

namespace JakeDemoSite1.Controllers
{
	public class EmployeesController : Controller
	{
		private readonly DatabaseContext _context;

		public EmployeesController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: Employees
		public async Task<IActionResult> Index()
		{
			var databaseContext = _context.Employees.Include(e => e.ReportsToEmployee);
			return View(await databaseContext.ToListAsync());
		}

		// GET: Employees/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var employees = await _context.Employees
				.Include(e => e.ReportsToEmployee)
				.FirstOrDefaultAsync(m => m.EmployeeID == id);
			if (employees == null)
			{
				return NotFound();
			}

			return View(employees);
		}

		// GET: Employees/Create
		public IActionResult Create()
		{
			ViewData["ReportsToEmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "LastCommaFirst");
			return View();
		}

		// POST: Employees/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsToEmployeeID,PhotoPath")] Employees employees)
		{
			if (ModelState.IsValid)
			{
				_context.Add(employees);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["ReportsToEmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "LastCommaFirst", employees.ReportsToEmployeeID);
			return View(employees);
		}

		// GET: Employees/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var employees = await _context.Employees.FindAsync(id);
			if (employees == null)
			{
				return NotFound();
			}
			ViewData["ReportsToEmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "LastCommaFirst", employees.ReportsToEmployeeID);
			return View(employees);
		}

		// POST: Employees/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsToEmployeeID,PhotoPath")] Employees employees)
		{
			if (id != employees.EmployeeID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(employees);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!EmployeesExists(employees.EmployeeID))
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
			ViewData["ReportsToEmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", employees.ReportsToEmployeeID);
			return View(employees);
		}

		// GET: Employees/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var employees = await _context.Employees
				.Include(e => e.ReportsToEmployee)
				.FirstOrDefaultAsync(m => m.EmployeeID == id);
			if (employees == null)
			{
				return NotFound();
			}

			return View(employees);
		}

		// POST: Employees/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var employees = await _context.Employees.FindAsync(id);
			if (employees != null)
			{
				_context.Employees.Remove(employees);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool EmployeesExists(int id)
		{
			return _context.Employees.Any(e => e.EmployeeID == id);
		}
	}
}
