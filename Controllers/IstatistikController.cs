using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;

namespace webprojesi.Controllers
{
	public class IstatistikController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Yetenekler.Count();
			ViewBag.v2 = context.Mesajlar.Count();
			ViewBag.v3 = context.Mesajlar.Where(x => x.Okundumu == false).Count();
			ViewBag.v4 = context.Mesajlar.Where(x => x.Okundumu == true).Count();
			ViewBag.v5 = context.SosyalMedyalar.Count();
			ViewBag.v6 = context.Referanslar.Count();
			ViewBag.v7 = context.Ozellikler.Count();
			ViewBag.v8 = context.Iletisimler.Count();
			return View();
		}
	}
}
