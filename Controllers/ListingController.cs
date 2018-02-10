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
    public class ListingController : Controller {
        private readonly IListingRepository repository;

        public ListingController (IListingRepository repository) {
            this.repository = repository;
        }

        [HttpGet ("/api/listing/all")]
        public async Task<IEnumerable<Listing>> GetListingsApi () {
            return await repository.Get ();
        }

        [HttpGet ("/api/")]
        [HttpGet ("/api/listing/summaries")]
        public async Task<IEnumerable<object>> GetListingSummariesApi () {
            return await repository.GetListingSummaries ();
        }

        [HttpGet ("")]
        [HttpGet ("/listing/summaries")]
        public async Task<IActionResult> GetListingSummaries () {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var listing = await repository.GetListingSummaries ();

            if (listing == null) {
                return NotFound ();
            }

            var viewModel = new GenericViewModel<object> {
                Data = listing,
                Metadata = new Metadata {
                Path = "/"
                }
            };

            return View ("~/Views/Home/Index.cshtml", viewModel);
        }

        [HttpGet ("/api/listing/{id}")]
        public async Task<Listing> GetListingApi ([FromRoute] int id) {
            return await repository.GetByID (id);
        }

        [HttpGet ("/listing/{id}")]
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
    }
}