using GameCatalogue.Application.DTOs;
using GameCatalogue.Application.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Threading.Tasks;

namespace GameCatalogue.WebUI.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IPlatformService _platformService;
        private readonly IWebHostEnvironment _enviroment;

        public GamesController(IGameService gameService, IPlatformService platformService, IWebHostEnvironment environment)
        {
            _gameService = gameService;
            _platformService = platformService;
            _enviroment = environment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var games = await _gameService.GetGames();
            return View(games);
        }

        [HttpGet()]
        public async Task<IActionResult> Create() 
        {
            ViewBag.PlatformId = new SelectList(await _platformService.GetPlatforms(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GameDTO gameDTO)
        {
            if (ModelState.IsValid)
            {
                await _gameService.Add(gameDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(gameDTO);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var gameDto = await _gameService.GetById(id);
            if (gameDto == null) return NotFound();
            var platforms = await _platformService.GetPlatforms();

            ViewBag.PlatformId = new SelectList(platforms, "Id", "Name", gameDto.PlatformId);
            return View(gameDto);
        }

        [HttpPost()]
        public async Task<IActionResult> Edit(GameDTO gameDTO)
        {
            if (ModelState.IsValid)
            {
                await _gameService.Update(gameDTO);
                return RedirectToAction(nameof(Index));
            }

            return View(gameDTO);
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(int? id) 
        {
            if (id == null) return NotFound();
            var gameDto = await _gameService.GetById(id);
            if (gameDto == null) return NotFound();
            return View(gameDto);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id) 
        {
            await _gameService.Remove(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id) 
        {
            if (id == null) return NotFound();
            var gameDto = await _gameService.GetById(id);
            if (gameDto == null) return NotFound();

            var wwwroot = _enviroment.WebRootPath;
            var image = Path.Combine(wwwroot, "images\\" + gameDto.Image);
            var exists = System.IO.File.Exists(image);
            ViewBag.ImageExist = exists;
            return View(gameDto);
        }
    }
}