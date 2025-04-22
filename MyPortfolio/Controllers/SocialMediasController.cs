using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialMediasController : Controller
    {
		MyPortfolioContext _context = new MyPortfolioContext();

		public IActionResult SocialMediasList()
		{
			var values = _context.SocialMedias.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateSocialMedias()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateSocialMedias(SocialMedia experience)
		{
			_context.SocialMedias.Add(experience);
			_context.SaveChanges();
			return RedirectToAction("SocialMediasList");
		}

		public IActionResult DeleteSocialMedias(int id)
		{
			var value = _context.SocialMedias.Find(id);
			_context.SocialMedias.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("SocialMediasList");
		}

		[HttpGet]
		public IActionResult UpdateSocialMedias(int id)
		{
			var value = _context.Experiences.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateSocialMedias(SocialMedia experience)
		{
			_context.SocialMedias.Update(experience);
			_context.SaveChanges();
			return RedirectToAction("SocialMediasList");
		}
	}
}
