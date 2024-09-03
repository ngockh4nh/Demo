using Demo.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Models
{
	public class NavBar : ViewComponent
	{
		private readonly DemoContext _context;

		public NavBar(DemoContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke() 
		{
			return View(_context.Category.ToList());
		}
	}
}
