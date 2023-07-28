using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.ViewComponents.Default
{
	public class _SimplebannerPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
