using GameCatalogue.Application.DTOs;
using GameCatalogue.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GameCatalogue.WebUI.Controllers
{
    [Authorize]
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

        [HttpGet()]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PlatformDTO platform) 
        {
            if (ModelState.IsValid) 
            {
                await _platformService.Add(platform);
                return RedirectToAction(nameof(Index));
            }
            return View(platform);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id) 
        {
            if (id == null) return NotFound();
            var platformDto = await _platformService.GetById(id);
            if (platformDto == null) return NotFound();
            return View(platformDto);
        }

        [HttpPost()]
        public async Task<IActionResult> Edit(PlatformDTO platformDTO) 
        {
            if (ModelState.IsValid) 
            {
                try
                {
                    await _platformService.Update(platformDTO);
                }
                catch (Exception) 
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(platformDTO);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet()]
        public async Task<ActionResult> Delete(int? id) 
        {
            if (id == null) return NotFound();
            var platformDto = await _platformService.GetById(id);
            if (platformDto == null) return NotFound();
            return View(platformDto);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id) 
        {
            await _platformService.Remove(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id) 
        {
            if (id == null) return NotFound();
            var platformDto = await _platformService.GetById(id);
            if (platformDto == null) return NotFound();
            return View(platformDto);
        }
    }
}
