using GameCatalogue.Application.DTOs;
using GameCatalogue.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameCatalogue.WebUI.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IPlatformService _platformService;

        public GamesController(IGameService gameService, IPlatformService platformService)
        {
            _gameService = gameService;
            _platformService = platformService;
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
    }
}