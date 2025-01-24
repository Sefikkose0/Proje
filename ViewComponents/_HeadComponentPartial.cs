using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents
{
	public class _HeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
