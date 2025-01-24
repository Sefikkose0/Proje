using Microsoft.AspNetCore.Mvc;
using webprojesi.DAL.Context;

namespace webprojesi.ViewComponents
{
	public class _AboutComponentPartial:ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.aboutTitle = portfolioContext.Hakkındakiler.Select(x =>x.Baslik).FirstOrDefault();
		    ViewBag.aboutAltAciklama = portfolioContext.Hakkındakiler.Select(x =>x.AltAciklama).FirstOrDefault();
			ViewBag.aboutDetaylar = portfolioContext.Hakkındakiler.Select(x => x.Detaylar).FirstOrDefault();
			return View();
		}

	}
}
