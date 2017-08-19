using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var genre = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel()
            {
                Genres = genre
            };

            return View("MovieForm", viewModel);
        }

        // GET: Movies

        public ActionResult Index()
        {
            if (User.IsInRole("CanManageMovies"))
                return View("ReadOnlyList");
            return View("List");
        }  

        public ActionResult Details(int id)
        {
            var movies = _context.movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            return View(movies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }
    }
}