﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
	public class _SkillComponentPartial : ViewComponent
	{
		MyPortfolioContext _context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
		{
			var values = _context.Skills.ToList();
			return View(values);
		}
	}
}
