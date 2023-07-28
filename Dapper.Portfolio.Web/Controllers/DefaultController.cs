using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
