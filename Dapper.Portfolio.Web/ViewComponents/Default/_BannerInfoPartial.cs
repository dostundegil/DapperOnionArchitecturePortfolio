using Dapper.Portfolio.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.ViewComponents.Default
{
	public class _BannerInfoPartial:ViewComponent
	{
		private readonly IInfoAppService _infoAppService;

        public _BannerInfoPartial(IInfoAppService infoAppService)
        {
            _infoAppService = infoAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
            var values = await _infoAppService.GetListAsync();

            return View(values);
		}
	}
}
