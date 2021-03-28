using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie {FilmName = "Shrek"});
            movies.Add(new Movie { FilmName = "Dom z papieru" });


            return View(movies);
        }
        public ActionResult Info(int id)
        {
            return Content ("id=" + id);
        }
    }
}