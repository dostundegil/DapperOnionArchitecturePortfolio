using Dapper.Portfolio.Application.Dtos;
using Dapper.Portfolio.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Dapper.Portfolio.Web.Controllers
{
    public class AdminInfoController : Controller
    {
        private readonly IInfoAppService _infoAppService;

        public AdminInfoController(IInfoAppService infoAppService)
        {
            _infoAppService = infoAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _infoAppService.GetAsync(1);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Index(InfoDto dto)
        {
            await _infoAppService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
    }
}
