using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visly.Models;

namespace Visly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek !!!", Id = 1 };
            return View(movie);
        }
    }
}
