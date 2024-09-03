using Demo.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Models
{
	public class SideBar : ViewComponent
	{
		private readonly DemoContext _context;

		public SideBar(DemoContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
