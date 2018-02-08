using System.Collections.Generic;
using System.Threading.Tasks;

namespace vuebnb.Repositories {
    public interface IRepository<T> {
        Task<IEnumerable<T>> Get ();
        Task<T> GetByID (int Id);
        Task Insert (T item);
        Task Delete (int Id);
        Task Update (T item);
        Task Save ();
    }
}