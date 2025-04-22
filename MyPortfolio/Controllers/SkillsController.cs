using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SkillsController : Controller
    {
		MyPortfolioContext _context = new MyPortfolioContext();

		public IActionResult SkillsList()
		{
			var values = _context.Skills.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateSkill()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			_context.Skills.Add(skill);
			_context.SaveChanges();
			return RedirectToAction("SkillsList");
		}

		public IActionResult DeleteSkill(int id)
		{
			var value = _context.Skills.Find(id);
			_context.Skills.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("SkillsList");
		}

		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var value = _context.Skills.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			_context.Skills.Update(skill);
			_context.SaveChanges();
			return RedirectToAction("SkillsList");
		}

	}
}
