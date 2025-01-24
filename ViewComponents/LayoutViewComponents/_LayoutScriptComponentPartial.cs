using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
