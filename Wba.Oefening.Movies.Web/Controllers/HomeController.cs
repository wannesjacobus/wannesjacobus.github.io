using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Domain;
using Wba.Oefening.Movies.Web.Models;

namespace Wba.Oefening.Movies.Web.Controllers
{
    public class HomeController : Controller
    {
        MovieRepository movieRepo = new MovieRepository();

        public IActionResult Index()
        {
            var model = new HomeIndexMovieVm();
            model.Movies = movieRepo.GetMovies().ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/movies/{movieId}")]
        public IActionResult ShowMovie(string movieId)
        {
            var movies = movieRepo.GetMovies();
            var movie = movies.FirstOrDefault(i => i.Id.ToString() == movieId);
            var model = new HomeIndexMovieVm();
            model.Movies.Add(movie);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
