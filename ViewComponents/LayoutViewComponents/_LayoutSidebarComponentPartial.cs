using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}


	}
}
