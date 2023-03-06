using System.Collections.Generic;
using System.Threading.Tasks;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Data.Interfaces
{
    public interface IDriversRepository : IGenericRepository<DriversModel>
    {
        Task DeleteByIdentification(string identification);
        Task<ICollection<DriversModel>> FindAll();
        Task<DriversModel> FindByIdentification(string identification);
    }
}
