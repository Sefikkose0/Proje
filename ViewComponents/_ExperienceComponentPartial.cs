using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;

namespace webprojesi.ViewComponents
{
	public class _ExperienceComponentPartial : ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Deneyimler.ToList();
			return View(values);
		}
	}
}
