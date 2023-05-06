using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Data;

namespace Tickets.Controllers
{
	public class ActorsController : Controller
	{
		private readonly AppDbContext _context;

		public ActorsController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var data = _context.Actors.ToList();
			return View();
		}
	}
}
