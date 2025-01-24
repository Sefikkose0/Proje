using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial  : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
