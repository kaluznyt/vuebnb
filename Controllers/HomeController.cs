using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using vuebnb.Models;
using vuebnb.Repositories;

namespace vuebnb.Controllers {
    public class HomeController : Controller {
        //private readonly ListingRepository repository;

        // public HomeController (ListingRepository repository) {
        //     this.repository = repository;
        // }

        public IActionResult Error () {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View ();
        }
    }
}