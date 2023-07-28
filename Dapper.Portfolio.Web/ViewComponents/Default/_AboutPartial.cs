using Dapper.Portfolio.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly ISkillAppService _skillAppService;

        public _AboutPartial(ISkillAppService skillAppService)
        {
            _skillAppService = skillAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _skillAppService.GetListAsync();

            return View(values);
        }
    }
}
