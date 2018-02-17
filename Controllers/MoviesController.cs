using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Scope;
using MovieBuff.Models;
using MovieBuff.ViewModels;

namespace MovieBuff.Controllers
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
	        //base.Dispose(disposing);
	    }

		//
		// GET: /Movies/
		public ActionResult Index()
		{
		    //var movies = GetMovies();
		    var movies = _context.Movies.Include(m => m.Genre).ToList();
		    //var movies = _context.Movies.ToList();
		    return View(movies);
		    //return View();
		}

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            } else
            {
                var movieDB = _context.Movies.Single(m => m.Id == movie.Id);
                movieDB.GenreId = movie.GenreId;
                movieDB.Name = movie.Name;
                movieDB.ReleaseDate = movie.ReleaseDate;
                movieDB.NumberInStock = movie.NumberInStock;
            }
            Console.WriteLine(movie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

	    public ActionResult Details(int id)
	    {
	        var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

	        if (movie == null)
	        {
	            return HttpNotFound();
	        }

	        return View(movie);
	    }

		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek!"};
			var customers = new List<Customer>
			{
				new Customer{ Id = 1, Name = "Customer 1"},
				new Customer{ Id = 2, Name = "Customer 2"}
			};

			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};

			return View(viewModel);
			//return Content("Hello, wolrld!");
			//return HttpNotFound();
			//return new EmptyResult();
			//return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

		}


		public ActionResult Edit(int id)
		{
			//return Content("id=" + id);
            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            var genre = _context.Genres.ToList();

            var viewController = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genre

            };

            return View("MovieForm", viewController);

		}

		// mvcaction4 then tab
		[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{

			return Content(year + "/" + month);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie { Id = 1, Name = "Shrek"},
				new Movie { Id = 2, Name = "Finding Nemo"},
				new Movie { Id = 3, Name = "Monsters Inc."}
			};
		}


	}
}