using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vuebnb.Models;

namespace vuebnb.Repositories {
    public class ListingRepository : IRepository<Listing> {

        private ListingContext context;
        public ListingRepository (ListingContext context) {
            this.context = context;
        }

        public async Task<IEnumerable<object>> GetListingSummaries () {
            var listing = context.Listings.Select (l => new {
                title = l.Title,
                    id = l.Id,
                    address = l.Address,
                    price_per_night = l.PricePerNight,
                    thumb = l.Thumbnail
            });

            return listing;
        }

        public async Task Delete (int Id) {
            var listing = await this.GetByID (Id);

            if (listing != null) {
                this.context.Remove (listing);
                await this.context.SaveChangesAsync ();
            }
        }

        public async Task<IEnumerable<Listing>> Get () {
            return context.Listings;
        }

        public async Task<Listing> GetByID (int Id) {
            var listing = await context.Listings.SingleOrDefaultAsync (m => m.Id == Id);
            return listing;
        }

        public async Task Insert (Listing item) {
            throw new System.NotImplementedException ();
        }

        public async Task Save () {
            await this.context.SaveChangesAsync ();
        }

        public async Task Update (Listing item) {
            throw new System.NotImplementedException ();
        }
    }
}