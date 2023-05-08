using ETicaret.Data.Services;
using Microsoft.AspNetCore.Mvc;

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
    }
}