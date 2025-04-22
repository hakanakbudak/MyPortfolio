using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
	public class _TestimonialComponentPartial : ViewComponent
	{
		MyPortfolioContext _context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
		{
			var values = _context.Testimonials.ToList();
			return View(values);
		}
	}
}
