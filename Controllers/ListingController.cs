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
    [Produces ("application/json")]
    [Route ("/Listing")]
    public class ListingController : Controller {
        private readonly IRepository<Listing> repository;

        public ListingController (IRepository<Listing> repository) {
            this.repository = repository;
        }

        // GET: api/Listings
        [HttpGet]
        public async Task<IEnumerable<Listing>> GetListings () {
            return await repository.Get ();
        }

        // GET: Listing/5
        [HttpGet ("{id}")]
        public async Task<IActionResult> GetListing ([FromRoute] int id) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var listing = await repository.GetByID (id);

            if (listing == null) {
                return NotFound ();
            }

            var viewModel = new GenericViewModel<Listing> {
                Data = listing,
                Metadata = new Metadata {
                Path = "/listing"
                }
            };

            return View (viewModel);
        }

        public async Task<IActionResult> GetListingSummaries () {
            return Ok ();
        }
    }
}