using GameCatalogue.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameCatalogue.WebUI.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly IPlatformService _platformService;

        public PlatformsController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var platforms = await _platformService.GetPlatforms();
            return View(platforms);
        }
    }
}
