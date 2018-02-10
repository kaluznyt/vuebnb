using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vuebnb.Models;

namespace vuebnb.Repositories {
    public class ListingRepository : IListingRepository {

        private ListingContext context;
        public ListingRepository (ListingContext context) {
            this.context = context;
        }

        public async Task<IEnumerable<object>> GetListingSummaries () {

            return await context.Listings.Select (l => new {
                title = l.Title,
                    id = l.Id,
                    address = l.Address,
                    price_per_night = l.PricePerNight,
                    thumb = l.Thumbnail
            }).ToListAsync ();
        }

        public async Task Delete (int Id) {
            var listing = await this.GetByID (Id);

            if (listing != null) {
                this.context.Remove (listing);
                await this.context.SaveChangesAsync ();
            }
        }

        public async Task<IEnumerable<Listing>> Get () {
            return await context.Listings.ToListAsync ();
        }

        public async Task<Listing> GetByID (int Id) {
            var listing = await context.Listings.SingleOrDefaultAsync (m => m.Id == Id);
            return listing;
        }
    }
}