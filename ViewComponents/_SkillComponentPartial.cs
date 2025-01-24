using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;

namespace webprojesi.ViewComponents
{
	public class _SkillComponentPartial:ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Yetenekler.ToList();
			return View(values);
		}
	}
}
