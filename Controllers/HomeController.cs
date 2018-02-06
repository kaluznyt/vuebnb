using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vuebnb.Models;

namespace vuebnb.Controllers {
    public class HomeController : Controller {
        private readonly ListingContext _context;

        public HomeController (ListingContext context) {
            this._context = context;

        }
        public IActionResult Index () {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var listing = _context.Listings.Select (l => new {
                title = l.Title,
                    id = l.Id,
                    address = l.Address,
                    price_per_night = l.PricePerNight,
                    thumb = l.Thumbnail
            });

            if (listing == null) {
                return NotFound ();
            }

            return View (listing);
        }

        public IActionResult Error () {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View ();
        }
    }
}