using JakeDemoSite1.Data;
using JakeDemoSite1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JakeDemoSite1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DatabaseContext _context;

		public HomeController(ILogger<HomeController> logger, DatabaseContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			ViewBag.Employees = _context.Employees.ToList();

			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
