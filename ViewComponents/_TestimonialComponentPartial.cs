using Microsoft.AspNetCore.Mvc;

namespace webprojesi.ViewComponents
{
	public class _TestimonialComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
