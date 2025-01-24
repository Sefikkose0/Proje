using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents
{
	public class _PortfolioComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
