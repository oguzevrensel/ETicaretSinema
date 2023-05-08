using ETicaret.Data;
using ETicaret.Data.Services;
using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class ActorsController : Controller
    {

        readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            ModelState.Remove("Actors_Movies");
            if (!ModelState.IsValid)
                return View(actor);

            await _service.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return NotFound();

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var detail = await _service.GetByIdAsync(id);
            if (detail is null) return NotFound();

            return View(detail);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor is null) return NotFound();

            return View(actor);
        }

        [HttpPost]
        public IActionResult Edit(Actor actor)
        {
            ModelState.Remove("Actors_Movies");
            if (!ModelState.IsValid)
                return View(actor);

            _service.UpdateAsync(actor);
            return RedirectToAction(nameof(Index));
        }

    }
}