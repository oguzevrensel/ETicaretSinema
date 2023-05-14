using ETicaret.Data.Services;
using ETicaret.Data.ViewModels;
using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETicaret.Controllers
{
    public class MoviesController : Controller
    {
        readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.Cinema);
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);
            return View(movie);
        }

        public async Task<IActionResult> Create()
        {

            var movieDdVm = await _service.GetMovieDropdownsVMValues();

            ViewBag.Cinemas = new SelectList(movieDdVm.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDdVm.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDdVm.Actors, "Id", "FullName");

            return View(new MovieVM());
        }


        [HttpPost]
        public async Task<IActionResult> Create(MovieVM movie)
        {

            if (!ModelState.IsValid)
            {
                var movieDdVm = await _service.GetMovieDropdownsVMValues();

                ViewBag.Cinemas = new SelectList(movieDdVm.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDdVm.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDdVm.Actors, "Id", "FullName");

                return View(movie);
            }

            await _service.AddMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var movies = await _service.GetAllAsync(n => n.Cinema);
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = movies
                    .Where(n => n.Name.Contains(searchString) || n.Description.Contains(searchString))
                    .ToList();
                return View("Index", filteredResult);
            }

            return View(movies);
        }
    }
}