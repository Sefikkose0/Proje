using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents
{
	public class _FooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
