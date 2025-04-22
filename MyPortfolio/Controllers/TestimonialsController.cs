using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class TestimonialsController : Controller
    {
		MyPortfolioContext _context = new MyPortfolioContext();

		public IActionResult TestimonialsList()
		{
			var values = _context.Testimonials.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateTestimonials()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateTestimonials(Testimonial testimonial)
		{
			_context.Testimonials.Add(testimonial);
			_context.SaveChanges();
			return RedirectToAction("TestimonialsList");
		}

		public IActionResult DeleteTestimonials(int id)
		{
			var value = _context.Testimonials.Find(id);
			_context.Testimonials.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("TestimonialsList");
		}

		[HttpGet]
		public IActionResult UpdateTestimonials(int id)
		{
			var value = _context.Testimonials.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateTestimonials(Testimonial testimonial)
		{
			_context.Testimonials.Update(testimonial);
			_context.SaveChanges();
			return RedirectToAction("TestimonialsList");
		}
	}
}
