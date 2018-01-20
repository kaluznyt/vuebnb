using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vuebnb.Models;

namespace vuebnb.Controllers
{
    [Produces("application/json")]
    [Route("api/Listings")]
    public class ListingsController : Controller
    {
        private readonly ListingContext _context;

        public ListingsController(ListingContext context)
        {
            _context = context;
        }

        // GET: api/Listings
        [HttpGet]
        public IEnumerable<Listing> GetListings()
        {
            return _context.Listings;
        }

        // GET: api/Listings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetListing([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listing = await _context.Listings.SingleOrDefaultAsync(m => m.Id == id);

            if (listing == null)
            {
                return NotFound();
            }

            return Ok(listing);
        }
    }
}