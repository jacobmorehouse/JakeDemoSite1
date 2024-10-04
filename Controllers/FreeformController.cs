using JakeDemoSite1.Data;
using JakeDemoSite1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JakeDemoSite1.Controllers
{
	public class FreeformController : Controller
	{
		private readonly DatabaseContext _context;

		public FreeformController(DatabaseContext context)
		{
			_context = context;
		}

		public async  Task<IActionResult> Index()
		{

			var x = _context.Employees.First();

			List<String> nEmployees = _context.Database.SqlQuery<string>(FormattableStringFactory.Create("select firstname || ' ' || lastname from Employees where lower(firstName) like '%n%'; ")).ToList();

			ViewBag.firstEmployee = x;
			ViewBag.nEmployees = nEmployees;

			return View();
		}
	}
}
