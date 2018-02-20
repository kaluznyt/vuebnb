using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace vuebnb.Models {
    public class ListingContext : DbContext {
        public ListingContext (DbContextOptions<ListingContext> options) : base (options) { }

        public DbSet<Listing> Listings { get; set; }

        public static void SeedData (ListingContext context) {
            context.Database.EnsureCreated ();

            if (!context.Listings.Any ()) {
                var listings = JsonConvert.DeserializeObject<IList<Listing>> (File.ReadAllText (@"C:\_source\vuebnb\Database\data.json"));
                listings = listings.Select (c => { c.Id = 0; return c; }).ToList ();
                context.Listings.AddRange (listings);
                var result = context.SaveChanges ();
            }
        }
    }
}