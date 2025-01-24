using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;

namespace webprojesi.ViewComponents
{
	public class _FeatureComponentPartial:ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Ozellikler.ToList();
			return View(values);
		}
	}
}
