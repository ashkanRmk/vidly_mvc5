using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 1, Name = "Wall-E"},
                new Movie {Id = 1, Name = "Red 2"},
                new Movie {Id = 1, Name = "Matrix"}
            };

            return View(movies);
        }

    }
}