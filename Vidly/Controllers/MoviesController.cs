using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Shrek!" };

            return View(movie);
        }

        

        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format($"pageIndex={pageIndex} & sortBy = {sortBy}"));
            //http: //localhost:4704/movies?pageIndex=99&sortby=release%20date
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
    



}