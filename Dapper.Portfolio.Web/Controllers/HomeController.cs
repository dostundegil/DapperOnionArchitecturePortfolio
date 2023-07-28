using Dapper.Portfolio.Application.Dtos;
using Dapper.Portfolio.Application.Services;
using Dapper.Portfolio.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dapper.Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISkillAppService _skillAppService;
        public HomeController(ILogger<HomeController> logger, ISkillAppService skillAppService)
        {
            _logger = logger;
            _skillAppService = skillAppService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _skillAppService.GetListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSkill(SkillDto dto)
        {
            await _skillAppService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSkill(int id)
        {
            var skill = await _skillAppService.GetAsync(id);
            return View(skill);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSkill(SkillDto dto)
        {
            await _skillAppService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}