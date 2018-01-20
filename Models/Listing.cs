using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace vuebnb.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        [JsonProperty("amenity_wifi")]
        public bool AmenityWifi { get; set; }
        [JsonProperty("amenity_pets_allowed")]
        public bool AmenityPetsAllowed { get; set; }
        [JsonProperty("amenity_tv")]
        public bool AmenityTv { get; set; }
        [JsonProperty("amenity_kitchen")]
        public bool AmenityKitchen { get; set; }
        [JsonProperty("amenity_breakfast")]
        public bool AmenityBreakfast { get; set; }
        [JsonProperty("amenity_laptop")]
        public bool AmenityLaptop { get; set; }
        [JsonProperty("price_per_night")]
        public string PricePerNight { get; set; }
        [JsonProperty("price_extra_people")]
        public string PriceExtraPeople { get; set; }
        [JsonProperty("price_weekly_discount")]
        public string PriceWeeklyDiscount { get; set; }
        [JsonProperty("price_monthly_discount")]
        public string PriceMonthlyDiscount { get; set; }

        public IEnumerable<string> Images
        {
            get
            {
                var i = 0;

                while (i++ < 4)
                {
                    yield return $"images/{this.Id}/Image_{i}.jpg";
                }
            }
        }
    }
}
