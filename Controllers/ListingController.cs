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
        private readonly IRepository<Listing> repository;

        public ListingController (IRepository<Listing> repository) {
            this.repository = repository;
        }

        // GET: api/Listings
        [HttpGet ("/listing/api/all")]
        public async Task<IEnumerable<Listing>> GetListings () {
            return await repository.Get ();
        }

        [HttpGet ("/listing/api/summaries")]
        public async Task<IEnumerable<object>> GetListingSummariesApi () {
            return await ((ListingRepository) repository).GetListingSummaries ();
        }

        [HttpGet ("")]
        [HttpGet ("/listing/summaries")]
        public async Task<IActionResult> GetListingSummaries () {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var listing = await ((ListingRepository) repository).GetListingSummaries ();

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

        // GET: Listing/5
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

            //return View (viewModel);
            return View (viewModel);
        }

        // public async Task<IActionResult> GetListingSummaries () {
        //     return Ok ();
        // }
    }
}