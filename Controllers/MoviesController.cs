using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
//using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shreik!" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer { Name = "Customer 1" },
        //        new Customer { Name = "Customerr 2" } };

        //    var viewModel = new RandomoMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers

        //    };

        //    return View( movie );
        //    //return View(movie);
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        //}
        public ActionResult Edit( int id )
        {
            return Content("id=" + id);
        }

        public ActionResult ByReleaseDate( int year, int month )
        {
            return Content(year + "/" + month);
        }
    }
}