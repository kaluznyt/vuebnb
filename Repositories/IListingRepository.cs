using System.Collections.Generic;
using System.Threading.Tasks;
using vuebnb.Models;

namespace vuebnb.Repositories {
    public interface IListingRepository {
        Task<IEnumerable<object>> GetListingSummaries ();

        Task Delete (int Id);

        Task<IEnumerable<Listing>> Get ();

        Task<Listing> GetByID (int Id);
    }
}