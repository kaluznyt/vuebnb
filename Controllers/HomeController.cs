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
        private readonly ListingRepository repository;

        public HomeController (ListingRepository repository) {
            this.repository = repository;
        }
        public IActionResult Index () {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var listing = repository.GetListingSummaries ();

            if (listing == null) {
                return NotFound ();
            }

            var viewModel = new GenericViewModel<object> {
                Data = listing,
                Metadata = new Metadata {
                Path = "/"
                }
            };

            return View (viewModel);
        }

        public IActionResult Error () {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View ();
        }
    }
}