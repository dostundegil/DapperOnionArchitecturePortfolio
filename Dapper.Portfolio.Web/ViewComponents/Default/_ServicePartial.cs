using Dapper.Portfolio.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.ViewComponents.Default
{
	public class _ServicePartial:ViewComponent
	{
		private readonly IServiceAppService _serviceAppService;

		public _ServicePartial(IServiceAppService serviceAppService)
		{
			_serviceAppService = serviceAppService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _serviceAppService.GetListAsync();

			return View(values);
		}
	}
}
