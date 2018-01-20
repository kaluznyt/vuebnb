using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace vuebnb.Models
{
    public class ListingContext : DbContext
    {
        public ListingContext(DbContextOptions<ListingContext> options) : base(options)
        {

        }

        public DbSet<Listing> Listings { get; set; }

        public void EnsureSeedData()
        {
            var listings = JsonConvert.DeserializeObject<IList<Listing>>(File.ReadAllText(@"C:\_stuff\source\fullstack-vue-laravel\Chapter03\database\data.json"));
            listings = listings.Select(c => { c.Id = 0; return c; }).ToList();
            Listings.AddRange(listings);
            var result = this.SaveChanges();
        }
    }
}