using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace vuebnb.Models {
    public class Listing {
        [JsonProperty ("id")]
        public int Id { get; set; }

        [JsonProperty ("title")]
        public string Title { get; set; }

        [JsonProperty ("address")]
        public string Address { get; set; }

        [JsonProperty ("about")]
        public string About { get; set; }

        [JsonProperty ("amenity_wifi")]
        public bool AmenityWifi { get; set; }

        [JsonProperty ("amenity_pets_allowed")]
        public bool AmenityPetsAllowed { get; set; }

        [JsonProperty ("amenity_tv")]
        public bool AmenityTv { get; set; }

        [JsonProperty ("amenity_kitchen")]
        public bool AmenityKitchen { get; set; }

        [JsonProperty ("amenity_breakfast")]
        public bool AmenityBreakfast { get; set; }

        [JsonProperty ("amenity_laptop")]
        public bool AmenityLaptop { get; set; }

        [JsonProperty ("price_per_night")]
        public string PricePerNight { get; set; }

        [JsonProperty ("price_extra_people")]
        public string PriceExtraPeople { get; set; }

        [JsonProperty ("price_weekly_discount")]
        public string PriceWeeklyDiscount { get; set; }

        [JsonProperty ("price_monthly_discount")]
        public string PriceMonthlyDiscount { get; set; }

        [JsonProperty ("amenities")]
        [NotMapped]
        public IEnumerable<Amenity> Amenities {
            get {
                if (AmenityWifi == true) {
                    yield return new Amenity { title = "Wireless Internet", icon = "fa-wifi" };
                }

                if (AmenityPetsAllowed == true) {
                    yield return new Amenity { title = "Pets Allowed", icon = "fa-paw" };
                }

                if (AmenityTv == true) {
                    yield return new Amenity { title = "TV", icon = "fa-television" };
                }

                if (AmenityKitchen == true) {
                    yield return new Amenity { title = "Kitchen", icon = "fa-cutlery" };
                }

                if (AmenityBreakfast == true) {
                    yield return new Amenity { title = "Breakfast", icon = "fa-coffee" };
                }

                if (AmenityLaptop == true) {
                    yield return new Amenity { title = "Laptop friendly workspace", icon = "fa-laptop" };
                }
            }
        }

        [JsonProperty ("prices")]
        [NotMapped]
        public IEnumerable<Price> Prices {
            get {

                yield return new Price { title = "Per night", value = PricePerNight };

                yield return new Price { title = "Extra people", value = PriceExtraPeople };

                yield return new Price { title = "Weekly discount", value = PriceWeeklyDiscount };

                yield return new Price { title = "Monthly discount", value = PriceMonthlyDiscount };
            }
        }

        [JsonProperty ("headerImage")]
        public string HeaderImage {
            get {
                var images = Images.ToList ();
                return images[new System.Random ().Next (0, images.Count ())];
            }
        }

        public IEnumerable<string> Images {
            get {
                var i = 0;

                while (i++ < 4) {
                    yield return $"dist/images/listings/{this.Id}/Image_{i}.jpg";
                }
            }
        }
    }

    public class Amenity {
        public string title { get; set; }
        public string icon { get; set; }
    }

    public class Price {
        public string title { get; set; }
        public string value { get; set; }
    }
}