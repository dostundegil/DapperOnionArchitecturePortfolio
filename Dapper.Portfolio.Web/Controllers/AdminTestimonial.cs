using Dapper.Portfolio.Application.Dtos;
using Dapper.Portfolio.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Portfolio.Web.Controllers
{
    public class AdminTestimonial : Controller
    {
        private readonly ITestimonialAppService _appService;

        public AdminTestimonial(ITestimonialAppService appService)
        {
            _appService = appService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _appService.GetListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TestimonialDto dto)
        {
            await _appService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _appService.GetAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TestimonialDto dto)
        {
            await _appService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _appService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
