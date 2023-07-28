using Dapper.Portfolio.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.ViewComponents.Default
{
	public class _TestimonialPartial:ViewComponent
	{
		private readonly ITestimonialAppService _appService;

		public _TestimonialPartial(ITestimonialAppService appService)
		{
			_appService = appService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _appService.GetListAsync();

			return View(values);
		}
	}
}
